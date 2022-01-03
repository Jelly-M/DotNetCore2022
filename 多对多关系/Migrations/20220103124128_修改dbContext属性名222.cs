using Microsoft.EntityFrameworkCore.Migrations;

namespace 多对多关系.Migrations
{
    public partial class 修改dbContext属性名222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Teacher_Student_T_Students_StudentsId",
                table: "T_Teacher_Student");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Teacher_Student_T_Teacher_TeachersId",
                table: "T_Teacher_Student");

            migrationBuilder.RenameColumn(
                name: "TeachersId",
                table: "T_Teacher_Student",
                newName: "Teachers2Id");

            migrationBuilder.RenameColumn(
                name: "StudentsId",
                table: "T_Teacher_Student",
                newName: "Students1Id");

            migrationBuilder.RenameIndex(
                name: "IX_T_Teacher_Student_TeachersId",
                table: "T_Teacher_Student",
                newName: "IX_T_Teacher_Student_Teachers2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Teacher_Student_T_Students_Students1Id",
                table: "T_Teacher_Student",
                column: "Students1Id",
                principalTable: "T_Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Teacher_Student_T_Teacher_Teachers2Id",
                table: "T_Teacher_Student",
                column: "Teachers2Id",
                principalTable: "T_Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Teacher_Student_T_Students_Students1Id",
                table: "T_Teacher_Student");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Teacher_Student_T_Teacher_Teachers2Id",
                table: "T_Teacher_Student");

            migrationBuilder.RenameColumn(
                name: "Teachers2Id",
                table: "T_Teacher_Student",
                newName: "TeachersId");

            migrationBuilder.RenameColumn(
                name: "Students1Id",
                table: "T_Teacher_Student",
                newName: "StudentsId");

            migrationBuilder.RenameIndex(
                name: "IX_T_Teacher_Student_Teachers2Id",
                table: "T_Teacher_Student",
                newName: "IX_T_Teacher_Student_TeachersId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Teacher_Student_T_Students_StudentsId",
                table: "T_Teacher_Student",
                column: "StudentsId",
                principalTable: "T_Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Teacher_Student_T_Teacher_TeachersId",
                table: "T_Teacher_Student",
                column: "TeachersId",
                principalTable: "T_Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
