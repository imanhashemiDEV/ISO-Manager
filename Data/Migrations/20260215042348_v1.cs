using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ISO_Manager.Data.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(Type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(Type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(Type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(Type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(Type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(Type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Name = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    RegisterCode = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    NationalCode = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    EmploymentType = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    UserName = table.Column<string>(Type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(Type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(Type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(Type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(Type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(Type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(Type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(Type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(Type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(Type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ETitle = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    inspector = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AssetNumber = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    DeviceUser = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    InspectionDate = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calibrations",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AssetNumber = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    DeviceOwner = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    DeviceUser = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    DeliveryDate = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    StartCalibration = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    EndCalibration = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calibrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cartables",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClothGroups",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Employer = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    EmployerMobile = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Manager = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ManagerMobile = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ManagerAgent = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ManagerAgentMobile = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    HseAgent = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    HseAgentMobile = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    PersonnelCount = table.Column<int>(Type: "int", nullable: true),
                    ContractNumber = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Duties",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Step = table.Column<double>(Type: "float", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Duties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmergencyPhoneBooks",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Place = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CityPhone = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CompanyPhone = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    OrganizationId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyPhoneBooks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HarmfulFactor",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarmfulFactor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InspectionPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionPlaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LegalRequirements",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegulationTitle = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    RegulationOrganization = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    RegulationDate = table.Column<string>(Type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalRequirements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maneuvers",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(Type: "int", nullable: true),
                    Type = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ActTime = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Equipment = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maneuvers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupations",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    OccupationCode = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    OccupationType = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permits",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Place = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    permit_Type = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    permit_attachment_Type = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    permit_date = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    permit_number = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    duration = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    responsible = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Year = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purposes",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Year = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RigAssets",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    asset_name = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    default_count = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    exist_count = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    count_Unit = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    position_name = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RigAssets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Standards",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    standard_name = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    fa_chapter = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    fa_subchapter = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    fa_Text = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkPlaces",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(Type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(Type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(Type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(Type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(Type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(Type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(Type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(Type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(Type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClothType = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ReceiveDate = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    ReceiveType = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Size = table.Column<int>(Type: "int", nullable: true),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clothes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DailyReports",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    RigBossId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    CampBossId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    DoctorId = table.Column<string>(Type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DailyReports_AspNetUsers_CampBossId",
                        column: x => x.CampBossId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DailyReports_AspNetUsers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DailyReports_AspNetUsers_RigBossId",
                        column: x => x.RigBossId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    SenderId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    ReceiverId = table.Column<string>(Type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OfficialAccidents",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accident_number = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentDate = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    AccidentHour = table.Column<TimeOnly>(Type: "time", nullable: true),
                    Marriage = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentPlace = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ActivityInAccident = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    DirectAccidentCauses = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    UnsafeActionCauses = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    UnsafeConditionCauses = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentDescription = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentBoss = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    DoctorDescription = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ExaminationDate = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    HseDescription = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    IsGuilty = table.Column<short>(Type: "smallint", nullable: true),
                    AccidentConsequence = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentComplication = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentInjuredPart = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    HseBoss = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    scan = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    LostDays = table.Column<int>(Type: "int", nullable: true),
                    ReceiveReportDate = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialAccidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficialAccidents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reminders",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    reminder_date = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reminders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserPermits",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    expire_date = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPermits_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClothGroupLists",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shoes = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    BoilerSuit = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    ClothGroupId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothGroupLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClothGroupLists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ClothGroupLists_ClothGroups_ClothGroupId",
                        column: x => x.ClothGroupId,
                        principalTable: "ClothGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContractorAccidents",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accident_number = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentDate = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    AccidentHour = table.Column<TimeOnly>(Type: "time", nullable: true),
                    Marriage = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentPlace = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ActivityInAccident = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    DirectAccidentCauses = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    UnsafeActionCauses = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    UnsafeConditionCauses = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentDescription = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentBoss = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    HseDescription = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    IsGuilty = table.Column<short>(Type: "smallint", nullable: true),
                    AccidentConsequence = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentComplication = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    AccidentInjuredPart = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    HseBoss = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    scan = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    LostDays = table.Column<int>(Type: "int", nullable: true),
                    ReceiveReportDate = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    ContractorId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorAccidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractorAccidents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ContractorAccidents_Contractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExaminationDate = table.Column<int>(Type: "int", nullable: true),
                    ExaminationResult = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    ContractorId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Examinations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Examinations_Contractors_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HarmfulItem",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    HarmfulFactorId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HarmfulItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HarmfulItem_HarmfulFactor_HarmfulFactorId",
                        column: x => x.HarmfulFactorId,
                        principalTable: "HarmfulFactor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InspectionTexts",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Step = table.Column<int>(Type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    InspectionPlaceId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionTexts_InspectionPlaces_InspectionPlaceId",
                        column: x => x.InspectionPlaceId,
                        principalTable: "InspectionPlaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProcessPlans",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    accept_percent = table.Column<decimal>(Type: "decimal(18,2)", nullable: true),
                    plan_percent = table.Column<decimal>(Type: "decimal(18,2)", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    deviation = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    requests = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    process_id = table.Column<int>(Type: "int", nullable: true)
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
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Estimate = table.Column<int>(Type: "int", nullable: true),
                    done = table.Column<int>(Type: "int", nullable: true),
                    Unit = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    plan_percent = table.Column<decimal>(Type: "decimal(18,2)", nullable: true),
                    realization_percent = table.Column<decimal>(Type: "decimal(18,2)", nullable: true),
                    plan_realization_percent = table.Column<decimal>(Type: "decimal(18,2)", nullable: true),
                    accept_percent = table.Column<decimal>(Type: "decimal(18,2)", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    purpose_id = table.Column<int>(Type: "int", nullable: true)
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
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Owner = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CarModel = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CarYear = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    OwnerStatus = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    RentalNumber = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CarTag = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    WorkPlaceId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambulances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ambulances_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ambulances_WorkPlaces_WorkPlaceId",
                        column: x => x.WorkPlaceId,
                        principalTable: "WorkPlaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmergencyTeams",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Duty = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    WorkPlaceId = table.Column<int>(Type: "int", nullable: true),
                    DutyId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergencyTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmergencyTeams_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmergencyTeams_Duties_DutyId",
                        column: x => x.DutyId,
                        principalTable: "Duties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmergencyTeams_WorkPlaces_WorkPlaceId",
                        column: x => x.WorkPlaceId,
                        principalTable: "WorkPlaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HealthCarts",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EndDate = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    WorkPlaceId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthCarts_WorkPlaces_WorkPlaceId",
                        column: x => x.WorkPlaceId,
                        principalTable: "WorkPlaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inspections",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InspectionDate = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    WorkPlaceId = table.Column<int>(Type: "int", nullable: true),
                    InspectionPlaceId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inspections_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inspections_InspectionPlaces_InspectionPlaceId",
                        column: x => x.InspectionPlaceId,
                        principalTable: "InspectionPlaces",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inspections_WorkPlaces_WorkPlaceId",
                        column: x => x.WorkPlaceId,
                        principalTable: "WorkPlaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birthday = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    employment_date = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    degree = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UserId = table.Column<string>(Type: "nvarchar(450)", nullable: true),
                    OrganizationId = table.Column<int>(Type: "int", nullable: true),
                    OccupationId = table.Column<int>(Type: "int", nullable: true),
                    WorkPlaceId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInfos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserInfos_Occupations_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserInfos_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserInfos_WorkPlaces_WorkPlaceId",
                        column: x => x.WorkPlaceId,
                        principalTable: "WorkPlaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OccupationHarmfuls",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExposureSource = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    EvaluationMethod = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ExposureRate = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ExposureDuration = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    ExposureLimit = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    OccupationId = table.Column<int>(Type: "int", nullable: true),
                    HarmfulFactorId = table.Column<int>(Type: "int", nullable: true),
                    HarmfulItemId = table.Column<int>(Type: "int", nullable: true),
                    HarmfulItemId = table.Column<int>(Type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccupationHarmfuls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OccupationHarmfuls_HarmfulFactor_HarmfulFactorId",
                        column: x => x.HarmfulFactorId,
                        principalTable: "HarmfulFactor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OccupationHarmfuls_HarmfulItem_HarmfulItemId",
                        column: x => x.HarmfulItemId,
                        principalTable: "HarmfulItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OccupationHarmfuls_Occupations_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InspectionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(Type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InspectionDate = table.Column<DateTime>(Type: "datetime2", nullable: true),
                    Text = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(Type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(Type: "datetime2", nullable: false),
                    InspectionId = table.Column<int>(Type: "int", nullable: true),
                    TextId = table.Column<int>(Type: "int", nullable: true),
                    WorkPlaceId = table.Column<int>(Type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InspectionDetails_InspectionTexts_TextId",
                        column: x => x.TextId,
                        principalTable: "InspectionTexts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InspectionDetails_Inspections_InspectionId",
                        column: x => x.InspectionId,
                        principalTable: "Inspections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InspectionDetails_WorkPlaces_WorkPlaceId",
                        column: x => x.WorkPlaceId,
                        principalTable: "WorkPlaces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ambulances_UserId",
                table: "Ambulances",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ambulances_WorkPlaceId",
                table: "Ambulances",
                column: "WorkPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_UserId",
                table: "Clothes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothGroupLists_ClothGroupId",
                table: "ClothGroupLists",
                column: "ClothGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothGroupLists_UserId",
                table: "ClothGroupLists",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorAccidents_ContractorId",
                table: "ContractorAccidents",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractorAccidents_UserId",
                table: "ContractorAccidents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyReports_CampBossId",
                table: "DailyReports",
                column: "CampBossId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyReports_DoctorId",
                table: "DailyReports",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyReports_RigBossId",
                table: "DailyReports",
                column: "RigBossId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyTeams_DutyId",
                table: "EmergencyTeams",
                column: "DutyId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyTeams_UserId",
                table: "EmergencyTeams",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmergencyTeams_WorkPlaceId",
                table: "EmergencyTeams",
                column: "WorkPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_ContractorId",
                table: "Examinations",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_UserId",
                table: "Examinations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HarmfulItem_HarmfulFactorId",
                table: "HarmfulItem",
                column: "HarmfulFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCarts_UserId",
                table: "HealthCarts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCarts_WorkPlaceId",
                table: "HealthCarts",
                column: "WorkPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionDetails_InspectionId",
                table: "InspectionDetails",
                column: "InspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionDetails_TextId",
                table: "InspectionDetails",
                column: "TextId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionDetails_WorkPlaceId",
                table: "InspectionDetails",
                column: "WorkPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_InspectionPlaceId",
                table: "Inspections",
                column: "InspectionPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_UserId",
                table: "Inspections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_WorkPlaceId",
                table: "Inspections",
                column: "WorkPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionTexts_InspectionPlaceId",
                table: "InspectionTexts",
                column: "InspectionPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationHarmfuls_HarmfulFactorId",
                table: "OccupationHarmfuls",
                column: "HarmfulFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationHarmfuls_HarmfulItemId",
                table: "OccupationHarmfuls",
                column: "HarmfulItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OccupationHarmfuls_OccupationId",
                table: "OccupationHarmfuls",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficialAccidents_UserId",
                table: "OfficialAccidents",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationPlans_purpose_id",
                table: "OperationPlans",
                column: "purpose_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessPlans_process_id",
                table: "ProcessPlans",
                column: "process_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reminders_UserId",
                table: "Reminders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_OccupationId",
                table: "UserInfos",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_OrganizationId",
                table: "UserInfos",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_UserId",
                table: "UserInfos",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_WorkPlaceId",
                table: "UserInfos",
                column: "WorkPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermits_UserId",
                table: "UserPermits",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ambulances");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "AspNetRoles");

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
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "InspectionPlaces");

            migrationBuilder.DropTable(
                name: "WorkPlaces");

            migrationBuilder.DropTable(
                name: "HarmfulFactor");
        }
    }
}
