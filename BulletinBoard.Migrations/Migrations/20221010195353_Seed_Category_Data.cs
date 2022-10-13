using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulletinBoard.Migrations.Migrations
{
    public partial class Seed_Category_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = 
                $"INSERT INTO public.\"Category\" (\"Id\", \"Title\") VALUES('{Guid.NewGuid()}', '123')";
            migrationBuilder.Sql(sql);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
