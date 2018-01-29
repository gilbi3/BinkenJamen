using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BinkenJamen.Migrations
{
	public partial class Init : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Binks",
				columns: table => new
				{
					Id = table.Column<int>(nullable: false)
						.Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
					ImageUrl = table.Column<string>(nullable: true),
					IsFavorite = table.Column<bool>(nullable: false),
					LongDescription = table.Column<string>(nullable: true),
					Nickname = table.Column<string>(nullable: true),
					ShortDescription = table.Column<string>(nullable: true),
					ThumbnailUrl = table.Column<string>(nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Binks", x => x.Id);
				});
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Binks");
		}
	}
}