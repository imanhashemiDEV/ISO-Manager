using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ISO_Manager.Data.Migrations
{
    /// <inheritdoc />
    public partial class starter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employment_type",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mobile",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "national_code",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "register_code",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    e_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asset_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serial_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    device_user = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspection_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calibrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asset_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    serial_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    device_owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    device_user = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    start_calibration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_calibration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calibrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cartables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cloth_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receive_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    receive_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    size = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clothes_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClothGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employer_mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_agent_mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hse_agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hse_agent_mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personnel_count = table.Column<int>(type: "int", nullable: true),
                    contract_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rig_boss_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    camp_boss_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    doctor_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyReports_AspNetUsers_camp_boss_id",
                        column: x => x.camp_boss_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DailyReports_AspNetUsers_doctor_id",
                        column: x => x.doctor_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DailyReports_AspNetUsers_rig_boss_id",
                        column: x => x.rig_boss_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Duties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    step = table.Column<double>(type: "float", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyPhoneBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city_phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    company_phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    organization_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyPhoneBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HarmfulFactor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarmfulFactor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InspectionPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionPlaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LegalRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regulation_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    regulation_organization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    regulation_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maneuvers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<int>(type: "int", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    act_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maneuvers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sender_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    receiver_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_receiver_id",
                        column: x => x.receiver_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_sender_id",
                        column: x => x.sender_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    occupation_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    occupation_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficialAccidents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accident_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    accident_hour = table.Column<TimeOnly>(type: "time", nullable: true),
                    marriage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    activity_in_accident = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direct_accident_causes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unsafe_action_causes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unsafe_condition_causes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_boss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doctor_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    examination_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    hse_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_guilty = table.Column<short>(type: "smallint", nullable: true),
                    accident_consequence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_complication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_injured_part = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hse_boss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lost_days = table.Column<int>(type: "int", nullable: true),
                    receive_report_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialAccidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficialAccidents_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    permit_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    permit_attachment_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    permit_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    permit_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    responsible = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purposes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reminders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reminder_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reminders_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RigAssets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asset_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    default_count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exist_count = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    count_unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    position_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RigAssets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Standards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    standard_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fa_chapter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fa_subchapter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fa_text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPermits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expire_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPermits_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Workplaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workplaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClothGroupLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    shoes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    boiler_suit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cloth_group_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothGroupLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClothGroupLists_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClothGroupLists_ClothGroups_cloth_group_id",
                        column: x => x.cloth_group_id,
                        principalTable: "ClothGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractorAccidents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accident_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    accident_hour = table.Column<TimeOnly>(type: "time", nullable: true),
                    marriage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    activity_in_accident = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direct_accident_causes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unsafe_action_causes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unsafe_condition_causes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_boss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hse_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_guilty = table.Column<short>(type: "smallint", nullable: true),
                    accident_consequence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_complication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accident_injured_part = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hse_boss = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lost_days = table.Column<int>(type: "int", nullable: true),
                    receive_report_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    contractor_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorAccidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractorAccidents_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContractorAccidents_Contractors_contractor_id",
                        column: x => x.contractor_id,
                        principalTable: "Contractors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    examination_date = table.Column<int>(type: "int", nullable: true),
                    examination_result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    contractor_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examinations_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Examinations_Contractors_contractor_id",
                        column: x => x.contractor_id,
                        principalTable: "Contractors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HarmfulItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    harmful_factor_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarmfulItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HarmfulItem_HarmfulFactor_harmful_factor_id",
                        column: x => x.harmful_factor_id,
                        principalTable: "HarmfulFactor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InspectionTexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    step = table.Column<int>(type: "int", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    inspection_place_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionTexts_InspectionPlaces_inspection_place_id",
                        column: x => x.inspection_place_id,
                        principalTable: "InspectionPlaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProcessPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accept_percent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    plan_percent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    requests = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    process_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessPlans_Processes_process_id",
                        column: x => x.process_id,
                        principalTable: "Processes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OperationPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estimate = table.Column<int>(type: "int", nullable: true),
                    done = table.Column<int>(type: "int", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plan_percent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    realization_percent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    plan_realization_percent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    accept_percent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    purpose_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationPlans_Purposes_purpose_id",
                        column: x => x.purpose_id,
                        principalTable: "Purposes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ambulances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    owner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    owner_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rental_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    workplace_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambulances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ambulances_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ambulances_Workplaces_workplace_id",
                        column: x => x.workplace_id,
                        principalTable: "Workplaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmergencyTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    duty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    workplace_id = table.Column<int>(type: "int", nullable: true),
                    duty_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencyTeams_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmergencyTeams_Duties_duty_id",
                        column: x => x.duty_id,
                        principalTable: "Duties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmergencyTeams_Workplaces_workplace_id",
                        column: x => x.workplace_id,
                        principalTable: "Workplaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HealthCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    workplace_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCarts_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthCarts_Workplaces_workplace_id",
                        column: x => x.workplace_id,
                        principalTable: "Workplaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inspections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    inspection_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    workplace_id = table.Column<int>(type: "int", nullable: true),
                    inspection_place_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inspections_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inspections_InspectionPlaces_inspection_place_id",
                        column: x => x.inspection_place_id,
                        principalTable: "InspectionPlaces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inspections_Workplaces_workplace_id",
                        column: x => x.workplace_id,
                        principalTable: "Workplaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employment_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    organization_id = table.Column<int>(type: "int", nullable: true),
                    occupation_id = table.Column<int>(type: "int", nullable: true),
                    workplace_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInfos_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserInfos_Occupations_occupation_id",
                        column: x => x.occupation_id,
                        principalTable: "Occupations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserInfos_Organizations_organization_id",
                        column: x => x.organization_id,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserInfos_Workplaces_workplace_id",
                        column: x => x.workplace_id,
                        principalTable: "Workplaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OccupationHarmfuls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    exposure_source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    evaluation_method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exposure_rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exposure_duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exposure_limit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    occupation_id = table.Column<int>(type: "int", nullable: true),
                    harmful_factor_id = table.Column<int>(type: "int", nullable: true),
                    harmful_item_id = table.Column<int>(type: "int", nullable: true),
                    HarmfulItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationHarmfuls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OccupationHarmfuls_HarmfulFactor_harmful_factor_id",
                        column: x => x.harmful_factor_id,
                        principalTable: "HarmfulFactor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OccupationHarmfuls_HarmfulItem_HarmfulItemId",
                        column: x => x.HarmfulItemId,
                        principalTable: "HarmfulItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OccupationHarmfuls_Occupations_occupation_id",
                        column: x => x.occupation_id,
                        principalTable: "Occupations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InspectionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    inspection_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    inspection_id = table.Column<int>(type: "int", nullable: true),
                    text_id = table.Column<int>(type: "int", nullable: true),
                    workplace_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionDetails_InspectionTexts_text_id",
                        column: x => x.text_id,
                        principalTable: "InspectionTexts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InspectionDetails_Inspections_inspection_id",
                        column: x => x.inspection_id,
                        principalTable: "Inspections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InspectionDetails_Workplaces_workplace_id",
                        column: x => x.workplace_id,
                        principalTable: "Workplaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ambulances_user_id",
                table: "Ambulances",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ambulances_workplace_id",
                table: "Ambulances",
                column: "workplace_id");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_user_id",
                table: "Clothes",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClothGroupLists_cloth_group_id",
                table: "ClothGroupLists",
                column: "cloth_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_ClothGroupLists_user_id",
                table: "ClothGroupLists",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorAccidents_contractor_id",
                table: "ContractorAccidents",
                column: "contractor_id");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorAccidents_user_id",
                table: "ContractorAccidents",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyReports_camp_boss_id",
                table: "DailyReports",
                column: "camp_boss_id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyReports_doctor_id",
                table: "DailyReports",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_DailyReports_rig_boss_id",
                table: "DailyReports",
                column: "rig_boss_id");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyTeams_duty_id",
                table: "EmergencyTeams",
                column: "duty_id");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyTeams_user_id",
                table: "EmergencyTeams",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyTeams_workplace_id",
                table: "EmergencyTeams",
                column: "workplace_id");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_contractor_id",
                table: "Examinations",
                column: "contractor_id");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_user_id",
                table: "Examinations",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_HarmfulItem_harmful_factor_id",
                table: "HarmfulItem",
                column: "harmful_factor_id");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCarts_user_id",
                table: "HealthCarts",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCarts_workplace_id",
                table: "HealthCarts",
                column: "workplace_id");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionDetails_inspection_id",
                table: "InspectionDetails",
                column: "inspection_id");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionDetails_text_id",
                table: "InspectionDetails",
                column: "text_id");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionDetails_workplace_id",
                table: "InspectionDetails",
                column: "workplace_id");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_inspection_place_id",
                table: "Inspections",
                column: "inspection_place_id");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_user_id",
                table: "Inspections",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_workplace_id",
                table: "Inspections",
                column: "workplace_id");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionTexts_inspection_place_id",
                table: "InspectionTexts",
                column: "inspection_place_id");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_receiver_id",
                table: "Messages",
                column: "receiver_id");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_sender_id",
                table: "Messages",
                column: "sender_id");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationHarmfuls_harmful_factor_id",
                table: "OccupationHarmfuls",
                column: "harmful_factor_id");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationHarmfuls_HarmfulItemId",
                table: "OccupationHarmfuls",
                column: "HarmfulItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationHarmfuls_occupation_id",
                table: "OccupationHarmfuls",
                column: "occupation_id");

            migrationBuilder.CreateIndex(
                name: "IX_OfficialAccidents_user_id",
                table: "OfficialAccidents",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_OperationPlans_purpose_id",
                table: "OperationPlans",
                column: "purpose_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessPlans_process_id",
                table: "ProcessPlans",
                column: "process_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reminders_user_id",
                table: "Reminders",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_occupation_id",
                table: "UserInfos",
                column: "occupation_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_organization_id",
                table: "UserInfos",
                column: "organization_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_user_id",
                table: "UserInfos",
                column: "user_id",
                unique: true,
                filter: "[user_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_workplace_id",
                table: "UserInfos",
                column: "workplace_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermits_user_id",
                table: "UserPermits",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ambulances");

            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Calibrations");

            migrationBuilder.DropTable(
                name: "Cartables");

            migrationBuilder.DropTable(
                name: "Clothes");

            migrationBuilder.DropTable(
                name: "ClothGroupLists");

            migrationBuilder.DropTable(
                name: "ContractorAccidents");

            migrationBuilder.DropTable(
                name: "DailyReports");

            migrationBuilder.DropTable(
                name: "EmergencyPhoneBooks");

            migrationBuilder.DropTable(
                name: "EmergencyTeams");

            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.DropTable(
                name: "HealthCarts");

            migrationBuilder.DropTable(
                name: "InspectionDetails");

            migrationBuilder.DropTable(
                name: "LegalRequirements");

            migrationBuilder.DropTable(
                name: "Maneuvers");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "OccupationHarmfuls");

            migrationBuilder.DropTable(
                name: "OfficialAccidents");

            migrationBuilder.DropTable(
                name: "OperationPlans");

            migrationBuilder.DropTable(
                name: "Permits");

            migrationBuilder.DropTable(
                name: "ProcessPlans");

            migrationBuilder.DropTable(
                name: "Reminders");

            migrationBuilder.DropTable(
                name: "RigAssets");

            migrationBuilder.DropTable(
                name: "Standards");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "UserPermits");

            migrationBuilder.DropTable(
                name: "ClothGroups");

            migrationBuilder.DropTable(
                name: "Duties");

            migrationBuilder.DropTable(
                name: "Contractors");

            migrationBuilder.DropTable(
                name: "InspectionTexts");

            migrationBuilder.DropTable(
                name: "Inspections");

            migrationBuilder.DropTable(
                name: "HarmfulItem");

            migrationBuilder.DropTable(
                name: "Purposes");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "Occupations");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "InspectionPlaces");

            migrationBuilder.DropTable(
                name: "Workplaces");

            migrationBuilder.DropTable(
                name: "HarmfulFactor");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "employment_type",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "image",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "mobile",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "national_code",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "password",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "register_code",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
