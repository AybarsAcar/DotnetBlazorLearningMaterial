﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
  public partial class RoomModelAdded : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
        name: "HotelRooms",
        columns: table => new
        {
          Id = table.Column<int>(type: "INTEGER", nullable: false)
            .Annotation("Sqlite:Autoincrement", true),
          Name = table.Column<string>(type: "TEXT", nullable: false),
          Occupancy = table.Column<int>(type: "INTEGER", nullable: false),
          RegularRate = table.Column<double>(type: "REAL", nullable: false),
          Details = table.Column<string>(type: "TEXT", nullable: true),
          SqFt = table.Column<string>(type: "TEXT", nullable: true),
          CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
          CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
          UpdatedBy = table.Column<string>(type: "TEXT", nullable: true),
          UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
        },
        constraints: table => { table.PrimaryKey("PK_HotelRooms", x => x.Id); });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
        name: "HotelRooms");
    }
  }
}