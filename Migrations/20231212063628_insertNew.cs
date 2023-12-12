using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE_Demo_Code.Migrations
{
    /// <inheritdoc />
    public partial class insertNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO AppUsers(Id, Name, Email, Password, ConfirmPassword) VALUES('1', 'Ngwueche Wisdom', 'wisdom@gmail.com', 'huoivas', 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
