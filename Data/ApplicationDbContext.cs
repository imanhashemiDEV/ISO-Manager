using ISO_Manager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ISO_Manager.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {

        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; } = default!;
        public DbSet<Organization> Organizations { get; set; } = default!;
        public DbSet<Occupation> Occupations { get; set; } = default!;
        public DbSet<WorkPlace> WorkPlaces { get; set; } = default!;
        public DbSet<Ambulance> Ambulances { get; set; } = default!;
        public DbSet<Asset> Assets { get; set; } = default!;
        public DbSet<Calibration> Calibrations { get; set; } = default!;
        public DbSet<Contractor> Contractors { get; set; } = default!;
        public DbSet<Cartable> Cartables { get; set; } = default!;
        public DbSet<Standard> Standards { get; set; } = default!;
        public DbSet<OfficialAccident> OfficialAccidents { get; set; } = default!;
        public DbSet<ContractorAccident> ContractorAccidents { get; set; } = default!;
        public DbSet<InspectionPlace> InspectionPlaces { get; set; } = default!;
        public DbSet<Inspection> Inspections { get; set; } = default!;
        public DbSet<InspectionText> InspectionTexts { get; set; } = default!;
        public DbSet<Purpose> Purposes { get; set; } = default!;
        public DbSet<Process> Processes { get; set; } = default!;
        public DbSet<ProcessPlan> ProcessPlans { get; set; } = default!;
        public DbSet<LegalRequirement> LegalRequirements { get; set; } = default!;
        public DbSet<Duty> Duties { get; set; } = default!;
        public DbSet<EmergencyTeam> EmergencyTeams { get; set; } = default!;
        public DbSet<Maneuver> Maneuvers { get; set; } = default!;
        public DbSet<OperationPlan> OperationPlans { get; set; } = default!;
        public DbSet<EmergencyPhoneBook> EmergencyPhoneBooks { get; set; } = default!;
        public DbSet<Message> Messages { get; set; } = default!;
        public DbSet<Reminder> Reminders { get; set; } = default!;
        public DbSet<Permit> Permits { get; set; } = default!;
        public DbSet<Cloth> Clothes { get; set; } = default!;
        public DbSet<HealthCart> HealthCarts { get; set; } = default!;
        public DbSet<Examination> Examinations { get; set; } = default!;
        public DbSet<OccupationHarmful> OccupationHarmfuls { get; set; } = default!;
        public DbSet<DailyReport> DailyReports { get; set; } = default!;
        public DbSet<ClothGroup> ClothGroups { get; set; } = default!;
        public DbSet<ClothGroupList> ClothGroupLists { get; set; } = default!;
        public DbSet<UserPermit> UserPermits { get; set; } = default!;
        public DbSet<InspectionDetail> InspectionDetails { get; set; } = default!;
        public DbSet<RigAsset> RigAssets { get; set; } = default!;
        public DbSet<Office> Offices { get; set; } = default!;

    }
}
