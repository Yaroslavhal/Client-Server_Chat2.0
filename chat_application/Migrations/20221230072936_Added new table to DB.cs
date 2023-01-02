using Microsoft.EntityFrameworkCore.Migrations;

namespace chat_application.Migrations
{
    public partial class AddednewtabletoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Saved_messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(maxLength: 255, nullable: false),
                    UserName = table.Column<string>(maxLength: 255, nullable: false),
                    Text = table.Column<string>(maxLength: 255, nullable: false),
                    Photo = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saved_messages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Saved_messages");
        }
    }
}
