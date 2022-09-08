﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotLineServices.Data.Migrations
{
    public partial class updatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catches",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempFarenheit = table.Column<float>(type: "real", nullable: false),
                    WeatherCondition = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CatchTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeightLbs = table.Column<float>(type: "real", nullable: false),
                    Length = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catches", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catches");
        }
    }
}
