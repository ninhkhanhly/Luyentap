using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Khanhlyluyentap1.Migrations
{
    /// <inheritdoc />
    public partial class AnhXaLan1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lop",
                columns: table => new
                {
                    MaLop = table.Column<string>(type: "TEXT", nullable: false),
                    TenLop = table.Column<string>(type: "TEXT", nullable: false),
                    MaSinhVien = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop", x => x.MaLop);
                });

            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MaSinhVien = table.Column<string>(type: "TEXT", nullable: false),
                    TenSinhVien = table.Column<string>(type: "TEXT", nullable: false),
                    GioiTinh = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.MaSinhVien);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lop");

            migrationBuilder.DropTable(
                name: "SinhVien");
        }
    }
}
