﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkTesting
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class whsetracEntities : DbContext
    {
        public whsetracEntities()
            : base("name=whsetracEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<accountingassetdepreciationhistory> accountingassetdepreciationhistories { get; set; }
        public virtual DbSet<accountingasset> accountingassets { get; set; }
        public virtual DbSet<accrec> accrecs { get; set; }
        public virtual DbSet<adjustinventory> adjustinventories { get; set; }
        public virtual DbSet<assetassignmenthistory> assetassignmenthistories { get; set; }
        public virtual DbSet<assetmain> assetmains { get; set; }
        public virtual DbSet<assettype> assettypes { get; set; }
        public virtual DbSet<assignedemployeetask> assignedemployeetasks { get; set; }
        public virtual DbSet<assignedtask> assignedtasks { get; set; }
        public virtual DbSet<assignedtasksupdate> assignedtasksupdates { get; set; }
        public virtual DbSet<auditcategory> auditcategories { get; set; }
        public virtual DbSet<auditreportemaillist> auditreportemaillists { get; set; }
        public virtual DbSet<bluejayoffice> bluejayoffices { get; set; }
        public virtual DbSet<bompart> bomparts { get; set; }
        public virtual DbSet<bulktoolhistory> bulktoolhistories { get; set; }
        public virtual DbSet<bulktool> bulktools { get; set; }
        public virtual DbSet<cellphonehistory> cellphonehistories { get; set; }
        public virtual DbSet<cellphonelist> cellphonelists { get; set; }
        public virtual DbSet<charterinventory> charterinventories { get; set; }
        public virtual DbSet<companyholiday> companyholidays { get; set; }
        public virtual DbSet<createpartid> createpartids { get; set; }
        public virtual DbSet<customeraddress> customeraddresses { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<dailytoolinspection> dailytoolinspections { get; set; }
        public virtual DbSet<dailyvehicleinspection> dailyvehicleinspections { get; set; }
        public virtual DbSet<dataentrywip> dataentrywips { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<departmentproductionemail> departmentproductionemails { get; set; }
        public virtual DbSet<departmentproductionemailproject> departmentproductionemailprojects { get; set; }
        public virtual DbSet<designpermitimport> designpermitimports { get; set; }
        public virtual DbSet<designpermit> designpermits { get; set; }
        public virtual DbSet<designproductivity> designproductivities { get; set; }
        public virtual DbSet<designprojectdocumentation> designprojectdocumentations { get; set; }
        public virtual DbSet<designproject> designprojects { get; set; }
        public virtual DbSet<designprojectsurveyor> designprojectsurveyors { get; set; }
        public virtual DbSet<designprojectupdate> designprojectupdates { get; set; }
        public virtual DbSet<dotstatu> dotstatus { get; set; }
        public virtual DbSet<dropburycompleted> dropburycompleteds { get; set; }
        public virtual DbSet<dropburytask> dropburytasks { get; set; }
        public virtual DbSet<employeecrewassignment> employeecrewassignments { get; set; }
        public virtual DbSet<employeedateentry> employeedateentries { get; set; }
        public virtual DbSet<employeegroup> employeegroups { get; set; }
        public virtual DbSet<employeeid> employeeids { get; set; }
        public virtual DbSet<employeelaborrate> employeelaborrates { get; set; }
        public virtual DbSet<employeeovernightwork> employeeovernightworks { get; set; }
        public virtual DbSet<employeeprojectassignment> employeeprojectassignments { get; set; }
        public virtual DbSet<employeepunchedhour> employeepunchedhours { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<employeesession> employeesessions { get; set; }
        public virtual DbSet<employeetimeclockentry> employeetimeclockentries { get; set; }
        public virtual DbSet<eventlog> eventlogs { get; set; }
        public virtual DbSet<fuelcardassignment> fuelcardassignments { get; set; }
        public virtual DbSet<geofenceimport> geofenceimports { get; set; }
        public virtual DbSet<gpsplugstatu> gpsplugstatus { get; set; }
        public virtual DbSet<inspectiongp> inspectiongps { get; set; }
        public virtual DbSet<inventory> inventories { get; set; }
        public virtual DbSet<issuedpart> issuedparts { get; set; }
        public virtual DbSet<itassetassignment> itassetassignments { get; set; }
        public virtual DbSet<itassetassignmenthistory> itassetassignmenthistories { get; set; }
        public virtual DbSet<itasset> itassets { get; set; }
        public virtual DbSet<jobtype> jobtypes { get; set; }
        public virtual DbSet<jsidocumentation> jsidocumentations { get; set; }
        public virtual DbSet<jsiemployee> jsiemployees { get; set; }
        public virtual DbSet<jsiladderinspection> jsiladderinspections { get; set; }
        public virtual DbSet<jsimain> jsimains { get; set; }
        public virtual DbSet<jsioverall> jsioveralls { get; set; }
        public virtual DbSet<JSIPPE> JSIPPEs { get; set; }
        public virtual DbSet<jsisiteinspection> jsisiteinspections { get; set; }
        public virtual DbSet<jsiuniform> jsiuniforms { get; set; }
        public virtual DbSet<jsivehicle> jsivehicles { get; set; }
        public virtual DbSet<letterparagraph> letterparagraphs { get; set; }
        public virtual DbSet<letterparagraphhistory> letterparagraphhistories { get; set; }
        public virtual DbSet<letter> letters { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<MachineType> MachineTypes { get; set; }
        public virtual DbSet<MachineWarranty> MachineWarranties { get; set; }
        public virtual DbSet<masterpartlist> masterpartlists { get; set; }
        public virtual DbSet<mducompleted> mducompleteds { get; set; }
        public virtual DbSet<mdutask> mdutasks { get; set; }
        public virtual DbSet<OperatingSy> OperatingSys { get; set; }
        public virtual DbSet<partnumber> partnumbers { get; set; }
        public virtual DbSet<PhoneCallLog> PhoneCallLogs { get; set; }
        public virtual DbSet<phonelist> phonelists { get; set; }
        public virtual DbSet<productionproject> productionprojects { get; set; }
        public virtual DbSet<productionprojectupdate> productionprojectupdates { get; set; }
        public virtual DbSet<productivitydataentry> productivitydataentries { get; set; }
        public virtual DbSet<productivitynotcorrect> productivitynotcorrects { get; set; }
        public virtual DbSet<productivitytotechpay> productivitytotechpays { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<projecttask> projecttasks { get; set; }
        public virtual DbSet<projecttechpayitem> projecttechpayitems { get; set; }
        public virtual DbSet<purchaserequest> purchaserequests { get; set; }
        public virtual DbSet<purchaserequestdocumentation> purchaserequestdocumentations { get; set; }
        public virtual DbSet<purchaserequestitem> purchaserequestitems { get; set; }
        public virtual DbSet<purchaserequestproject> purchaserequestprojects { get; set; }
        public virtual DbSet<purchaserequestupdate> purchaserequestupdates { get; set; }
        public virtual DbSet<receivepart> receiveparts { get; set; }
        public virtual DbSet<rentaltackingitem> rentaltackingitems { get; set; }
        public virtual DbSet<rentaltracking> rentaltrackings { get; set; }
        public virtual DbSet<rentaltrackingagreement> rentaltrackingagreements { get; set; }
        public virtual DbSet<rentaltrackingdocumentation> rentaltrackingdocumentations { get; set; }
        public virtual DbSet<rentaltrackingupdate> rentaltrackingupdates { get; set; }
        public virtual DbSet<SupportLog> SupportLogs { get; set; }
        public virtual DbSet<SupportTicket> SupportTickets { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<techpayitem> techpayitems { get; set; }
        public virtual DbSet<toolcategory> toolcategories { get; set; }
        public virtual DbSet<toolhistory> toolhistories { get; set; }
        public virtual DbSet<toolid> toolids { get; set; }
        public virtual DbSet<toolinspectionproblem> toolinspectionproblems { get; set; }
        public virtual DbSet<toolproblem> toolproblems { get; set; }
        public virtual DbSet<toolproblemdocument> toolproblemdocuments { get; set; }
        public virtual DbSet<toolproblemupdate> toolproblemupdates { get; set; }
        public virtual DbSet<tool> tools { get; set; }
        public virtual DbSet<towmotorasset> towmotorassets { get; set; }
        public virtual DbSet<towmotorengineoff> towmotorengineoffs { get; set; }
        public virtual DbSet<towmotorengineon> towmotorengineons { get; set; }
        public virtual DbSet<towmotorinsepctiondocumentation> towmotorinsepctiondocumentations { get; set; }
        public virtual DbSet<towmotorinspection> towmotorinspections { get; set; }
        public virtual DbSet<towmotorinspectionoverall> towmotorinspectionoveralls { get; set; }
        public virtual DbSet<towmotorinspectionproblem> towmotorinspectionproblems { get; set; }
        public virtual DbSet<towmotormain> towmotormains { get; set; }
        public virtual DbSet<towmotorproblemdocumentation> towmotorproblemdocumentations { get; set; }
        public virtual DbSet<towmotorproblem> towmotorproblems { get; set; }
        public virtual DbSet<towmotorproblemupdate> towmotorproblemupdates { get; set; }
        public virtual DbSet<trailerbodydamage> trailerbodydamages { get; set; }
        public virtual DbSet<trailercable> trailercables { get; set; }
        public virtual DbSet<trailercategory> trailercategories { get; set; }
        public virtual DbSet<trailercurrentload> trailercurrentloads { get; set; }
        public virtual DbSet<trailerhistory> trailerhistories { get; set; }
        public virtual DbSet<trailerproblem> trailerproblems { get; set; }
        public virtual DbSet<trailerproblemdocumentation> trailerproblemdocumentations { get; set; }
        public virtual DbSet<trailerproblemupdate> trailerproblemupdates { get; set; }
        public virtual DbSet<trailer> trailers { get; set; }
        public virtual DbSet<trailersinyard> trailersinyards { get; set; }
        public virtual DbSet<vehicleassignment> vehicleassignments { get; set; }
        public virtual DbSet<vehiclebodydamage> vehiclebodydamages { get; set; }
        public virtual DbSet<vehiclebulktool> vehiclebulktools { get; set; }
        public virtual DbSet<vehicleexceptionemail> vehicleexceptionemails { get; set; }
        public virtual DbSet<vehiclehistory> vehiclehistories { get; set; }
        public virtual DbSet<vehicleid> vehicleids { get; set; }
        public virtual DbSet<vehicleinfo> vehicleinfoes { get; set; }
        public virtual DbSet<vehicleinfohistory> vehicleinfohistories { get; set; }
        public virtual DbSet<vehicleinspectionemaillist> vehicleinspectionemaillists { get; set; }
        public virtual DbSet<vehicleinspectionproblem> vehicleinspectionproblems { get; set; }
        public virtual DbSet<vehicleinvoice> vehicleinvoices { get; set; }
        public virtual DbSet<vehiclemain> vehiclemains { get; set; }
        public virtual DbSet<vehicleproblem> vehicleproblems { get; set; }
        public virtual DbSet<vehicleproblemdocumentation> vehicleproblemdocumentations { get; set; }
        public virtual DbSet<vehicleproblemupdate> vehicleproblemupdates { get; set; }
        public virtual DbSet<vehicle> vehicles { get; set; }
        public virtual DbSet<vehiclesinshop> vehiclesinshops { get; set; }
        public virtual DbSet<vehiclesinyard> vehiclesinyards { get; set; }
        public virtual DbSet<vehiclestatu> vehiclestatus { get; set; }
        public virtual DbSet<vehicletool> vehicletools { get; set; }
        public virtual DbSet<vehicletype> vehicletypes { get; set; }
        public virtual DbSet<vendor> vendors { get; set; }
        public virtual DbSet<warehousetrailerinspection> warehousetrailerinspections { get; set; }
        public virtual DbSet<WarrantyProvider> WarrantyProviders { get; set; }
        public virtual DbSet<weeklybulktoolinspection> weeklybulktoolinspections { get; set; }
        public virtual DbSet<weeklytoolinspection> weeklytoolinspections { get; set; }
        public virtual DbSet<weeklyvehiclecleanliness> weeklyvehiclecleanlinesses { get; set; }
        public virtual DbSet<weeklyvehicleinspection> weeklyvehicleinspections { get; set; }
        public virtual DbSet<weeklyvehiclereportsdate> weeklyvehiclereportsdates { get; set; }
        public virtual DbSet<workorder> workorders { get; set; }
        public virtual DbSet<workorderscheduled> workorderscheduleds { get; set; }
        public virtual DbSet<workorderstatu> workorderstatus { get; set; }
        public virtual DbSet<workorderupdate> workorderupdates { get; set; }
        public virtual DbSet<worktask> worktasks { get; set; }
        public virtual DbSet<worktaskstat> worktaskstats { get; set; }
        public virtual DbSet<worktype> worktypes { get; set; }
        public virtual DbSet<workzone> workzones { get; set; }
        public virtual DbSet<workzonecity> workzonecities { get; set; }
        public virtual DbSet<wovbillingcode> wovbillingcodes { get; set; }
        public virtual DbSet<wovinvoicing> wovinvoicings { get; set; }
        public virtual DbSet<wovinvoicingitem> wovinvoicingitems { get; set; }
        public virtual DbSet<wovtask> wovtasks { get; set; }
        public virtual DbSet<dailytrailerinspection> dailytrailerinspections { get; set; }
    }
}
