using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NETCORE.Models.DB
{
    public partial class KPIContext : DbContext
    {
        public KPIContext()
        {
        }

        public KPIContext(DbContextOptions<KPIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BplusDatum> BplusData { get; set; }
        public virtual DbSet<Emp> Emps { get; set; }
        public virtual DbSet<Empgroup> Empgroups { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Jobh> Jobhs { get; set; }
        public virtual DbSet<JobhBackup> JobhBackups { get; set; }
        public virtual DbSet<Kpi> Kpis { get; set; }
        public virtual DbSet<KpiFoamspec> KpiFoamspecs { get; set; }
        public virtual DbSet<KpiSlitMo> KpiSlitMos { get; set; }
        public virtual DbSet<Kpidaily> Kpidailies { get; set; }
        public virtual DbSet<KpidailyDataentryLog> KpidailyDataentryLogs { get; set; }
        public virtual DbSet<KpidailyRework> KpidailyReworks { get; set; }
        public virtual DbSet<KpidailySlit> KpidailySlits { get; set; }
        public virtual DbSet<KpidailySlitDetail> KpidailySlitDetails { get; set; }
        public virtual DbSet<Kpih> Kpihs { get; set; }
        public virtual DbSet<KpihRework> KpihReworks { get; set; }
        public virtual DbSet<KpihSlit> KpihSlits { get; set; }
        public virtual DbSet<Laminate> Laminates { get; set; }
        public virtual DbSet<Leave2019> Leave2019s { get; set; }
        public virtual DbSet<Overtime> Overtimes { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<UfEmp> UfEmps { get; set; }
        public virtual DbSet<UfMcPerformc> UfMcPerformcs { get; set; }
        public virtual DbSet<VwKpiActhr> VwKpiActhrs { get; set; }
        public virtual DbSet<VwKpiActhrsByOp> VwKpiActhrsByOps { get; set; }
        public virtual DbSet<VwKpiComment> VwKpiComments { get; set; }
        public virtual DbSet<VwKpiD> VwKpiDs { get; set; }
        public virtual DbSet<VwKpiDetail> VwKpiDetails { get; set; }
        public virtual DbSet<VwKpiHr> VwKpiHrs { get; set; }
        public virtual DbSet<VwKpiOutput> VwKpiOutputs { get; set; }
        public virtual DbSet<VwKpiSum> VwKpiSums { get; set; }
        public virtual DbSet<VwPipeKpiSum> VwPipeKpiSums { get; set; }
        public virtual DbSet<WebAnnualLeaveRemain> WebAnnualLeaveRemains { get; set; }
        public virtual DbSet<WebAttApprovePm> WebAttApprovePms { get; set; }
        public virtual DbSet<WebAttCategory> WebAttCategories { get; set; }
        public virtual DbSet<WebAttLeave> WebAttLeaves { get; set; }
        public virtual DbSet<WebAttQuotaLeave> WebAttQuotaLeaves { get; set; }
        public virtual DbSet<WebAttTimesD> WebAttTimesDs { get; set; }
        public virtual DbSet<WebAttTimesH> WebAttTimesHes { get; set; }
        public virtual DbSet<WebAttUpdateLeaveToBplusLog> WebAttUpdateLeaveToBplusLogs { get; set; }
        public virtual DbSet<WebBorrowItequipment> WebBorrowItequipments { get; set; }
        public virtual DbSet<WebComputeraccess> WebComputeraccesses { get; set; }
        public virtual DbSet<WebComputeraccessBrand> WebComputeraccessBrands { get; set; }
        public virtual DbSet<WebComputeraccessCategory> WebComputeraccessCategories { get; set; }
        public virtual DbSet<WebComputeraccessDestroy> WebComputeraccessDestroys { get; set; }
        public virtual DbSet<WebComputeraccessHandelUse> WebComputeraccessHandelUses { get; set; }
        public virtual DbSet<WebEmployeeList> WebEmployeeLists { get; set; }
        public virtual DbSet<WebItpassword> WebItpasswords { get; set; }
        public virtual DbSet<WebNews> WebNews { get; set; }
        public virtual DbSet<WebPermisionLogin> WebPermisionLogins { get; set; }
        public virtual DbSet<WebPositionLevel> WebPositionLevels { get; set; }
        public virtual DbSet<WebSpinsoft> WebSpinsofts { get; set; }
        public virtual DbSet<WebSwitchHolidayD> WebSwitchHolidayDs { get; set; }
        public virtual DbSet<WebSwitchHolidayH> WebSwitchHolidayHs { get; set; }
        public virtual DbSet<WebSwitchHolidayList> WebSwitchHolidayLists { get; set; }
        public virtual DbSet<WebTelephoneList> WebTelephoneLists { get; set; }
        public virtual DbSet<WebTopicOt> WebTopicOts { get; set; }

        public virtual DbSet<LoginByUsernamePassword> GetLoginByUsernamePassword { get; set; }

        public virtual DbSet<ListMenu1> GetListMenu1 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.33.17;Uid=sa;PASSWORD=pass@word1;database=KPI;Max Pool Size=400;Connect Timeout=6000;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_100_CI_AS");

            modelBuilder.Entity<BplusDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Ab).HasColumnName("ab");

                entity.Property(e => e.Al).HasColumnName("al");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.Dates)
                    .HasColumnType("date")
                    .HasColumnName("dates");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot15).HasColumnName("ot15");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.Pl).HasColumnName("pl");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark");

                entity.Property(e => e.Sl).HasColumnName("sl");
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMP");

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.Depcode).HasColumnName("DEPCODE");

                entity.Property(e => e.EMail)
                    .HasMaxLength(255)
                    .HasColumnName("E-mail");

                entity.Property(e => e.Empcode).HasColumnName("EMPCODE");

                entity.Property(e => e.NameEng)
                    .HasMaxLength(255)
                    .HasColumnName("nameENG");

                entity.Property(e => e.No).HasColumnName("No#");

                entity.Property(e => e.Position).HasMaxLength(255);

                entity.Property(e => e.Section).HasMaxLength(255);
            });

            modelBuilder.Entity<Empgroup>(entity =>
            {
                entity.HasKey(e => e.Groupid);

                entity.ToTable("EMPGROUP");

                entity.Property(e => e.Groupid)
                    .HasMaxLength(10)
                    .HasColumnName("GROUPID");

                entity.Property(e => e.Groupname)
                    .HasMaxLength(150)
                    .HasColumnName("GROUPNAME");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Empid);

                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Empid)
                    .HasMaxLength(10)
                    .HasColumnName("EMPID");

                entity.Property(e => e.Companyid)
                    .HasMaxLength(10)
                    .HasColumnName("COMPANYID");

                entity.Property(e => e.Empdepart)
                    .HasMaxLength(100)
                    .HasColumnName("EMPDEPART");

                entity.Property(e => e.Empname)
                    .HasMaxLength(150)
                    .HasColumnName("EMPNAME");

                entity.Property(e => e.Groupid)
                    .HasMaxLength(4)
                    .HasColumnName("GROUPID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Position)
                    .HasMaxLength(60)
                    .HasColumnName("POSITION");

                entity.Property(e => e.Stat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STAT")
                    .IsFixedLength(true);

                entity.Property(e => e.Usertype)
                    .HasMaxLength(10)
                    .HasColumnName("USERTYPE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => new { e.Grade1, e.Type });

                entity.ToTable("GRADE");

                entity.Property(e => e.Grade1)
                    .HasMaxLength(12)
                    .HasColumnName("GRADE");

                entity.Property(e => e.Type)
                    .HasMaxLength(2)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Description)
                    .HasMaxLength(60)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<Jobh>(entity =>
            {
                entity.HasKey(e => new { e.Jobid, e.Dept });

                entity.ToTable("JOBH");

                entity.Property(e => e.Jobid)
                    .HasMaxLength(10)
                    .HasColumnName("JOBID")
                    .IsFixedLength(true);

                entity.Property(e => e.Dept)
                    .HasMaxLength(10)
                    .HasColumnName("DEPT")
                    .IsFixedLength(true);

                entity.Property(e => e.CalActual).HasColumnName("CAL_ACTUAL");

                entity.Property(e => e.CalPdtvt).HasColumnName("CAL_PDTVT");

                entity.Property(e => e.Codetype)
                    .HasMaxLength(10)
                    .HasColumnName("CODETYPE")
                    .IsFixedLength(true);

                entity.Property(e => e.Criteria)
                    .HasMaxLength(4)
                    .HasColumnName("CRITERIA");

                entity.Property(e => e.Die)
                    .HasMaxLength(16)
                    .HasColumnName("DIE");

                entity.Property(e => e.Jobdetail)
                    .HasMaxLength(150)
                    .HasColumnName("JOBDETAIL");

                entity.Property(e => e.Jobinfo)
                    .HasMaxLength(250)
                    .HasColumnName("JOBINFO");

                entity.Property(e => e.Kpi)
                    .HasMaxLength(12)
                    .HasColumnName("KPI");

                entity.Property(e => e.Level1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LEVEL1");

                entity.Property(e => e.Level2)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LEVEL2");

                entity.Property(e => e.Level3)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LEVEL3");

                entity.Property(e => e.Timetype)
                    .HasMaxLength(2)
                    .HasColumnName("TIMETYPE")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .HasColumnName("UNIT");
            });

            modelBuilder.Entity<JobhBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JOBH_BACKUP");

                entity.Property(e => e.Codetype)
                    .HasMaxLength(10)
                    .HasColumnName("CODETYPE")
                    .IsFixedLength(true);

                entity.Property(e => e.Criteria)
                    .HasMaxLength(4)
                    .HasColumnName("CRITERIA");

                entity.Property(e => e.Dept)
                    .HasMaxLength(10)
                    .HasColumnName("DEPT")
                    .IsFixedLength(true);

                entity.Property(e => e.Die)
                    .HasMaxLength(16)
                    .HasColumnName("DIE");

                entity.Property(e => e.Jobdetail)
                    .HasMaxLength(150)
                    .HasColumnName("JOBDETAIL");

                entity.Property(e => e.Jobid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("JOBID")
                    .IsFixedLength(true);

                entity.Property(e => e.Jobinfo)
                    .HasMaxLength(250)
                    .HasColumnName("JOBINFO");

                entity.Property(e => e.Kpi)
                    .HasMaxLength(12)
                    .HasColumnName("KPI");

                entity.Property(e => e.Level1)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LEVEL1");

                entity.Property(e => e.Level2)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LEVEL2");

                entity.Property(e => e.Level3)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LEVEL3");

                entity.Property(e => e.Timetype)
                    .HasMaxLength(2)
                    .HasColumnName("TIMETYPE")
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .HasColumnName("UNIT");
            });

            modelBuilder.Entity<Kpi>(entity =>
            {
                entity.ToTable("KPI");

                entity.Property(e => e.Kpiid)
                    .HasMaxLength(10)
                    .HasColumnName("KPIID")
                    .IsFixedLength(true);

                entity.Property(e => e.Kpidetail)
                    .HasMaxLength(250)
                    .HasColumnName("KPIDETAIL")
                    .IsFixedLength(true);

                entity.Property(e => e.Kpiname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("KPINAME");

                entity.Property(e => e.Kpiunit)
                    .HasMaxLength(15)
                    .HasColumnName("KPIUNIT");

                entity.Property(e => e.Kpiweight)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("KPIWEIGHT");
            });

            modelBuilder.Entity<KpiFoamspec>(entity =>
            {
                entity.HasKey(e => e.Monum);

                entity.ToTable("KPI_FOAMSPEC");

                entity.Property(e => e.Monum)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("MONUM")
                    .IsFixedLength(true);

                entity.Property(e => e.Hphfan)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HPHFAN");

                entity.Property(e => e.Hphtemp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("HPHTEMP");

                entity.Property(e => e.Inspeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("INSPEED");

                entity.Property(e => e.Outspeed)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OUTSPEED");

                entity.Property(e => e.Ratio)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RATIO");

                entity.Property(e => e.Setuplen)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SETUPLEN");

                entity.Property(e => e.Setupwid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SETUPWID");
            });

            modelBuilder.Entity<KpiSlitMo>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("KPI_SLIT_MO");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.EntryId).HasColumnName("ENTRY_ID");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ITEMDESC");

                entity.Property(e => e.Itemno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMNO");

                entity.Property(e => e.Linenum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINENUM");

                entity.Property(e => e.Monum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MONUM");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.KpiSlitMos)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KPI_SLIT_MO_KPIH_SLIT");
            });

            modelBuilder.Entity<Kpidaily>(entity =>
            {
                entity.HasKey(e => e.Entryid);

                entity.ToTable("KPIDAILY");

                entity.Property(e => e.Entryid).HasColumnName("ENTRYID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("COMMENT");

                entity.Property(e => e.Createdt)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDT");

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DETAIL");

                entity.Property(e => e.Empid)
                    .HasMaxLength(10)
                    .HasColumnName("EMPID");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Endtime).HasColumnName("ENDTIME");

                entity.Property(e => e.Jobid)
                    .HasMaxLength(10)
                    .HasColumnName("JOBID");

                entity.Property(e => e.Lenght)
                    .HasColumnType("numeric(10, 3)")
                    .HasColumnName("LENGHT");

                entity.Property(e => e.Lot)
                    .HasMaxLength(50)
                    .HasColumnName("LOT");

                entity.Property(e => e.Min)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("MIN");

                entity.Property(e => e.Monum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MONUM")
                    .IsFixedLength(true);

                entity.Property(e => e.Nglen)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("NGLEN");

                entity.Property(e => e.QtyLenght).HasColumnName("QTY_LENGHT");

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REASON");

                entity.Property(e => e.RecycStock)
                    .HasColumnType("numeric(10, 3)")
                    .HasColumnName("RECYC_STOCK");

                entity.Property(e => e.ReguidingEx)
                    .HasColumnType("numeric(10, 3)")
                    .HasColumnName("REGUIDING_EX");

                entity.Property(e => e.Scrap)
                    .HasColumnType("numeric(10, 3)")
                    .HasColumnName("SCRAP");

                entity.Property(e => e.Shiftid)
                    .HasMaxLength(10)
                    .HasColumnName("SHIFTID");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Starttime).HasColumnName("STARTTIME");

                entity.Property(e => e.Weight)
                    .HasColumnType("numeric(10, 3)")
                    .HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<KpidailyDataentryLog>(entity =>
            {
                entity.HasKey(e => e.Runno);

                entity.ToTable("KPIDAILY_DATAENTRY_LOG");

                entity.Property(e => e.Runno).HasColumnName("RUNNO");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("COMMENT");

                entity.Property(e => e.Createdt)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDT");

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DETAIL");

                entity.Property(e => e.Empid)
                    .HasMaxLength(10)
                    .HasColumnName("EMPID");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.Endtime).HasColumnName("ENDTIME");

                entity.Property(e => e.Entryid).HasColumnName("ENTRYID");

                entity.Property(e => e.Jobid)
                    .HasMaxLength(10)
                    .HasColumnName("JOBID");

                entity.Property(e => e.Lenght)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("LENGHT");

                entity.Property(e => e.Lot)
                    .HasMaxLength(50)
                    .HasColumnName("LOT");

                entity.Property(e => e.Min)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("MIN");

                entity.Property(e => e.Monum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MONUM")
                    .IsFixedLength(true);

                entity.Property(e => e.Nglen)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("NGLEN");

                entity.Property(e => e.QtyLenght).HasColumnName("QTY_LENGHT");

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REASON");

                entity.Property(e => e.RecycStock)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("RECYC_STOCK");

                entity.Property(e => e.ReguReguidingEx)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("REGu\r\nREGUIDING_EX");

                entity.Property(e => e.Scrap)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("SCRAP");

                entity.Property(e => e.Shiftid)
                    .HasMaxLength(10)
                    .HasColumnName("SHIFTID");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("STARTDATE");

                entity.Property(e => e.Starttime).HasColumnName("STARTTIME");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEBY");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATEDATE");

                entity.Property(e => e.Weight)
                    .HasColumnType("numeric(10, 2)")
                    .HasColumnName("WEIGHT");
            });

            modelBuilder.Entity<KpidailyRework>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("KPIDAILY_REWORK");

                entity.Property(e => e.RowId).HasColumnName("rowId");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.Detail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("detail");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("empId");

                entity.Property(e => e.Empg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("empg")
                    .IsFixedLength(true);

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("endDate");

                entity.Property(e => e.JobId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("jobId");

                entity.Property(e => e.Min)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("min");

                entity.Property(e => e.Output)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("output");

                entity.Property(e => e.ReworkNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("reworkNo");

                entity.Property(e => e.Scrap)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("scrap");

                entity.Property(e => e.Shift)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("shift")
                    .IsFixedLength(true);

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("startDate");
            });

            modelBuilder.Entity<KpidailySlit>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("KPIDAILY_SLIT");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENT");

                entity.Property(e => e.Detail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DETAIL");

                entity.Property(e => e.Empg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPG");

                entity.Property(e => e.Empid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("EMPID");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDDATE");

                entity.Property(e => e.EntryId).HasColumnName("ENTRY_ID");

                entity.Property(e => e.Jobid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOBID");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(7, 2)")
                    .HasColumnName("LENGTH");

                entity.Property(e => e.Min)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("MIN");

                entity.Property(e => e.Piece).HasColumnName("PIECE");

                entity.Property(e => e.Roll).HasColumnName("ROLL");

                entity.Property(e => e.Shiftid)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SHIFTID");

                entity.Property(e => e.Stampdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STAMPDATE");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTDATE");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.KpidailySlits)
                    .HasForeignKey(d => d.EntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KPIDAILY_SLIT_KPIH_SLIT");
            });

            modelBuilder.Entity<KpidailySlitDetail>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("KPIDAILY_SLIT_DETAIL");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.Barcode)
                    .IsUnicode(false)
                    .HasColumnName("BARCODE");

                entity.Property(e => e.Cutqty).HasColumnName("CUTQTY");

                entity.Property(e => e.Cutwidth)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CUTWIDTH");

                entity.Property(e => e.Detailid).HasColumnName("DETAILID");

                entity.Property(e => e.Linenum).HasColumnName("LINENUM");

                entity.Property(e => e.Monum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MONUM");

                entity.Property(e => e.Scrap)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SCRAP");

                entity.Property(e => e.SlitNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLIT_NO");
            });

            modelBuilder.Entity<Kpih>(entity =>
            {
                entity.HasKey(e => e.Monum);

                entity.ToTable("KPIH");

                entity.Property(e => e.Monum)
                    .HasMaxLength(20)
                    .HasColumnName("monum")
                    .IsFixedLength(true);

                entity.Property(e => e.ActHrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ACT_HRS");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .HasColumnName("create_by");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.FullReel)
                    .HasMaxLength(1)
                    .HasColumnName("full_reel")
                    .IsFixedLength(true);

                entity.Property(e => e.GuideSheet)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("guide_sheet");

                entity.Property(e => e.InputLen)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("input_len");

                entity.Property(e => e.InputWet)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("input_wet");

                entity.Property(e => e.KgHr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("kg_hr");

                entity.Property(e => e.Machine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MACHINE");

                entity.Property(e => e.NgLen)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("ng_len");

                entity.Property(e => e.NonHrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("NON_HRS");

                entity.Property(e => e.OutputLen)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("output_len");

                entity.Property(e => e.OutputWet)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("output_wet");

                entity.Property(e => e.ProduceDate)
                    .HasColumnType("date")
                    .HasColumnName("produce_date");

                entity.Property(e => e.ProduceType)
                    .HasMaxLength(10)
                    .HasColumnName("produce_type")
                    .IsFixedLength(true);

                entity.Property(e => e.Productivity)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("productivity");

                entity.Property(e => e.Qcng)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("QCNG");

                entity.Property(e => e.Qcyield)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("QCYIELD");

                entity.Property(e => e.QtyRoll)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty_roll");

                entity.Property(e => e.QtyRollNg)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty_rollNG");

                entity.Property(e => e.RecycStock)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("RECYC_STOCK");

                entity.Property(e => e.ReelNo)
                    .HasMaxLength(50)
                    .HasColumnName("reel_no")
                    .IsFixedLength(true);

                entity.Property(e => e.Reguiding)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("reguiding");

                entity.Property(e => e.Resin)
                    .HasColumnType("decimal(18, 4)")
                    .HasColumnName("resin");

                entity.Property(e => e.Rolls)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("ROLLS");

                entity.Property(e => e.Rpm)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("rpm");

                entity.Property(e => e.Scarp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("scarp");

                entity.Property(e => e.ScrapCalculate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("scrap_calculate");

                entity.Property(e => e.Screw)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("screw");

                entity.Property(e => e.TotReel)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tot_reel");

                entity.Property(e => e.TotWeight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("tot_weight");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .HasColumnName("update_by");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");

                entity.Property(e => e.Yield)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("yield");
            });

            modelBuilder.Entity<KpihRework>(entity =>
            {
                entity.HasKey(e => e.ReworkNo);

                entity.ToTable("KPIH_REWORK");

                entity.Property(e => e.ReworkNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("reworkNo");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.InputQty)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("inputQty");

                entity.Property(e => e.ItemDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("itemDesc");

                entity.Property(e => e.ItemNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("itemNo");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lotNo");

                entity.Property(e => e.OutputQty)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("outputQty");

                entity.Property(e => e.ReworkArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reworkArea");

                entity.Property(e => e.ReworkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("reworkDate");

                entity.Property(e => e.ReworkStatus).HasColumnName("reworkStatus");

                entity.Property(e => e.ReworkType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reworkType");

                entity.Property(e => e.Scrap)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("scrap");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateBy");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");
            });

            modelBuilder.Entity<KpihSlit>(entity =>
            {
                entity.HasKey(e => e.EntryId);

                entity.ToTable("KPIH_SLIT");

                entity.Property(e => e.EntryId).HasColumnName("ENTRY_ID");

                entity.Property(e => e.Areacd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AREACD");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CREATE_BY");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATE_DATE");

                entity.Property(e => e.Itemno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEMNO");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(7, 3)")
                    .HasColumnName("LENGTH");

                entity.Property(e => e.Machine)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MACHINE");

                entity.Property(e => e.Roll).HasColumnName("ROLL");

                entity.Property(e => e.SlitNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SLIT_NO");

                entity.Property(e => e.SlitPiece).HasColumnName("SLIT_PIECE");
            });

            modelBuilder.Entity<Laminate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LAMINATE");

                entity.Property(e => e.Criteria)
                    .HasMaxLength(255)
                    .HasColumnName("CRITERIA");

                entity.Property(e => e.Dept)
                    .HasMaxLength(255)
                    .HasColumnName("DEPT");

                entity.Property(e => e.Die)
                    .HasMaxLength(255)
                    .HasColumnName("DIE");

                entity.Property(e => e.Jobdetail)
                    .HasMaxLength(255)
                    .HasColumnName("JOBDETAIL");

                entity.Property(e => e.Jobid)
                    .HasMaxLength(255)
                    .HasColumnName("JOBID");

                entity.Property(e => e.Jobinfo)
                    .HasMaxLength(255)
                    .HasColumnName("JOBINFO");

                entity.Property(e => e.Kpi)
                    .HasMaxLength(255)
                    .HasColumnName("KPI");

                entity.Property(e => e.Level1).HasColumnName("LEVEL1");

                entity.Property(e => e.Level2).HasColumnName("LEVEL2");

                entity.Property(e => e.Level3).HasColumnName("LEVEL3");

                entity.Property(e => e.RunProduction).HasColumnName("Run Production");

                entity.Property(e => e.Timetype)
                    .HasMaxLength(255)
                    .HasColumnName("TIMETYPE");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("TYPE");

                entity.Property(e => e.Unit)
                    .HasMaxLength(255)
                    .HasColumnName("UNIT");
            });

            modelBuilder.Entity<Leave2019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("leave2019");

                entity.Property(e => e.AnnualLeave2020).HasColumnName("Annual leave _2020");

                entity.Property(e => e.BalanceFrom15Days).HasColumnName("Balance from _15 days");

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.DeptCode).HasColumnName("Dept code");

                entity.Property(e => e.EmpCode).HasColumnName("Emp# Code");

                entity.Property(e => e.EmployedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Employed Date");

                entity.Property(e => e.NameLastnameEng)
                    .HasMaxLength(255)
                    .HasColumnName("Name - Lastname - ENG");

                entity.Property(e => e.Outstanding2019).HasColumnName("Outstanding_2019");

                entity.Property(e => e.Position).HasMaxLength(255);

                entity.Property(e => e.Section).HasMaxLength(255);

                entity.Property(e => e.TakeLeaveAfterPayAnnualLeaveMore15Days).HasColumnName("Take leave after _pay annual leave more 15 days");

                entity.Property(e => e.TakenAnnualLeave2019).HasColumnName("Taken annual leave 2019");

                entity.Property(e => e.TakenAnnualLeave20191).HasColumnName("Taken annual leave 20191");

                entity.Property(e => e.TotalAnnualLeave2020).HasColumnName("Total_annual leave 2020");

                entity.Property(e => e.TotalAnnualLeave20201).HasColumnName("Total annual leave 2020");

                entity.Property(e => e.TotalValidAnnualLeave2019).HasColumnName("Total valid _annual leave 2019");

                entity.Property(e => e.TotalValidAnnualLeave2020).HasColumnName("Total valid _annual leave 2020");

                entity.Property(e => e.ใชสทธพกรอนไดเมออายงานครบ1ป)
                    .HasMaxLength(255)
                    .HasColumnName("ใช้สิทธิพักร้อนได้เมื่ออายุงานครบ 1 ปี");
            });

            modelBuilder.Entity<Overtime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("overtime");

                entity.Property(e => e.Ab).HasColumnName("ab");

                entity.Property(e => e.Al).HasColumnName("al");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .HasColumnName("code");

                entity.Property(e => e.Dates)
                    .HasMaxLength(255)
                    .HasColumnName("dates");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Ot1).HasColumnName("ot1");

                entity.Property(e => e.Ot15).HasColumnName("ot15");

                entity.Property(e => e.Ot3).HasColumnName("ot3");

                entity.Property(e => e.Pl).HasColumnName("pl");

                entity.Property(e => e.Remark)
                    .HasMaxLength(255)
                    .HasColumnName("remark");

                entity.Property(e => e.Sl).HasColumnName("sl");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.ToTable("SHIFT");

                entity.Property(e => e.Shiftid)
                    .HasMaxLength(10)
                    .HasColumnName("SHIFTID")
                    .IsFixedLength(true);

                entity.Property(e => e.Endtime)
                    .HasMaxLength(5)
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Shiftname)
                    .HasMaxLength(150)
                    .HasColumnName("SHIFTNAME");

                entity.Property(e => e.Starttime)
                    .HasMaxLength(5)
                    .HasColumnName("STARTTIME");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("TEST");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DETAIL");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<UfEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Uf_Emp");

                entity.Property(e => e.Empcode)
                    .HasMaxLength(10)
                    .HasColumnName("EMPCODE")
                    .IsFixedLength(true);

                entity.Property(e => e.Empgroup)
                    .HasMaxLength(10)
                    .HasColumnName("EMPGROUP")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<UfMcPerformc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Uf_Mc_Performc");

                entity.Property(e => e.Action)
                    .HasColumnType("text")
                    .HasColumnName("ACTION");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .HasColumnName("COMMENT");

                entity.Property(e => e.Entryid).HasColumnName("ENTRYID");

                entity.Property(e => e.Monum)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("MONUM")
                    .IsFixedLength(true);

                entity.Property(e => e.Problem)
                    .HasColumnType("text")
                    .HasColumnName("PROBLEM");

                entity.Property(e => e.Result)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RESULT")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VwKpiActhr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_KPI_ACTHRS");

                entity.Property(e => e.Acthrs)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("ACTHRS");

                entity.Property(e => e.Monum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("monum")
                    .IsFixedLength(true);

                entity.Property(e => e.Yield)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("yield");
            });

            modelBuilder.Entity<VwKpiActhrsByOp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_KPI_ACTHRS_BY_OP");

                entity.Property(e => e.Acthrs)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("ACTHRS");

                entity.Property(e => e.Monum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MONUM")
                    .UseCollation("Thai_BIN");

                entity.Property(e => e.Operno)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("OPERNO")
                    .UseCollation("Thai_BIN");
            });

            modelBuilder.Entity<VwKpiComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_KPI_COMMENT");

                entity.Property(e => e.Comment).HasColumnName("COMMENT");

                entity.Property(e => e.Monum)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("monum")
                    .IsFixedLength(true);

                entity.Property(e => e.Shiftid)
                    .HasMaxLength(10)
                    .HasColumnName("SHIFTID");
            });

            modelBuilder.Entity<VwKpiD>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_KPI_D");

                entity.Property(e => e.Endtime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ENDTIME");

                entity.Property(e => e.Endworking)
                    .HasColumnType("datetime")
                    .HasColumnName("ENDWORKING");

                entity.Property(e => e.Monum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MONUM")
                    .IsFixedLength(true);

                entity.Property(e => e.RecycStock)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("RECYC_STOCK");

                entity.Property(e => e.Scrap)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("SCRAP");

                entity.Property(e => e.Shiftid)
                    .HasMaxLength(10)
                    .HasColumnName("SHIFTID");

                entity.Property(e => e.Starttime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("STARTTIME");

                entity.Property(e => e.Startworking)
                    .HasColumnType("datetime")
                    .HasColumnName("STARTWORKING");
            });

            modelBuilder.Entity<VwKpiDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_KPI_DETAIL");

                entity.Property(e => e.Detail).HasColumnName("DETAIL");

                entity.Property(e => e.Monum)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("monum")
                    .IsFixedLength(true);

                entity.Property(e => e.Shiftid)
                    .HasMaxLength(10)
                    .HasColumnName("SHIFTID");
            });

            modelBuilder.Entity<VwKpiHr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_KPI_HRS");

                entity.Property(e => e.Hrs)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("HRS");

                entity.Property(e => e.Mchrs)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("MCHrs");

                entity.Property(e => e.Monum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("monum")
                    .IsFixedLength(true);

                entity.Property(e => e.RecycStock)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("RECYC_STOCK");

                entity.Property(e => e.Timetype)
                    .HasMaxLength(2)
                    .HasColumnName("TIMETYPE")
                    .IsFixedLength(true);

                entity.Property(e => e.Wdhrs).HasColumnType("numeric(38, 6)");
            });

            modelBuilder.Entity<VwKpiOutput>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_KPI_OUTPUT");

                entity.Property(e => e.Monum)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("MONUM")
                    .IsFixedLength(true);

                entity.Property(e => e.QtyOutput)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("QTY_OUTPUT");
            });

            modelBuilder.Entity<VwKpiSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_KPI_SUM");

                entity.Property(e => e.Acthrs)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("ACTHRS");

                entity.Property(e => e.Mchrs).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Monum)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("monum")
                    .IsFixedLength(true);

                entity.Property(e => e.RecycStock)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("RECYC_STOCK");

                entity.Property(e => e.Wdhrs).HasColumnType("numeric(38, 6)");
            });

            modelBuilder.Entity<VwPipeKpiSum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PIPE_KPI_SUM");

                entity.Property(e => e.BondingHrs)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("Bonding Hrs");

                entity.Property(e => e.Monum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MONUM")
                    .UseCollation("Thai_BIN");

                entity.Property(e => e.PackingHrs)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("Packing Hrs");

                entity.Property(e => e.PunchingHrs)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("Punching Hrs");

                entity.Property(e => e.SlitingHrs)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("Sliting Hrs");

                entity.Property(e => e.VerticalHrs)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("Vertical Hrs");
            });

            modelBuilder.Entity<WebAnnualLeaveRemain>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("WEB_annualLeaveRemain");

                entity.Property(e => e.RowId).HasColumnName("rowId");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.EmpCode).HasColumnName("empCode");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("enddate");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Refun)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("refun");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<WebAttApprovePm>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("WEB_AttApprovePMS");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Applevel).HasColumnName("applevel");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("create_by");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.EmpCode).HasColumnName("empCode");

                entity.Property(e => e.Section)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("update_by");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<WebAttCategory>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("WEB_AttCategory");

                entity.Property(e => e.RowId).HasColumnName("rowId");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NameTh)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("nameTh");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateBy");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.Value)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<WebAttLeave>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("WEB_AttLeave");

                entity.Property(e => e.RowId).HasColumnName("rowId");

                entity.Property(e => e.Atkfile)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("atkfile");

                entity.Property(e => e.CancelBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cancelBy");

                entity.Property(e => e.CancelComment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cancelComment");

                entity.Property(e => e.CancelDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cancelDate");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("dateFrom");

                entity.Property(e => e.DateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("dateTo");

                entity.Property(e => e.EmpCode).HasColumnName("empCode");

                entity.Property(e => e.Leave)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("leave");

                entity.Property(e => e.MngApproveBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mngApproveBy");

                entity.Property(e => e.MngApproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mngApproveDate");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SupApproveBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supApproveBy");

                entity.Property(e => e.SupApproveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("supApproveDate");

                entity.Property(e => e.Time)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("time");

                entity.Property(e => e.Typeleave)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("typeleave");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateBy");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.HasOne(d => d.EmpCodeNavigation)
                    .WithMany(p => p.WebAttLeaves)
                    .HasForeignKey(d => d.EmpCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WEB_AttLeave_WEB_EmployeeList");
            });

            modelBuilder.Entity<WebAttQuotaLeave>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("WEB_AttQuotaLeave");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("create_by");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Datefrom)
                    .HasColumnType("datetime")
                    .HasColumnName("datefrom");

                entity.Property(e => e.Dateto)
                    .HasColumnType("datetime")
                    .HasColumnName("dateto");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Section)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("update_by");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<WebAttTimesD>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("WEB_AttTimesD");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.ApproveMng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approveMng");

                entity.Property(e => e.ApproveMngDate)
                    .HasColumnType("datetime")
                    .HasColumnName("approveMngDate");

                entity.Property(e => e.ApproveSup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approveSup");

                entity.Property(e => e.ApproveSupDate)
                    .HasColumnType("datetime")
                    .HasColumnName("approveSupDate");

                entity.Property(e => e.Area)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.CancelDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cancelDate");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cancelby");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Dates)
                    .HasColumnType("datetime")
                    .HasColumnName("dates");

                entity.Property(e => e.Empcode).HasColumnName("empcode");

                entity.Property(e => e.IdHead).HasColumnName("idHead");

                entity.Property(e => e.Ot15af)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("ot15af");

                entity.Property(e => e.Ot15bf)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("ot15bf");

                entity.Property(e => e.Ot1af)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("ot1af");

                entity.Property(e => e.Ot1bf)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("ot1bf");

                entity.Property(e => e.Ot3af)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("ot3af");

                entity.Property(e => e.Ot3bf)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("ot3bf");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Shift)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shift");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Takeleave)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("takeleave");

                entity.Property(e => e.Team)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("team");

                entity.Property(e => e.Transport)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("transport");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateBy");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.Users)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("users");

                entity.HasOne(d => d.EmpcodeNavigation)
                    .WithMany(p => p.WebAttTimesDs)
                    .HasForeignKey(d => d.Empcode)
                    .HasConstraintName("FK_WEB_AttTimesD_WEB_AttTimesD");
            });

            modelBuilder.Entity<WebAttTimesH>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("WEB_AttTimesH");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Approve)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approve");

                entity.Property(e => e.Approveby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approveby");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empCode");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<WebAttUpdateLeaveToBplusLog>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("WEB_AttUpdateLeaveToBplusLog");

                entity.Property(e => e.RowId).HasColumnName("rowId");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Dates)
                    .HasColumnType("datetime")
                    .HasColumnName("dates");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empCode");

                entity.Property(e => e.LeaveNew)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("leaveNew");

                entity.Property(e => e.LeaveOld)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("leaveOld");

                entity.Property(e => e.SfKeynew)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SF_KEYNew");

                entity.Property(e => e.SfKeyold)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SF_KEYOld");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TimescanInNew)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timescanInNew");

                entity.Property(e => e.TimescanInOld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timescanInOld");

                entity.Property(e => e.TimescanOutNew)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timescanOutNew");

                entity.Property(e => e.TimescanOutOld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("timescanOutOld");
            });

            modelBuilder.Entity<WebBorrowItequipment>(entity =>
            {
                entity.ToTable("WEB_borrowITequipment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createby");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("dateFrom");

                entity.Property(e => e.DateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("dateTo");

                entity.Property(e => e.Detail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("detail");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.RequestBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requestBy");

                entity.Property(e => e.ResponBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("responBy");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.Statusjob)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("statusjob");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateBy");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");
            });

            modelBuilder.Entity<WebComputeraccess>(entity =>
            {
                entity.ToTable("WEB_computeraccess");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Fixasset)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fixasset");

                entity.Property(e => e.Model)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PrNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("prNumber");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serialNumber");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateby");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");

                entity.Property(e => e.Usage)
                    .HasColumnType("datetime")
                    .HasColumnName("usage");

                entity.Property(e => e.Waranty).HasColumnName("waranty");

                entity.Property(e => e.Warantystatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("warantystatus");
            });

            modelBuilder.Entity<WebComputeraccessBrand>(entity =>
            {
                entity.HasKey(e => e.IdBrand);

                entity.ToTable("WEB_computeraccessBrand");

                entity.Property(e => e.IdBrand).HasColumnName("id_brand");

                entity.Property(e => e.CreateByBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy_brand");

                entity.Property(e => e.CreateDateBrand)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate_brand");

                entity.Property(e => e.NameBrand)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_brand");

                entity.Property(e => e.StatusBrand).HasColumnName("status_brand");
            });

            modelBuilder.Entity<WebComputeraccessCategory>(entity =>
            {
                entity.HasKey(e => e.IdCategory);

                entity.ToTable("WEB_computeraccessCategory");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.CreateByCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy_category");

                entity.Property(e => e.CreateDateCategory)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate_category");

                entity.Property(e => e.NameCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_category");

                entity.Property(e => e.RemarkCategory)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remark_category");

                entity.Property(e => e.StatusCategory).HasColumnName("status_category");
            });

            modelBuilder.Entity<WebComputeraccessDestroy>(entity =>
            {
                entity.ToTable("WEB_computeraccessDestroy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComaccessId).HasColumnName("comaccess_id");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("create_by");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.DateDestroy)
                    .HasColumnType("datetime")
                    .HasColumnName("dateDestroy");

                entity.Property(e => e.Header).HasColumnName("header");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<WebComputeraccessHandelUse>(entity =>
            {
                entity.ToTable("WEB_computeraccessHandelUse");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Dates)
                    .HasColumnType("datetime")
                    .HasColumnName("dates");

                entity.Property(e => e.Header).HasColumnName("header");

                entity.Property(e => e.IdComaccess).HasColumnName("id_comaccess");

                entity.Property(e => e.IdEmp).HasColumnName("id_emp");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<WebEmployeeList>(entity =>
            {
                entity.HasKey(e => e.EmpCode);

                entity.ToTable("WEB_EmployeeList");

                entity.Property(e => e.EmpCode)
                    .ValueGeneratedNever()
                    .HasColumnName("empCode");

                entity.Property(e => e.DepCode).HasColumnName("depCode");

                entity.Property(e => e.Department)
                    .HasMaxLength(255)
                    .HasColumnName("department");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.LnameEn)
                    .HasMaxLength(255)
                    .HasColumnName("lnameEN");

                entity.Property(e => e.LnameTh)
                    .HasMaxLength(255)
                    .HasColumnName("lnameTH");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(255)
                    .HasColumnName("nameEN");

                entity.Property(e => e.NameTh)
                    .HasMaxLength(255)
                    .HasColumnName("nameTH");

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .HasColumnName("position");

                entity.Property(e => e.Section)
                    .HasMaxLength(255)
                    .HasColumnName("section");

                entity.Property(e => e.UsernameAd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usernameAD");

                entity.Property(e => e.WorkDate)
                    .HasColumnType("datetime")
                    .HasColumnName("workDate");
            });

            modelBuilder.Entity<WebItpassword>(entity =>
            {
                entity.ToTable("WEB_itpassword");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Detail)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("detail");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ip_address");

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateBy");

                entity.Property(e => e.UpdateDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateDate");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<WebNews>(entity =>
            {
                entity.ToTable("WEB_news");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Dates)
                    .HasColumnType("datetime")
                    .HasColumnName("dates");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Detail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("detail");

                entity.Property(e => e.Pic)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pic");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<WebPermisionLogin>(entity =>
            {
                entity.ToTable("WEB_permision_login");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.DepUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dep_user");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Permision)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("permision");

                entity.Property(e => e.Runno).HasColumnName("runno");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateby");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<WebPositionLevel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Web_PositionLevel");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(255)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasMaxLength(255)
                    .HasColumnName("createDate");

                entity.Property(e => e.Department)
                    .HasMaxLength(255)
                    .HasColumnName("department");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .HasColumnName("position");

                entity.Property(e => e.RowId).HasColumnName("rowId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(255)
                    .HasColumnName("updateBy");

                entity.Property(e => e.UpdateDate)
                    .HasMaxLength(255)
                    .HasColumnName("updateDate");
            });

            modelBuilder.Entity<WebSpinsoft>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("PK_WEB_itsupport");

                entity.ToTable("WEB_spinsoft");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Agreement)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("agreement");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Learned)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("learned");

                entity.Property(e => e.Levels)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("levels");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.Problem)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("problem");

                entity.Property(e => e.Process)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("process");

                entity.Property(e => e.Queue).HasColumnName("queue");

                entity.Property(e => e.RequestBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requestBy");

                entity.Property(e => e.RequestDate).HasColumnName("requestDate");

                entity.Property(e => e.RequestTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requestTo");

                entity.Property(e => e.Resources)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("resources");

                entity.Property(e => e.ResponBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("responBy");

                entity.Property(e => e.Section)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.Startdate).HasColumnName("startdate");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateby");

                entity.Property(e => e.Updatedate).HasColumnName("updatedate");
            });

            modelBuilder.Entity<WebSwitchHolidayD>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("WEB_switchHolidayD");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Dates)
                    .HasColumnType("datetime")
                    .HasColumnName("dates");

                entity.Property(e => e.Empcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empcode");

                entity.Property(e => e.Idhead).HasColumnName("idhead");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");
            });

            modelBuilder.Entity<WebSwitchHolidayH>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("WEB_switchHolidayH");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.ApproveMng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approveMng");

                entity.Property(e => e.ApproveMngDate)
                    .HasColumnType("datetime")
                    .HasColumnName("approveMngDate");

                entity.Property(e => e.ApproveSup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approveSup");

                entity.Property(e => e.ApproveSupDate)
                    .HasColumnType("datetime")
                    .HasColumnName("approveSupDate");

                entity.Property(e => e.CancelComment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("cancelComment");

                entity.Property(e => e.CancelDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cancelDate");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cancelby");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createby");

                entity.Property(e => e.Datefrom)
                    .HasColumnType("datetime")
                    .HasColumnName("datefrom");

                entity.Property(e => e.Dateto)
                    .HasColumnType("datetime")
                    .HasColumnName("dateto");

                entity.Property(e => e.Empcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empcode");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("qty");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateby");
            });

            modelBuilder.Entity<WebSwitchHolidayList>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("WEB_switchHolidayList");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.ApproveMngby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approveMngby");

                entity.Property(e => e.ApproveMngdate)
                    .HasColumnType("datetime")
                    .HasColumnName("approveMngdate");

                entity.Property(e => e.ApproveSupby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approveSupby");

                entity.Property(e => e.ApproveSupdate)
                    .HasColumnType("datetime")
                    .HasColumnName("approveSupdate");

                entity.Property(e => e.Approveby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approveby");

                entity.Property(e => e.Approvedate)
                    .HasColumnType("datetime")
                    .HasColumnName("approvedate");

                entity.Property(e => e.Cancelby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cancelby");

                entity.Property(e => e.Canceldate)
                    .HasColumnType("datetime")
                    .HasColumnName("canceldate");

                entity.Property(e => e.Commentcancel)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("commentcancel");

                entity.Property(e => e.Createby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createby");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("createdate");

                entity.Property(e => e.Datefrom)
                    .HasColumnType("datetime")
                    .HasColumnName("datefrom");

                entity.Property(e => e.Dates)
                    .HasColumnType("datetime")
                    .HasColumnName("dates");

                entity.Property(e => e.Dateto)
                    .HasColumnType("datetime")
                    .HasColumnName("dateto");

                entity.Property(e => e.Empcode).HasColumnName("empcode");

                entity.Property(e => e.Qty)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("qty");

                entity.Property(e => e.Remark)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Updateby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateby");

                entity.Property(e => e.Updatedate)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedate");
            });

            modelBuilder.Entity<WebTelephoneList>(entity =>
            {
                entity.HasKey(e => e.No)
                    .HasName("PK_UF_WEB_telephoneList");

                entity.ToTable("WEB_telephoneList");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("area");

                entity.Property(e => e.Concurrent)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("concurrent");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createBy");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Empid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPID");

                entity.Property(e => e.Gtranfer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gtranfer");

                entity.Property(e => e.Inter).HasColumnName("inter");

                entity.Property(e => e.IpPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ipPhone");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ipaddress");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Longdisc).HasColumnName("longdisc");

                entity.Property(e => e.Macaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("macaddress");

                entity.Property(e => e.Mobile).HasColumnName("mobile");

                entity.Property(e => e.Section)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("section");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tel");

                entity.Property(e => e.Telin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telin");

                entity.Property(e => e.UpdateBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updateBy");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDate");
            });

            modelBuilder.Entity<WebTopicOt>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("WEB_topicOT");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
