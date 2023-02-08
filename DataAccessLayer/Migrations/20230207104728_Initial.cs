using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataFields",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objects",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Readings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<short>(type: "smallint", nullable: false),
                    ObjectId = table.Column<short>(type: "smallint", nullable: false),
                    DataFieldId = table.Column<short>(type: "smallint", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Readings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { (short)1, "Location_1", "Building_Name_1" },
                    { (short)2, "Location_2", "Building_Name_2" },
                    { (short)3, "Location_3", "Building_Name_3" },
                    { (short)4, "Location_4", "Building_Name_4" },
                    { (short)5, "Location_5", "Building_Name_5" },
                    { (short)6, "Location_6", "Building_Name_6" },
                    { (short)7, "Location_7", "Building_Name_7" },
                    { (short)8, "Location_8", "Building_Name_8" },
                    { (short)9, "Location_9", "Building_Name_9" },
                    { (short)10, "Location_10", "Building_Name_10" },
                    { (short)11, "Location_11", "Building_Name_11" },
                    { (short)12, "Location_12", "Building_Name_12" },
                    { (short)13, "Location_13", "Building_Name_13" },
                    { (short)14, "Location_14", "Building_Name_14" },
                    { (short)15, "Location_15", "Building_Name_15" },
                    { (short)16, "Location_16", "Building_Name_16" },
                    { (short)17, "Location_17", "Building_Name_17" },
                    { (short)18, "Location_18", "Building_Name_18" },
                    { (short)19, "Location_19", "Building_Name_19" },
                    { (short)20, "Location_20", "Building_Name_20" },
                    { (short)21, "Location_21", "Building_Name_21" },
                    { (short)22, "Location_22", "Building_Name_22" },
                    { (short)23, "Location_23", "Building_Name_23" },
                    { (short)24, "Location_24", "Building_Name_24" },
                    { (short)25, "Location_25", "Building_Name_25" },
                    { (short)26, "Location_26", "Building_Name_26" },
                    { (short)27, "Location_27", "Building_Name_27" },
                    { (short)28, "Location_28", "Building_Name_28" },
                    { (short)29, "Location_29", "Building_Name_29" },
                    { (short)30, "Location_30", "Building_Name_30" },
                    { (short)31, "Location_31", "Building_Name_31" },
                    { (short)32, "Location_32", "Building_Name_32" },
                    { (short)33, "Location_33", "Building_Name_33" },
                    { (short)34, "Location_34", "Building_Name_34" },
                    { (short)35, "Location_35", "Building_Name_35" },
                    { (short)36, "Location_36", "Building_Name_36" },
                    { (short)37, "Location_37", "Building_Name_37" },
                    { (short)38, "Location_38", "Building_Name_38" },
                    { (short)39, "Location_39", "Building_Name_39" },
                    { (short)40, "Location_40", "Building_Name_40" },
                    { (short)41, "Location_41", "Building_Name_41" },
                    { (short)42, "Location_42", "Building_Name_42" },
                    { (short)43, "Location_43", "Building_Name_43" },
                    { (short)44, "Location_44", "Building_Name_44" },
                    { (short)45, "Location_45", "Building_Name_45" },
                    { (short)46, "Location_46", "Building_Name_46" },
                    { (short)47, "Location_47", "Building_Name_47" },
                    { (short)48, "Location_48", "Building_Name_48" },
                    { (short)49, "Location_49", "Building_Name_49" },
                    { (short)50, "Location_50", "Building_Name_50" },
                    { (short)51, "Location_51", "Building_Name_51" },
                    { (short)52, "Location_52", "Building_Name_52" },
                    { (short)53, "Location_53", "Building_Name_53" },
                    { (short)54, "Location_54", "Building_Name_54" },
                    { (short)55, "Location_55", "Building_Name_55" },
                    { (short)56, "Location_56", "Building_Name_56" },
                    { (short)57, "Location_57", "Building_Name_57" },
                    { (short)58, "Location_58", "Building_Name_58" },
                    { (short)59, "Location_59", "Building_Name_59" },
                    { (short)60, "Location_60", "Building_Name_60" },
                    { (short)61, "Location_61", "Building_Name_61" },
                    { (short)62, "Location_62", "Building_Name_62" },
                    { (short)63, "Location_63", "Building_Name_63" },
                    { (short)64, "Location_64", "Building_Name_64" },
                    { (short)65, "Location_65", "Building_Name_65" },
                    { (short)66, "Location_66", "Building_Name_66" },
                    { (short)67, "Location_67", "Building_Name_67" },
                    { (short)68, "Location_68", "Building_Name_68" },
                    { (short)69, "Location_69", "Building_Name_69" },
                    { (short)70, "Location_70", "Building_Name_70" },
                    { (short)71, "Location_71", "Building_Name_71" },
                    { (short)72, "Location_72", "Building_Name_72" },
                    { (short)73, "Location_73", "Building_Name_73" },
                    { (short)74, "Location_74", "Building_Name_74" },
                    { (short)75, "Location_75", "Building_Name_75" },
                    { (short)76, "Location_76", "Building_Name_76" },
                    { (short)77, "Location_77", "Building_Name_77" },
                    { (short)78, "Location_78", "Building_Name_78" },
                    { (short)79, "Location_79", "Building_Name_79" },
                    { (short)80, "Location_80", "Building_Name_80" },
                    { (short)81, "Location_81", "Building_Name_81" },
                    { (short)82, "Location_82", "Building_Name_82" },
                    { (short)83, "Location_83", "Building_Name_83" },
                    { (short)84, "Location_84", "Building_Name_84" },
                    { (short)85, "Location_85", "Building_Name_85" },
                    { (short)86, "Location_86", "Building_Name_86" },
                    { (short)87, "Location_87", "Building_Name_87" },
                    { (short)88, "Location_88", "Building_Name_88" },
                    { (short)89, "Location_89", "Building_Name_89" },
                    { (short)90, "Location_90", "Building_Name_90" },
                    { (short)91, "Location_91", "Building_Name_91" },
                    { (short)92, "Location_92", "Building_Name_92" },
                    { (short)93, "Location_93", "Building_Name_93" },
                    { (short)94, "Location_94", "Building_Name_94" },
                    { (short)95, "Location_95", "Building_Name_95" },
                    { (short)96, "Location_96", "Building_Name_96" },
                    { (short)97, "Location_97", "Building_Name_97" },
                    { (short)98, "Location_98", "Building_Name_98" },
                    { (short)99, "Location_99", "Building_Name_99" },
                    { (short)100, "Location_100", "Building_Name_100" }
                });

            migrationBuilder.InsertData(
                table: "DataFields",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (short)1, "Effiency" },
                    { (short)2, "Power" }
                });

            migrationBuilder.InsertData(
                table: "Objects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { (short)1, "Chiller" },
                    { (short)2, "Chilled Water Pump" },
                    { (short)3, "Condenser Water Pump" },
                    { (short)4, "Cooling Tower" },
                    { (short)5, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "DataFields");

            migrationBuilder.DropTable(
                name: "Objects");

            migrationBuilder.DropTable(
                name: "Readings");
        }
    }
}
