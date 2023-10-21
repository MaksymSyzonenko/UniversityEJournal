using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University_E_Journal_PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddedAttendaces : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentID",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Subjects_SubjectID",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Teachers_TeacherID",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "Subjects",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects",
                newName: "IX_Subjects_TeacherId");

            migrationBuilder.RenameColumn(
                name: "GroupID",
                table: "Students",
                newName: "GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupID",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "Grades",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "SubjectID",
                table: "Grades",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Grades",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_TeacherID",
                table: "Grades",
                newName: "IX_Grades_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_SubjectID",
                table: "Grades",
                newName: "IX_Grades_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_StudentID",
                table: "Grades",
                newName: "IX_Grades_StudentId");

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Attended = table.Column<bool>(type: "boolean", nullable: false),
                    AttendDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_SubjectId",
                table: "Attendances",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Subjects_SubjectId",
                table: "Grades",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Teachers_TeacherId",
                table: "Grades",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherId",
                table: "Subjects",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Subjects_SubjectId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Teachers_TeacherId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherId",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Subjects",
                newName: "TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subjects",
                newName: "IX_Subjects_TeacherID");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Students",
                newName: "GroupID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "Students",
                newName: "IX_Students_GroupID");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Grades",
                newName: "TeacherID");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Grades",
                newName: "SubjectID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Grades",
                newName: "StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_TeacherId",
                table: "Grades",
                newName: "IX_Grades_TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_SubjectId",
                table: "Grades",
                newName: "IX_Grades_SubjectID");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                newName: "IX_Grades_StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentID",
                table: "Grades",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Subjects_SubjectID",
                table: "Grades",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Teachers_TeacherID",
                table: "Grades",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupID",
                table: "Students",
                column: "GroupID",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
