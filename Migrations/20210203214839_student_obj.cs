using Microsoft.EntityFrameworkCore.Migrations;

namespace Student_WebAPI.Migrations
{
    public partial class student_obj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    student_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    course_Duration = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
