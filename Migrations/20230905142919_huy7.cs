using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webenglishfinal.Migrations
{
    public partial class huy7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "typeofExes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "typeofExes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "idLesson",
                table: "tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "lessonIdLesson",
                table: "tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "markpass",
                table: "tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "tests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "statuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "accountusername",
                table: "statuses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idTest",
                table: "statuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mark",
                table: "statuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "testIdTest",
                table: "statuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "timeEnd",
                table: "statuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "timeStart",
                table: "statuses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "content",
                table: "reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "datesend",
                table: "reports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "idStatus",
                table: "reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "statusIdstatus",
                table: "reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTest",
                table: "recommands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "path",
                table: "recommands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "accountusername",
                table: "ranks",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "mark",
                table: "ranks",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<long>(
                name: "ranknumber",
                table: "ranks",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "ranks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeEnd",
                table: "lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatetimeStart",
                table: "lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "dateUpdate",
                table: "lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "gradeId",
                table: "lessons",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "idGrade",
                table: "lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "content",
                table: "incorrectSens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "idReport",
                table: "incorrectSens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "reportidReport",
                table: "incorrectSens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "grades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "grades",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "exercise",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "idTest",
                table: "exercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTypeofExe",
                table: "exercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mark",
                table: "exercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "passpercent",
                table: "exercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "testIdTest",
                table: "exercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "typeofExeIdType",
                table: "exercise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "detailGradeAccounts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "accountusername",
                table: "detailGradeAccounts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "gradeId",
                table: "detailGradeAccounts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idGrade",
                table: "detailGradeAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "isActive",
                table: "detailGradeAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Desciption",
                table: "catalouges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "symbols",
                table: "catalouges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_tests_lessonIdLesson",
                table: "tests",
                column: "lessonIdLesson");

            migrationBuilder.CreateIndex(
                name: "IX_statuses_accountusername",
                table: "statuses",
                column: "accountusername");

            migrationBuilder.CreateIndex(
                name: "IX_statuses_testIdTest",
                table: "statuses",
                column: "testIdTest");

            migrationBuilder.CreateIndex(
                name: "IX_reports_statusIdstatus",
                table: "reports",
                column: "statusIdstatus");

            migrationBuilder.CreateIndex(
                name: "IX_ranks_accountusername",
                table: "ranks",
                column: "accountusername");

            migrationBuilder.CreateIndex(
                name: "IX_lessons_gradeId",
                table: "lessons",
                column: "gradeId");

            migrationBuilder.CreateIndex(
                name: "IX_incorrectSens_reportidReport",
                table: "incorrectSens",
                column: "reportidReport");

            migrationBuilder.CreateIndex(
                name: "IX_exercise_testIdTest",
                table: "exercise",
                column: "testIdTest");

            migrationBuilder.CreateIndex(
                name: "IX_exercise_typeofExeIdType",
                table: "exercise",
                column: "typeofExeIdType");

            migrationBuilder.CreateIndex(
                name: "IX_detailGradeAccounts_accountusername",
                table: "detailGradeAccounts",
                column: "accountusername");

            migrationBuilder.CreateIndex(
                name: "IX_detailGradeAccounts_gradeId",
                table: "detailGradeAccounts",
                column: "gradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_detailGradeAccounts_accounts_accountusername",
                table: "detailGradeAccounts",
                column: "accountusername",
                principalTable: "accounts",
                principalColumn: "username");

            migrationBuilder.AddForeignKey(
                name: "FK_detailGradeAccounts_grades_gradeId",
                table: "detailGradeAccounts",
                column: "gradeId",
                principalTable: "grades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_exercise_tests_testIdTest",
                table: "exercise",
                column: "testIdTest",
                principalTable: "tests",
                principalColumn: "IdTest",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_exercise_typeofExes_typeofExeIdType",
                table: "exercise",
                column: "typeofExeIdType",
                principalTable: "typeofExes",
                principalColumn: "IdType",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_incorrectSens_reports_reportidReport",
                table: "incorrectSens",
                column: "reportidReport",
                principalTable: "reports",
                principalColumn: "idReport",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_lessons_grades_gradeId",
                table: "lessons",
                column: "gradeId",
                principalTable: "grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ranks_accounts_accountusername",
                table: "ranks",
                column: "accountusername",
                principalTable: "accounts",
                principalColumn: "username");

            migrationBuilder.AddForeignKey(
                name: "FK_reports_statuses_statusIdstatus",
                table: "reports",
                column: "statusIdstatus",
                principalTable: "statuses",
                principalColumn: "Idstatus",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_statuses_accounts_accountusername",
                table: "statuses",
                column: "accountusername",
                principalTable: "accounts",
                principalColumn: "username");

            migrationBuilder.AddForeignKey(
                name: "FK_statuses_tests_testIdTest",
                table: "statuses",
                column: "testIdTest",
                principalTable: "tests",
                principalColumn: "IdTest",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tests_lessons_lessonIdLesson",
                table: "tests",
                column: "lessonIdLesson",
                principalTable: "lessons",
                principalColumn: "IdLesson",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_detailGradeAccounts_accounts_accountusername",
                table: "detailGradeAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_detailGradeAccounts_grades_gradeId",
                table: "detailGradeAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_exercise_tests_testIdTest",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_exercise_typeofExes_typeofExeIdType",
                table: "exercise");

            migrationBuilder.DropForeignKey(
                name: "FK_incorrectSens_reports_reportidReport",
                table: "incorrectSens");

            migrationBuilder.DropForeignKey(
                name: "FK_lessons_grades_gradeId",
                table: "lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_ranks_accounts_accountusername",
                table: "ranks");

            migrationBuilder.DropForeignKey(
                name: "FK_reports_statuses_statusIdstatus",
                table: "reports");

            migrationBuilder.DropForeignKey(
                name: "FK_statuses_accounts_accountusername",
                table: "statuses");

            migrationBuilder.DropForeignKey(
                name: "FK_statuses_tests_testIdTest",
                table: "statuses");

            migrationBuilder.DropForeignKey(
                name: "FK_tests_lessons_lessonIdLesson",
                table: "tests");

            migrationBuilder.DropIndex(
                name: "IX_tests_lessonIdLesson",
                table: "tests");

            migrationBuilder.DropIndex(
                name: "IX_statuses_accountusername",
                table: "statuses");

            migrationBuilder.DropIndex(
                name: "IX_statuses_testIdTest",
                table: "statuses");

            migrationBuilder.DropIndex(
                name: "IX_reports_statusIdstatus",
                table: "reports");

            migrationBuilder.DropIndex(
                name: "IX_ranks_accountusername",
                table: "ranks");

            migrationBuilder.DropIndex(
                name: "IX_lessons_gradeId",
                table: "lessons");

            migrationBuilder.DropIndex(
                name: "IX_incorrectSens_reportidReport",
                table: "incorrectSens");

            migrationBuilder.DropIndex(
                name: "IX_exercise_testIdTest",
                table: "exercise");

            migrationBuilder.DropIndex(
                name: "IX_exercise_typeofExeIdType",
                table: "exercise");

            migrationBuilder.DropIndex(
                name: "IX_detailGradeAccounts_accountusername",
                table: "detailGradeAccounts");

            migrationBuilder.DropIndex(
                name: "IX_detailGradeAccounts_gradeId",
                table: "detailGradeAccounts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "typeofExes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "typeofExes");

            migrationBuilder.DropColumn(
                name: "idLesson",
                table: "tests");

            migrationBuilder.DropColumn(
                name: "lessonIdLesson",
                table: "tests");

            migrationBuilder.DropColumn(
                name: "markpass",
                table: "tests");

            migrationBuilder.DropColumn(
                name: "name",
                table: "tests");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "statuses");

            migrationBuilder.DropColumn(
                name: "accountusername",
                table: "statuses");

            migrationBuilder.DropColumn(
                name: "idTest",
                table: "statuses");

            migrationBuilder.DropColumn(
                name: "mark",
                table: "statuses");

            migrationBuilder.DropColumn(
                name: "testIdTest",
                table: "statuses");

            migrationBuilder.DropColumn(
                name: "timeEnd",
                table: "statuses");

            migrationBuilder.DropColumn(
                name: "timeStart",
                table: "statuses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "roles");

            migrationBuilder.DropColumn(
                name: "content",
                table: "reports");

            migrationBuilder.DropColumn(
                name: "datesend",
                table: "reports");

            migrationBuilder.DropColumn(
                name: "idStatus",
                table: "reports");

            migrationBuilder.DropColumn(
                name: "statusIdstatus",
                table: "reports");

            migrationBuilder.DropColumn(
                name: "idTest",
                table: "recommands");

            migrationBuilder.DropColumn(
                name: "path",
                table: "recommands");

            migrationBuilder.DropColumn(
                name: "accountusername",
                table: "ranks");

            migrationBuilder.DropColumn(
                name: "mark",
                table: "ranks");

            migrationBuilder.DropColumn(
                name: "ranknumber",
                table: "ranks");

            migrationBuilder.DropColumn(
                name: "username",
                table: "ranks");

            migrationBuilder.DropColumn(
                name: "DateTimeEnd",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "DatetimeStart",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "dateUpdate",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "gradeId",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "idGrade",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "content",
                table: "incorrectSens");

            migrationBuilder.DropColumn(
                name: "idReport",
                table: "incorrectSens");

            migrationBuilder.DropColumn(
                name: "reportidReport",
                table: "incorrectSens");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "grades");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "grades");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "exercise");

            migrationBuilder.DropColumn(
                name: "idTest",
                table: "exercise");

            migrationBuilder.DropColumn(
                name: "idTypeofExe",
                table: "exercise");

            migrationBuilder.DropColumn(
                name: "mark",
                table: "exercise");

            migrationBuilder.DropColumn(
                name: "passpercent",
                table: "exercise");

            migrationBuilder.DropColumn(
                name: "testIdTest",
                table: "exercise");

            migrationBuilder.DropColumn(
                name: "typeofExeIdType",
                table: "exercise");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "detailGradeAccounts");

            migrationBuilder.DropColumn(
                name: "accountusername",
                table: "detailGradeAccounts");

            migrationBuilder.DropColumn(
                name: "gradeId",
                table: "detailGradeAccounts");

            migrationBuilder.DropColumn(
                name: "idGrade",
                table: "detailGradeAccounts");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "detailGradeAccounts");

            migrationBuilder.DropColumn(
                name: "Desciption",
                table: "catalouges");

            migrationBuilder.DropColumn(
                name: "symbols",
                table: "catalouges");
        }
    }
}
