using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Data.Migrations
{
    public partial class CleanArchitectureDiego : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Videos",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Videos",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Videos",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Videos",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "VideoActor",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "VideoActor",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "VideoActor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "VideoActor",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "VideoActor",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Streamers",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Streamers",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Streamers",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Streamers",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Directores",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Directores",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Directores",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Directores",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Actors",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Actors",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Actors",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "Actors",
                type: "datetime(6)",
                nullable: true);

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Directores",
            //    table: "Directores",
            //    column: "Id");

            //migrationBuilder.AddPrimaryKey(
            //    name: "PK_Actors",
            //    table: "Actors",
            //    column: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Directores_Videos_VideoId",
            //    table: "Directores",
            //    column: "VideoId",
            //    principalTable: "Videos",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_VideoActor_Actors_ActorId",
            //    table: "VideoActor",
            //    column: "ActorId",
            //    principalTable: "Actors",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropForeignKey(
        //        name: "FK_Directores_Videos_VideoId",
        //        table: "Directores");

        //    migrationBuilder.DropForeignKey(
        //        name: "FK_VideoActor_Actors_ActorId",
        //        table: "VideoActor");

        //    migrationBuilder.DropPrimaryKey(
        //        name: "PK_Directores",
        //        table: "Directores");

        //    migrationBuilder.DropPrimaryKey(
        //        name: "PK_Actors",
        //        table: "Actors");

        //    migrationBuilder.DropColumn(
        //        name: "CreatedBy",
        //        table: "Videos");

        //    migrationBuilder.DropColumn(
        //        name: "CreatedDate",
        //        table: "Videos");

        //    migrationBuilder.DropColumn(
        //        name: "LastModifiedBy",
        //        table: "Videos");

        //    migrationBuilder.DropColumn(
        //        name: "LastModifiedDate",
        //        table: "Videos");

        //    migrationBuilder.DropColumn(
        //        name: "CreatedBy",
        //        table: "VideoActor");

        //    migrationBuilder.DropColumn(
        //        name: "CreatedDate",
        //        table: "VideoActor");

        //    migrationBuilder.DropColumn(
        //        name: "Id",
        //        table: "VideoActor");

        //    migrationBuilder.DropColumn(
        //        name: "LastModifiedBy",
        //        table: "VideoActor");

        //    migrationBuilder.DropColumn(
        //        name: "LastModifiedDate",
        //        table: "VideoActor");

        //    migrationBuilder.DropColumn(
        //        name: "CreatedBy",
        //        table: "Streamers");

        //    migrationBuilder.DropColumn(
        //        name: "CreatedDate",
        //        table: "Streamers");

        //    migrationBuilder.DropColumn(
        //        name: "LastModifiedBy",
        //        table: "Streamers");

        //    migrationBuilder.DropColumn(
        //        name: "LastModifiedDate",
        //        table: "Streamers");

        //    migrationBuilder.DropColumn(
        //        name: "CreatedBy",
        //        table: "Directores");

        //    migrationBuilder.DropColumn(
        //        name: "CreatedDate",
        //        table: "Directores");

        //    migrationBuilder.DropColumn(
        //        name: "LastModifiedBy",
        //        table: "Directores");

        //    migrationBuilder.DropColumn(
        //        name: "LastModifiedDate",
        //        table: "Directores");

        //    migrationBuilder.DropColumn(
        //        name: "CreatedBy",
        //        table: "Actors");

        //    migrationBuilder.DropColumn(
        //        name: "CreatedDate",
        //        table: "Actors");

        //    migrationBuilder.DropColumn(
        //        name: "LastModifiedBy",
        //        table: "Actors");

        //    migrationBuilder.DropColumn(
        //        name: "LastModifiedDate",
        //        table: "Actors");

        //    migrationBuilder.RenameTable(
        //        name: "Directores",
        //        newName: "Director");

        //    migrationBuilder.RenameTable(
        //        name: "Actors",
        //        newName: "Actor");

        //    migrationBuilder.RenameIndex(
        //        name: "IX_Directores_VideoId",
        //        table: "Director",
        //        newName: "IX_Director_VideoId");

        //    migrationBuilder.AddPrimaryKey(
        //        name: "PK_Director",
        //        table: "Director",
        //        column: "Id");

        //    migrationBuilder.AddPrimaryKey(
        //        name: "PK_Actor",
        //        table: "Actor",
        //        column: "Id");

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_Director_Videos_VideoId",
        //        table: "Director",
        //        column: "VideoId",
        //        principalTable: "Videos",
        //        principalColumn: "Id",
        //        onDelete: ReferentialAction.Cascade);

        //    migrationBuilder.AddForeignKey(
        //        name: "FK_VideoActor_Actor_ActorId",
        //        table: "VideoActor",
        //        column: "ActorId",
        //        principalTable: "Actor",
        //        principalColumn: "Id",
        //        onDelete: ReferentialAction.Cascade);
        //}
    }
}
