using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesInvoiceTestApi.Migrations
{
    /// <inheritdoc />
    public partial class INVOCICEcHNAGES : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_InvoiceDetails_InvoiceId",
                table: "InvoiceItems");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceDetailInvoiceId",
                table: "InvoiceItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceDetailInvoiceId",
                table: "InvoiceItems",
                column: "InvoiceDetailInvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_InvoiceDetails_InvoiceDetailInvoiceId",
                table: "InvoiceItems",
                column: "InvoiceDetailInvoiceId",
                principalTable: "InvoiceDetails",
                principalColumn: "InvoiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_InvoiceDetails_InvoiceDetailInvoiceId",
                table: "InvoiceItems");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceItems_InvoiceDetailInvoiceId",
                table: "InvoiceItems");

            migrationBuilder.DropColumn(
                name: "InvoiceDetailInvoiceId",
                table: "InvoiceItems");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItems_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_InvoiceDetails_InvoiceId",
                table: "InvoiceItems",
                column: "InvoiceId",
                principalTable: "InvoiceDetails",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
