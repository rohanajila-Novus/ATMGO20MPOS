using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ATMGO20MPOS.Models
{
    public partial class RCBC_MPOS_UATContext : DbContext
    {
        public RCBC_MPOS_UATContext()
        {
        }

        public RCBC_MPOS_UATContext(DbContextOptions<RCBC_MPOS_UATContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddUserQueue> AddUserQueues { get; set; } = null!;
        public virtual DbSet<Apikey> Apikeys { get; set; } = null!;
        public virtual DbSet<BankMaster> BankMasters { get; set; } = null!;
        public virtual DbSet<BankMaster02012020> BankMaster02012020s { get; set; } = null!;
        public virtual DbSet<BankMaster08072020> BankMaster08072020s { get; set; } = null!;
        public virtual DbSet<BankMasterQueue> BankMasterQueues { get; set; } = null!;
        public virtual DbSet<BatchDetail> BatchDetails { get; set; } = null!;
        public virtual DbSet<BillerCategory> BillerCategories { get; set; } = null!;
        public virtual DbSet<BillerMaster> BillerMasters { get; set; } = null!;
        public virtual DbSet<BillerMaster17062020> BillerMaster17062020s { get; set; } = null!;
        public virtual DbSet<BillerMasterQueue> BillerMasterQueues { get; set; } = null!;
        public virtual DbSet<BillerType> BillerTypes { get; set; } = null!;
        public virtual DbSet<BinConfiguration> BinConfigurations { get; set; } = null!;
        public virtual DbSet<BinConfiguration02012020> BinConfiguration02012020s { get; set; } = null!;
        public virtual DbSet<BinConfigurationQueue> BinConfigurationQueues { get; set; } = null!;
        public virtual DbSet<BulkFileConfig> BulkFileConfigs { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<CityMaster> CityMasters { get; set; } = null!;
        public virtual DbSet<ConsolidatedReportMerchantList> ConsolidatedReportMerchantLists { get; set; } = null!;
        public virtual DbSet<DashboardBankDetail> DashboardBankDetails { get; set; } = null!;
        public virtual DbSet<DashboardCityTranDetail> DashboardCityTranDetails { get; set; } = null!;
        public virtual DbSet<DashboardGraphDatum> DashboardGraphData { get; set; } = null!;
        public virtual DbSet<DashboardMonthlyGraphDatum> DashboardMonthlyGraphData { get; set; } = null!;
        public virtual DbSet<DashboardYearlyGraphDatum> DashboardYearlyGraphData { get; set; } = null!;
        public virtual DbSet<DetHostParam> DetHostParams { get; set; } = null!;
        public virtual DbSet<DetHostProcessing> DetHostProcessings { get; set; } = null!;
        public virtual DbSet<DetTransChannelParam> DetTransChannelParams { get; set; } = null!;
        public virtual DbSet<DetTransProcessing> DetTransProcessings { get; set; } = null!;
        public virtual DbSet<DeviceAeskey> DeviceAeskeys { get; set; } = null!;
        public virtual DbSet<DeviceBuildVersion> DeviceBuildVersions { get; set; } = null!;
        public virtual DbSet<DeviceBuildVersionLog> DeviceBuildVersionLogs { get; set; } = null!;
        public virtual DbSet<DeviceBuildVersions18052020> DeviceBuildVersions18052020s { get; set; } = null!;
        public virtual DbSet<DownloadReport> DownloadReports { get; set; } = null!;
        public virtual DbSet<FeeForTxn> FeeForTxns { get; set; } = null!;
        public virtual DbSet<FeeForTxnPromoHistory> FeeForTxnPromoHistories { get; set; } = null!;
        public virtual DbSet<FeeForTxnQueue> FeeForTxnQueues { get; set; } = null!;
        public virtual DbSet<FeeType> FeeTypes { get; set; } = null!;
        public virtual DbSet<FileType> FileTypes { get; set; } = null!;
        public virtual DbSet<FileUploadStatus> FileUploadStatuses { get; set; } = null!;
        public virtual DbSet<FirmwareVersion> FirmwareVersions { get; set; } = null!;
        public virtual DbSet<FirmwareVersionLog> FirmwareVersionLogs { get; set; } = null!;
        public virtual DbSet<FormStatus> FormStatuses { get; set; } = null!;
        public virtual DbSet<HandoffReport> HandoffReports { get; set; } = null!;
        public virtual DbSet<Island> Islands { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<Login28072021> Login28072021s { get; set; } = null!;
        public virtual DbSet<MPosTran> MPosTrans { get; set; } = null!;
        public virtual DbSet<MPosTran26112020> MPosTran26112020s { get; set; } = null!;
        public virtual DbSet<MasChannelInterface> MasChannelInterfaces { get; set; } = null!;
        public virtual DbSet<MasHost> MasHosts { get; set; } = null!;
        public virtual DbSet<MasHost14112019> MasHost14112019s { get; set; } = null!;
        public virtual DbSet<MasLog> MasLogs { get; set; } = null!;
        public virtual DbSet<MasModule> MasModules { get; set; } = null!;
        public virtual DbSet<MasParam> MasParams { get; set; } = null!;
        public virtual DbSet<MasParam09052020> MasParam09052020s { get; set; } = null!;
        public virtual DbSet<MasParamQueue> MasParamQueues { get; set; } = null!;
        public virtual DbSet<MasParamTemp> MasParamTemps { get; set; } = null!;
        public virtual DbSet<MasRefreshDataTable> MasRefreshDataTables { get; set; } = null!;
        public virtual DbSet<MasRequestLog> MasRequestLogs { get; set; } = null!;
        public virtual DbSet<MasRequestLogPurged> MasRequestLogPurgeds { get; set; } = null!;
        public virtual DbSet<MasResponseCode> MasResponseCodes { get; set; } = null!;
        public virtual DbSet<MasResponseCode17102019> MasResponseCode17102019s { get; set; } = null!;
        public virtual DbSet<MasResponseCodes04102019> MasResponseCodes04102019s { get; set; } = null!;
        public virtual DbSet<MasSwitchParam> MasSwitchParams { get; set; } = null!;
        public virtual DbSet<MasSwitchParam02012020> MasSwitchParam02012020s { get; set; } = null!;
        public virtual DbSet<MasTransactionType> MasTransactionTypes { get; set; } = null!;
        public virtual DbSet<Mashost04112019> Mashost04112019s { get; set; } = null!;
        public virtual DbSet<Masresponsecodes14102019> Masresponsecodes14102019s { get; set; } = null!;
        public virtual DbSet<MassModule> MassModules { get; set; } = null!;
        public virtual DbSet<MassModuleReport> MassModuleReports { get; set; } = null!;
        public virtual DbSet<MerchantMappingTemp> MerchantMappingTemps { get; set; } = null!;
        public virtual DbSet<MposTemp> MposTemps { get; set; } = null!;
        public virtual DbSet<OperationReportTest> OperationReportTests { get; set; } = null!;
        public virtual DbSet<OtherDetail> OtherDetails { get; set; } = null!;
        public virtual DbSet<Otpdatum> Otpdata { get; set; } = null!;
        public virtual DbSet<PageAccessRight> PageAccessRights { get; set; } = null!;
        public virtual DbSet<PageAccessRightsQueue> PageAccessRightsQueues { get; set; } = null!;
        public virtual DbSet<PageLink> PageLinks { get; set; } = null!;
        public virtual DbSet<PartnerDetail> PartnerDetails { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<ReconciliationReport> ReconciliationReports { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<ReportAccessRight> ReportAccessRights { get; set; } = null!;
        public virtual DbSet<ReportAccessRightsHistory> ReportAccessRightsHistories { get; set; } = null!;
        public virtual DbSet<ReportDetail> ReportDetails { get; set; } = null!;
        public virtual DbSet<ReportType> ReportTypes { get; set; } = null!;
        public virtual DbSet<RequestType> RequestTypes { get; set; } = null!;
        public virtual DbSet<ResetPasswordQueue> ResetPasswordQueues { get; set; } = null!;
        public virtual DbSet<ResponseCodeConfig> ResponseCodeConfigs { get; set; } = null!;
        public virtual DbSet<RoleCategory> RoleCategories { get; set; } = null!;
        public virtual DbSet<RoleMaster> RoleMasters { get; set; } = null!;
        public virtual DbSet<RoleMaster10022020> RoleMaster10022020s { get; set; } = null!;
        public virtual DbSet<RoleMasterQueue> RoleMasterQueues { get; set; } = null!;
        public virtual DbSet<ServerAeskey> ServerAeskeys { get; set; } = null!;
        public virtual DbSet<SetPasswordLink> SetPasswordLinks { get; set; } = null!;
        public virtual DbSet<SetPinlink> SetPinlinks { get; set; } = null!;
        public virtual DbSet<Sheet1> Sheet1s { get; set; } = null!;
        public virtual DbSet<SignOnLog> SignOnLogs { get; set; } = null!;
        public virtual DbSet<SubTranMenu> SubTranMenus { get; set; } = null!;
        public virtual DbSet<TblMerchant> TblMerchants { get; set; } = null!;
        public virtual DbSet<TblMerchantDetail> TblMerchantDetails { get; set; } = null!;
        public virtual DbSet<TblMerchantEnrollUpdateHistory> TblMerchantEnrollUpdateHistories { get; set; } = null!;
        public virtual DbSet<TblMerchantReportEmailId> TblMerchantReportEmailIds { get; set; } = null!;
        public virtual DbSet<TblMerchantReportEmailIdArchival> TblMerchantReportEmailIdArchivals { get; set; } = null!;
        public virtual DbSet<TblOtherBankBinConfiguration> TblOtherBankBinConfigurations { get; set; } = null!;
        public virtual DbSet<TblOtherBankBinConfiguration09072020> TblOtherBankBinConfiguration09072020s { get; set; } = null!;
        public virtual DbSet<TblOtherBankBinConfiguration30032020> TblOtherBankBinConfiguration30032020s { get; set; } = null!;
        public virtual DbSet<TblReferrerDetail> TblReferrerDetails { get; set; } = null!;
        public virtual DbSet<TblSwitchRequest> TblSwitchRequests { get; set; } = null!;
        public virtual DbSet<TblTerminal> TblTerminals { get; set; } = null!;
        public virtual DbSet<TelcoMaster> TelcoMasters { get; set; } = null!;
        public virtual DbSet<TelcoMasterQueue> TelcoMasterQueues { get; set; } = null!;
        public virtual DbSet<Template> Templates { get; set; } = null!;
        public virtual DbSet<TerminalCounter> TerminalCounters { get; set; } = null!;
        public virtual DbSet<TestTbl> TestTbls { get; set; } = null!;
        public virtual DbSet<TmpReprintCustom> TmpReprintCustoms { get; set; } = null!;
        public virtual DbSet<TranType> TranTypes { get; set; } = null!;
        public virtual DbSet<TranTypeAccess> TranTypeAccesses { get; set; } = null!;
        public virtual DbSet<TranTypeRight> TranTypeRights { get; set; } = null!;
        public virtual DbSet<TranTypeRightsQueue> TranTypeRightsQueues { get; set; } = null!;
        public virtual DbSet<TransactionTypeSummaryDatum> TransactionTypeSummaryData { get; set; } = null!;
        public virtual DbSet<UploadBillerListHistory> UploadBillerListHistories { get; set; } = null!;
        public virtual DbSet<UploadFsmaster> UploadFsmasters { get; set; } = null!;
        public virtual DbSet<UploadMerchantListHistory> UploadMerchantListHistories { get; set; } = null!;
        public virtual DbSet<UrbanRuralStatistic> UrbanRuralStatistics { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;
        public virtual DbSet<UserStatusQueue> UserStatusQueues { get; set; } = null!;
        public virtual DbSet<VwDownloadReport> VwDownloadReports { get; set; } = null!;
        public virtual DbSet<VwHandOffreport> VwHandOffreports { get; set; } = null!;
        public virtual DbSet<VwReconciliationReport> VwReconciliationReports { get; set; } = null!;
        public virtual DbSet<VwReversalTransaction> VwReversalTransactions { get; set; } = null!;
        public virtual DbSet<VwTxnDatum> VwTxnData { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=ConnectionStrings:myDb1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddUserQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AddUser_Queue");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Apikey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("APIKeys");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActivationTime).HasColumnType("datetime");

                entity.Property(e => e.Apikey1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APIKEY");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DecryRequired).HasColumnName("Decry_required");

                entity.Property(e => e.Domain).HasColumnName("domain");

                entity.Property(e => e.EncRequired).HasColumnName("Enc_required");

                entity.Property(e => e.EncType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Enc_type");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IpOrDomain)
                    .IsUnicode(false)
                    .HasColumnName("ipOrDomain");

                entity.Property(e => e.KeyLength).HasColumnName("key_Length");

                entity.Property(e => e.Nextapikey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NEXTAPIKEY");

                entity.Property(e => e.Privatekey1)
                    .IsUnicode(false)
                    .HasColumnName("privatekey1");

                entity.Property(e => e.Privatekey2)
                    .IsUnicode(false)
                    .HasColumnName("privatekey2");

                entity.Property(e => e.PrivatekeyLast1)
                    .IsUnicode(false)
                    .HasColumnName("privatekeyLast1");

                entity.Property(e => e.PrivatekeyLast2)
                    .IsUnicode(false)
                    .HasColumnName("privatekeyLast2");

                entity.Property(e => e.Publickey1)
                    .IsUnicode(false)
                    .HasColumnName("publickey1");

                entity.Property(e => e.Publickey2)
                    .IsUnicode(false)
                    .HasColumnName("publickey2");

                entity.Property(e => e.PublickeyLast1)
                    .IsUnicode(false)
                    .HasColumnName("publickeyLast1");

                entity.Property(e => e.PublickeyLast2)
                    .IsUnicode(false)
                    .HasColumnName("publickeyLast2");

                entity.Property(e => e.ScheduleTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UpdatedDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_datetime");

                entity.Property(e => e.VendorDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("vendorDescription");

                entity.Property(e => e.Vendorid)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("vendorid");
            });

            modelBuilder.Entity<BankMaster>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("PK__BankMast__AA08CB3304AB2FF7");

                entity.ToTable("BankMaster");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BanMnmonic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<BankMaster02012020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BankMaster_02012020");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BankID");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<BankMaster08072020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BankMaster_08072020");

                entity.Property(e => e.BanMnmonic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BankID");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<BankMasterQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BankMaster_Queue");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            });

            modelBuilder.Entity<BatchDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.BatchBeginDate).HasColumnType("datetime");

                entity.Property(e => e.CashAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.CashDiscountAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RefundAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.SaleAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.SaleDiscountAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.SettledDate).HasColumnType("datetime");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.VoidAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.VoidDiscountAmount).HasColumnType("numeric(32, 8)");
            });

            modelBuilder.Entity<BillerCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillerCategory");

                entity.Property(e => e.BillerCategory1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BillerCategory");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<BillerMaster>(entity =>
            {
                entity.HasKey(e => e.BillerId)
                    .HasName("PK__BillerMa__5239A7B3327306B9");

                entity.ToTable("BillerMaster");

                entity.Property(e => e.BillerId).HasColumnName("BillerID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Account_number");

                entity.Property(e => e.AccountPrefix).IsUnicode(false);

                entity.Property(e => e.BillerAddress)
                    .IsUnicode(false)
                    .HasColumnName("Biller_Address");

                entity.Property(e => e.BillerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillerType)
                    .HasColumnName("Biller_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepositoryBank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Institution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Mobile_Number");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NameAppearOnAtmscreen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NameAppearOnATMScreen");

                entity.Property(e => e.NamePrintedOnReceipt)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillerMaster17062020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillerMaster_17062020");

                entity.Property(e => e.AccountPrefix).IsUnicode(false);

                entity.Property(e => e.BillerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BillerID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DepositoryBank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Institution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NameAppearOnAtmscreen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NameAppearOnATMScreen");

                entity.Property(e => e.NamePrintedOnReceipt)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillerMasterQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillerMaster_Queue");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Account_number");

                entity.Property(e => e.AccountPrefix).IsUnicode(false);

                entity.Property(e => e.BillerAddress)
                    .IsUnicode(false)
                    .HasColumnName("Biller_Address");

                entity.Property(e => e.BillerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillerId).HasColumnName("BillerID");

                entity.Property(e => e.BillerType)
                    .HasColumnName("Biller_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepositoryBank)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Institution)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Mobile_Number");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NameAppearOnAtmscreen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NameAppearOnATMScreen");

                entity.Property(e => e.NamePrintedOnReceipt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            });

            modelBuilder.Entity<BillerType>(entity =>
            {
                entity.ToTable("BillerType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BinConfiguration>(entity =>
            {
                entity.HasKey(e => e.BinId)
                    .HasName("PK__BinConfi__4BFF5A4E10541018");

                entity.ToTable("BinConfiguration");

                entity.Property(e => e.BinId).HasColumnName("BinID");

                entity.Property(e => e.BankName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BinConfiguration02012020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BinConfiguration_02012020");

                entity.Property(e => e.BankName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BinId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BinID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BinConfigurationQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BinConfiguration_Queue");

                entity.Property(e => e.BankName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BinId).HasColumnName("BinID");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BulkFileConfig>(entity =>
            {
                entity.ToTable("BulkFileConfig");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.FixedValue)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.IsMandatory)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.MaxLen)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MinLen)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.City1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Classification)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("classification");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__city__province_i__6641052B");
            });

            modelBuilder.Entity<CityMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CityMaster");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<ConsolidatedReportMerchantList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ConsolidatedReport_MerchantList");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DashboardBankDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DashboardBankDetail");

                entity.Property(e => e.BankName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MarketShare).HasColumnType("numeric(17, 4)");

                entity.Property(e => e.TotalTxnAmount).HasColumnType("numeric(17, 4)");
            });

            modelBuilder.Entity<DashboardCityTranDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DashboardCityTranDetail");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DashboardGraphDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Status)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Weekday)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DashboardMonthlyGraphDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Month)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DashboardYearlyGraphDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Status)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetHostParam>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppVariable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.Ioflag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IOflag")
                    .IsFixedLength();

                entity.Property(e => e.ParamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetHostProcessing>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DetHostProcessing");

                entity.HasIndex(e => new { e.TransType, e.HostId, e.TransSequence, e.Sequence }, "uq_dethostprocessing")
                    .IsUnique();

                entity.Property(e => e.ContinueOnFail).HasDefaultValueSql("((0))");

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.HostTransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetTransChannelParam>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppVariable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ioflag)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IOflag")
                    .IsFixedLength();

                entity.Property(e => e.ParamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetTransProcessing>(entity =>
            {
                entity.ToTable("DetTransProcessing");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceAeskey>(entity =>
            {
                entity.ToTable("DeviceAESKeys");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Aeskey).HasColumnName("AESKey");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Deviceid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deviceid");

                entity.Property(e => e.Lastupdateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastupdateddate");

                entity.Property(e => e.Random3).HasColumnName("random3");

                entity.Property(e => e.Random4).HasColumnName("random4");

                entity.Property(e => e.Random6).HasColumnName("random6");

                entity.Property(e => e.RandomNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("random_num");

                entity.Property(e => e.RequestDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("request_datetime");
            });

            modelBuilder.Entity<DeviceBuildVersion>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.BuildVersion, "UQ__DeviceBu__8EDD01A6B192A39C")
                    .IsUnique();

                entity.Property(e => e.BuildVersion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<DeviceBuildVersionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DeviceBuildVersionLog");

                entity.Property(e => e.CurrentVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PreviousVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DeviceBuildVersions18052020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DeviceBuildVersions_18052020");

                entity.Property(e => e.BuildVersion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<DownloadReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DownloadReport");

                entity.Property(e => e.BillerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BinNo)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Card Type");

                entity.Property(e => e.CreditAccountNo)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTranAmount).HasColumnType("numeric(17, 2)");

                entity.Property(e => e.DebitAccountNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Debit Account No.");

                entity.Property(e => e.DebitCardNo)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DebitTranAmount).HasColumnType("numeric(17, 2)");

                entity.Property(e => e.IssuingBankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Issuing Bank Name");

                entity.Property(e => e.LocationBranch)
                    .HasMaxLength(2000)
                    .HasColumnName("Location/Branch");

                entity.Property(e => e.MdrAmount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MDR (Amount)");

                entity.Property(e => e.MdrRate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MDR (Rate)");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Merchant ID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Merchant Name");

                entity.Property(e => e.MerchantShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Merchant Share");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Message Code");

                entity.Property(e => e.PosAssignedTxnNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("POS Assigned Txn No.");

                entity.Property(e => e.RcbcShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RCBC Share");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Reference Number");

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Referred By");

                entity.Property(e => e.ReferrerAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Referrer Account No");

                entity.Property(e => e.ReferrerFeeShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ReferrerFee Share");

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementAccNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Settlement Acc No.");

                entity.Property(e => e.SubscriberSAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Subscriber's Account No.");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Terminal ID");

                entity.Property(e => e.TotalAmountPhp)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("Total Amount (PHP)");

                entity.Property(e => e.TraceNumber)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Trace Number");

                entity.Property(e => e.TransactionAmountPhp)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("Transaction Amount (PHP)");

                entity.Property(e => e.TransactionDate)
                    .HasMaxLength(4000)
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionFee)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("Transaction Fee");

                entity.Property(e => e.TransactionStatus)
                    .HasMaxLength(2000)
                    .HasColumnName("Transaction Status");

                entity.Property(e => e.TransactionTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Time")
                    .IsFixedLength();

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Type");
            });

            modelBuilder.Entity<FeeForTxn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FeeForTxn");

                entity.Property(e => e.AcquirerFee).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BankFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CardType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConvenienceFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MercFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MerchantFee).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReferrerFee).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<FeeForTxnPromoHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FeeForTxn_PromoHistory");

                entity.Property(e => e.AcquirerFee).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BankFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CardType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConvenienceFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MercFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MerchantFee).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReferrerFee).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<FeeForTxnQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FeeForTxn_Queue");

                entity.Property(e => e.AcquirerFee).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.BankFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CardType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.ConvenienceFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FeeId).HasColumnName("FeeID");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.MercFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MerchantFee).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReferrerFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            });

            modelBuilder.Entity<FeeType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FeeType");

                entity.Property(e => e.FeeType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FeeType");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<FileType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileType");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileType1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FileType");

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InsertValidationSp)
                    .HasMaxLength(800)
                    .IsUnicode(false)
                    .HasColumnName("InsertValidationSP");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Seperator)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<FileUploadStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FileUploadStatus");

                entity.Property(e => e.Code).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusType).IsUnicode(false);
            });

            modelBuilder.Entity<FirmwareVersion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirmwareVersion1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FirmwareVersion");
            });

            modelBuilder.Entity<FirmwareVersionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FirmwareVersionLog");

                entity.Property(e => e.CurrentVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.PreviousVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FormStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FormStatus");

                entity.Property(e => e.FormStatus1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FormStatus");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<HandoffReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HandoffReport");

                entity.Property(e => e.BillerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BILLER_NAME");

                entity.Property(e => e.BinNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CARD_TYPE");

                entity.Property(e => e.CreditAccountNo)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_ACCOUNT_NO");

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_CARD_NO");

                entity.Property(e => e.CreditTrxnAmount)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("CREDIT_TRXN_AMOUNT");

                entity.Property(e => e.DebitAccountNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEBIT_ACCOUNT_NO");

                entity.Property(e => e.DebitCardNo)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("DEBIT_CARD_NO");

                entity.Property(e => e.DebitTrxnAmount)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("DEBIT_TRXN_AMOUNT");

                entity.Property(e => e.Filler)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FILLER");

                entity.Property(e => e.IssuingBankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Issuing Bank Name");

                entity.Property(e => e.LocationBranch)
                    .HasMaxLength(2000)
                    .HasColumnName("Location/Branch");

                entity.Property(e => e.MerchSttlmntAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MERCH_STTLMNT_ACCT_NO");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MERCHANT_ID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MERCHANT_NAME");

                entity.Property(e => e.MerchantShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MERCHANT_SHARE");

                entity.Property(e => e.MrdAmount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MRD_AMOUNT");

                entity.Property(e => e.MrdRate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MRD_RATE");

                entity.Property(e => e.MsgCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MSG_CODE");

                entity.Property(e => e.PosAssignTrxnNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("POS_ASSIGN_TRXN_NO");

                entity.Property(e => e.RcbcShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RCBC_SHARE");

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFERRED_BY");

                entity.Property(e => e.ReferrerAccntNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REFERRER_ACCNT_NO");

                entity.Property(e => e.ReferrerShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("REFERRER_SHARE");

                entity.Property(e => e.SubsAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SUBS_ACCOUNT_NO");

                entity.Property(e => e.TermId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TERM_ID");

                entity.Property(e => e.TrcNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TRC_NO");

                entity.Property(e => e.TrxnAmount)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("TRXN_AMOUNT");

                entity.Property(e => e.TrxnCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRXN_CODE");

                entity.Property(e => e.TrxnDate)
                    .HasMaxLength(4000)
                    .HasColumnName("TRXN_DATE");

                entity.Property(e => e.TrxnFee)
                    .HasColumnType("numeric(23, 8)")
                    .HasColumnName("TRXN_FEE");

                entity.Property(e => e.TrxnStat)
                    .HasMaxLength(2000)
                    .HasColumnName("TRXN_STAT");

                entity.Property(e => e.TrxnTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRXN_TIME")
                    .IsFixedLength();

                entity.Property(e => e.TrxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRXN_TYPE");
            });

            modelBuilder.Entity<Island>(entity =>
            {
                entity.ToTable("island");

                entity.Property(e => e.IslandId).HasColumnName("island_id");

                entity.Property(e => e.Island1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("island");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Login__1788CCAC21EB422E");

                entity.ToTable("Login");

                entity.HasIndex(e => e.UserName, "IX_Login_uname");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastLogoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("LastPasswordChangedDT")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MakeModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mpin).HasColumnName("MPIN");

                entity.Property(e => e.MpinlockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("MPINLockedOn");

                entity.Property(e => e.MpintryCount).HasColumnName("MPINTryCount");

                entity.Property(e => e.Osversion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OSVersion");

                entity.Property(e => e.OtptryCount).HasColumnName("OTPTryCount");

                entity.Property(e => e.RandomNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("random_num");

                entity.Property(e => e.RemarkForActivateDeactivate)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkForDeleteUser)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkForLockUnlock)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoleCategory).HasDefaultValueSql("((0))");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("SessionID");

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("session_key");

                entity.Property(e => e.SourceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceID");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.Token).IsUnicode(false);

                entity.Property(e => e.UserDetailId).HasColumnName("UserDetailID");

                entity.Property(e => e.UserInternetProtocol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsSparse();

                entity.Property(e => e.UserLockReason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserLockedOn).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass4)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login28072021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Login_28072021");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastLogoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("LastPasswordChangedDT");

                entity.Property(e => e.MakeModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Mpin).HasColumnName("MPIN");

                entity.Property(e => e.MpinlockedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("MPINLockedOn");

                entity.Property(e => e.MpintryCount).HasColumnName("MPINTryCount");

                entity.Property(e => e.Osversion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OSVersion");

                entity.Property(e => e.OtptryCount).HasColumnName("OTPTryCount");

                entity.Property(e => e.RandomNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("random_num");

                entity.Property(e => e.RemarkForActivateDeactivate)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkForDeleteUser)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RemarkForLockUnlock)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("SessionID");

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("session_key");

                entity.Property(e => e.SourceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SourceID");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.Token).IsUnicode(false);

                entity.Property(e => e.UserDetailId).HasColumnName("UserDetailID");

                entity.Property(e => e.UserId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UserID");

                entity.Property(e => e.UserInternetProtocol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserLockReason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserLockedOn).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPosTran>(entity =>
            {
                entity.HasKey(e => e.TranId)
                    .HasName("PK__mPOS_Tra__F7089629B17D83D7");

                entity.ToTable("mPOS_Tran");

                entity.HasIndex(e => new { e.TranType, e.TransactionDateTime }, "NONCLUS_MPOSTRAN_TRANTYPE_TRANDATETIME");

                entity.HasIndex(e => new { e.TerminalId, e.MerchantId, e.TransactionDateTime }, "NonClusteredTransactionReport, dbo,>");

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.AccessFeeAmount)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ActualClwapirespCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ActualCLWAPIRespCode");

                entity.Property(e => e.AdditionalAmounts)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalData)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Aiic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AIIC");

                entity.Property(e => e.AiiccountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AIICCountryCode");

                entity.Property(e => e.Apistan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APISTAN");

                entity.Property(e => e.AppResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AppResponseDateTime).HasColumnType("datetime");

                entity.Property(e => e.AppResponseMsg).IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardAcceptorNameLocation)
                    .HasMaxLength(99)
                    .IsUnicode(false);

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardMfr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNo)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CardSequenceNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClqqrHash)
                    .IsUnicode(false)
                    .HasColumnName("CLQQR_Hash");

                entity.Property(e => e.ClwqrExpiry)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CLWQR_Expiry");

                entity.Property(e => e.ConvenienceFeeAmount)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustAccRefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Cust_Acc_RefNo");

                entity.Property(e => e.CustomerMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.ForwardingInstitutionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromAccount)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.Iccdata)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ICCData");

                entity.Property(e => e.LocalTime12Hour)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTranDate)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTranTime)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mti)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MTI");

                entity.Property(e => e.NetworkInternationalIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationMobileNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalDataElement)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Otp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OTP");

                entity.Property(e => e.PartnerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerMerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PartnerMerchantID");

                entity.Property(e => e.PartnerSessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pindata)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("PINData");

                entity.Property(e => e.PosconditionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("POSConditionCode");

                entity.Property(e => e.PosentryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("POSEntryCode");

                entity.Property(e => e.ProcessingCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivingInstitution)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReplacementAmounts)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.RequestLogRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseMti)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ResponseMTI");

                entity.Property(e => e.RetrivalRefNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReversalResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReversalStan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReversalSTAN");

                entity.Property(e => e.Rrn)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RRN");

                entity.Property(e => e.SettlementAmount)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDate)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Stan)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STAN");

                entity.Property(e => e.SubscriberNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SwitchResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.ToAccount)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.TranAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.TransRefNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionAmount)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransmissionDateTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPosTran26112020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mPOS_Tran_26112020");

                entity.Property(e => e.AccessFeeAmount)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalAmounts)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalData)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Aiic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AIIC");

                entity.Property(e => e.AiiccountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AIICCountryCode");

                entity.Property(e => e.Apistan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APISTAN");

                entity.Property(e => e.AppResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardAcceptorNameLocation)
                    .HasMaxLength(99)
                    .IsUnicode(false);

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardMfr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNo)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CardSequenceNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConvenienceFeeAmount)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.ForwardingInstitutionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromAccount)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.Iccdata)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ICCData");

                entity.Property(e => e.LocalTime12Hour)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTranDate)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTranTime)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mti)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MTI");

                entity.Property(e => e.NetworkInternationalIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalDataElement)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Pindata)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("PINData");

                entity.Property(e => e.PosconditionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("POSConditionCode");

                entity.Property(e => e.PosentryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("POSEntryCode");

                entity.Property(e => e.ProcessingCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivingInstitution)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReplacementAmounts)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.RequestLogRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseMti)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ResponseMTI");

                entity.Property(e => e.ReversalResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReversalStan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReversalSTAN");

                entity.Property(e => e.Rrn)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RRN");

                entity.Property(e => e.SettlementAmount)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDate)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Stan)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STAN");

                entity.Property(e => e.SubscriberNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SwitchResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.ToAccount)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.TranAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.TranId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TranID");

                entity.Property(e => e.TransactionAmount)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransmissionDateTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasChannelInterface>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasChannelInterface");

                entity.Property(e => e.ChannelId).ValueGeneratedOnAdd();

                entity.Property(e => e.ChannelName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionExpiry).HasColumnType("datetime");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SessionID");

                entity.Property(e => e.SourceId)
                    .IsUnicode(false)
                    .HasColumnName("SourceID");
            });

            modelBuilder.Entity<MasHost>(entity =>
            {
                entity.HasKey(e => e.HostId)
                    .HasName("PK__MasHost__08D4870CB77E0E53");

                entity.ToTable("MasHost");

                entity.Property(e => e.HostId)
                    .ValueGeneratedNever()
                    .HasColumnName("HostID");

                entity.Property(e => e.CommunicationMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommunioncationDll)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CommunioncationDLL");

                entity.Property(e => e.CommunioncationMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommunioncationModule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HostDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HostShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDll)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RequestDLL");

                entity.Property(e => e.RequestMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestModule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDll)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ResponseDLL");

                entity.Property(e => e.ResponseMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseModule)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasHost14112019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasHost_14112019");

                entity.Property(e => e.CommunicationMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommunioncationDll)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CommunioncationDLL");

                entity.Property(e => e.CommunioncationMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommunioncationModule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HostDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.HostShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDll)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RequestDLL");

                entity.Property(e => e.RequestMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestModule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDll)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ResponseDLL");

                entity.Property(e => e.ResponseMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseModule)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__MasLog__5E548648F49216A6");

                entity.ToTable("MasLog");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.LogData).IsUnicode(false);

                entity.Property(e => e.LogType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LoggedFrom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoggedRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Params).IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK__MasModul__2B7477874B8FC9C9");

                entity.ToTable("MasModule");

                entity.Property(e => e.ModuleId)
                    .ValueGeneratedNever()
                    .HasColumnName("ModuleID");

                entity.Property(e => e.Dll)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DLL");

                entity.Property(e => e.MethodName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasParam>(entity =>
            {
                entity.HasKey(e => e.ParamId)
                    .HasName("PK__MasParam__C132B1049B928D73");

                entity.ToTable("MasParam");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsEditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParamValue).IsUnicode(false);
            });

            modelBuilder.Entity<MasParam09052020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasParam_09052020");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParamId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ParamID");

                entity.Property(e => e.ParamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParamValue).IsUnicode(false);
            });

            modelBuilder.Entity<MasParamQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasParam_Queue");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.ParamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParamValue).IsUnicode(false);

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            });

            modelBuilder.Entity<MasParamTemp>(entity =>
            {
                entity.HasKey(e => e.ParamId)
                    .HasName("PK__MasParam1__C132B1049B928D73");

                entity.ToTable("MasParam_Temp");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsEditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParamValue).IsUnicode(false);
            });

            modelBuilder.Entity<MasRefreshDataTable>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.TableName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasRequestLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__MasReque__5E548648C793D40D");

                entity.ToTable("MasRequestLog");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoggedRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Request).IsUnicode(false);

                entity.Property(e => e.RequestDateTime).HasColumnType("datetime");

                entity.Property(e => e.Response).IsUnicode(false);

                entity.Property(e => e.ResponseDateTime).HasColumnType("datetime");

                entity.Property(e => e.SourceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasRequestLogPurged>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__MasReque__5E5486484454C64C");

                entity.ToTable("MasRequestLog_purged");

                entity.Property(e => e.LogId).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoggedRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Request).IsUnicode(false);

                entity.Property(e => e.RequestDateTime).HasColumnType("datetime");

                entity.Property(e => e.Response).IsUnicode(false);

                entity.Property(e => e.ResponseDateTime).HasColumnType("datetime");

                entity.Property(e => e.SourceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasResponseCode>(entity =>
            {
                entity.HasKey(e => e.ResponseCode)
                    .HasName("PK__MasRespo__85E12DDD8D8EF3CD");

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Reference)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ResponseID");

                entity.Property(e => e.ResponseMessage).HasMaxLength(2000);

                entity.Property(e => e.ResponseToClient).HasMaxLength(2000);

                entity.Property(e => e.SwitchResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasResponseCode17102019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasResponseCode_17102019");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Reference)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ResponseID");

                entity.Property(e => e.ResponseMessage).HasMaxLength(2000);

                entity.Property(e => e.ResponseToClient).HasMaxLength(2000);

                entity.Property(e => e.SwitchResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasResponseCodes04102019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasResponseCodes_04102019");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Reference)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ResponseID");

                entity.Property(e => e.ResponseMessage).IsUnicode(false);

                entity.Property(e => e.ResponseToClient).IsUnicode(false);

                entity.Property(e => e.SwitchResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasSwitchParam>(entity =>
            {
                entity.HasKey(e => e.ParamId)
                    .HasName("PK__MasSwitc__C132B104A5BC55BE");

                entity.ToTable("MasSwitchParam");

                entity.Property(e => e.ParamId).HasColumnName("ParamID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsEditable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParamValue)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasSwitchParam02012020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MasSwitchParam_02_01_2020");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParamId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ParamID");

                entity.Property(e => e.ParamName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParamValue)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasTransactionType>(entity =>
            {
                entity.ToTable("MasTransactionType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TransDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mashost04112019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASHOST_04112019");

                entity.Property(e => e.CommunicationMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommunioncationDll)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CommunioncationDLL");

                entity.Property(e => e.CommunioncationMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommunioncationModule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HostDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.HostShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IP");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDll)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RequestDLL");

                entity.Property(e => e.RequestMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestModule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseDll)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ResponseDLL");

                entity.Property(e => e.ResponseMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseModule)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Masresponsecodes14102019>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASRESPONSECODES_14102019");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Reference)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ResponseID");

                entity.Property(e => e.ResponseMessage).IsUnicode(false);

                entity.Property(e => e.ResponseToClient).IsUnicode(false);

                entity.Property(e => e.SwitchResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MassModule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MassModule");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .IsSparse();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsSparse();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .IsSparse();

                entity.Property(e => e.DllPath)
                    .IsUnicode(false)
                    .IsSparse();

                entity.Property(e => e.EnableState).IsSparse();

                entity.Property(e => e.FrequencyUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsSparse();

                entity.Property(e => e.LastRunTime)
                    .HasColumnType("datetime")
                    .IsSparse();

                entity.Property(e => e.MassDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MassModuleCode).ValueGeneratedOnAdd();

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsSparse();

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .IsSparse();

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .IsSparse();

                entity.Property(e => e.NextRunDate)
                    .HasColumnType("datetime")
                    .IsSparse();

                entity.Property(e => e.Status).IsSparse();
            });

            modelBuilder.Entity<MassModuleReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MassModuleReport");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DllPath).IsUnicode(false);

                entity.Property(e => e.FrequencyUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastRunTime).HasColumnType("datetime");

                entity.Property(e => e.MassDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NextRunDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MerchantMappingTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MerchantMappingTemp");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");
            });

            modelBuilder.Entity<MposTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mposTemp");

                entity.Property(e => e.AccessFeeAmount)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalAmounts)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalData)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Aiic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AIIC");

                entity.Property(e => e.AiiccountryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AIICCountryCode");

                entity.Property(e => e.Apistan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APISTAN");

                entity.Property(e => e.AppResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardAcceptorNameLocation)
                    .HasMaxLength(99)
                    .IsUnicode(false);

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardMfr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNo)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CardSequenceNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConvenienceFeeAmount)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.ForwardingInstitutionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromAccount)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.Iccdata)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ICCData");

                entity.Property(e => e.LocalTime12Hour)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTranDate)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTranTime)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Mti)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MTI");

                entity.Property(e => e.NetworkInternationalIdentifier)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalDataElement)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.Pindata)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("PINData");

                entity.Property(e => e.PosconditionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("POSConditionCode");

                entity.Property(e => e.PosentryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("POSEntryCode");

                entity.Property(e => e.ProcessingCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivingInstitution)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReplacementAmounts)
                    .HasMaxLength(42)
                    .IsUnicode(false);

                entity.Property(e => e.RequestLogRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseMti)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ResponseMTI");

                entity.Property(e => e.ReversalResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReversalStan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReversalSTAN");

                entity.Property(e => e.Rrn)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RRN");

                entity.Property(e => e.SettlementAmount)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementDate)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Stan)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STAN");

                entity.Property(e => e.SubscriberNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SwitchResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.ToAccount)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.TranAmount).HasColumnType("numeric(32, 8)");

                entity.Property(e => e.TranId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TranID");

                entity.Property(e => e.TransactionAmount)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransmissionDateTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationReportTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OperationReportTest");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Countm).HasColumnName("COUNTM");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantName).IsUnicode(false);

                entity.Property(e => e.Month)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Month1).HasColumnName("MONTH1");

                entity.Property(e => e.TranDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OtherDetail>(entity =>
            {
                entity.ToTable("OtherDetail");

                entity.Property(e => e.OtherDetailId).HasColumnName("OtherDetailID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceSerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MCC");

                entity.Property(e => e.Mid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MID");

                entity.Property(e => e.Nic)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NIC");

                entity.Property(e => e.PinCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RcbcaccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RCBCAccountNumber");

                entity.Property(e => e.ReceiptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Tid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TID");

                entity.Property(e => e.UserDetailId).HasColumnName("UserDetailID");
            });

            modelBuilder.Entity<Otpdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OTPData");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Otp)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("OTP");

                entity.Property(e => e.Otplimit).HasColumnName("OTPLimit");

                entity.Property(e => e.OtpsendTime)
                    .HasColumnType("datetime")
                    .HasColumnName("OTPSendTime");

                entity.Property(e => e.Otptype)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("OTPType");

                entity.Property(e => e.SrNo).ValueGeneratedOnAdd();

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.TryCountTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PageAccessRight>(entity =>
            {
                entity.HasKey(e => e.AccessRightsId)
                    .HasName("PK__PageAcce__EE28FE121B29B1F8");

                entity.Property(e => e.AccessRightsId).HasColumnName("AccessRightsID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsAccessible).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PageLinkId).HasColumnName("PageLinkID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<PageAccessRightsQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PageAccessRights_Queue");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PageLinkId).HasColumnName("PageLinkID");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<PageLink>(entity =>
            {
                entity.Property(e => e.PageLinkId).HasColumnName("PageLinkID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LinkID");

                entity.Property(e => e.LinkName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PageName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ParentLinkId).HasColumnName("ParentLinkID");
            });

            modelBuilder.Entity<PartnerDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActiveTranCount).HasColumnName("Active_Tran_Count");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ClientID");

                entity.Property(e => e.GrantType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grant_type");

                entity.Property(e => e.PartnerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerMerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartnerMerchantID");

                entity.Property(e => e.PartnerSessionId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PartnerSessionID");

                entity.Property(e => e.PasswordReseton).HasColumnType("datetime");

                entity.Property(e => e.PasswordUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PrevPubKeyActiveFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("Prev_PubKey_ActiveFrom");

                entity.Property(e => e.PrevPubKeyExpiredOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Prev_PubKey_ExpiredOn");

                entity.Property(e => e.PrevPublicKey).HasColumnName("Prev_PublicKey");

                entity.Property(e => e.PublicKeyCreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("PublicKey_CreatedOn");

                entity.Property(e => e.PublicKeyExpiredOn)
                    .HasColumnType("datetime")
                    .HasColumnName("PublicKey_ExpiredOn");

                entity.Property(e => e.Scope)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("province");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.Province1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("province");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__province__region__57F2E5D4");
            });

            modelBuilder.Entity<ReconciliationReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReconciliationReport");

                entity.Property(e => e.BillerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BinNo)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Card Type");

                entity.Property(e => e.CreditAccountNo)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTranAmount).HasColumnType("numeric(17, 2)");

                entity.Property(e => e.DebitAccountNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Debit Account No.");

                entity.Property(e => e.DebitCardNo)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DebitTranAmount).HasColumnType("numeric(17, 2)");

                entity.Property(e => e.IssuingBankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Issuing Bank Name");

                entity.Property(e => e.LocationBranch)
                    .HasMaxLength(2000)
                    .HasColumnName("Location/Branch");

                entity.Property(e => e.MdrAmount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MDR (Amount)");

                entity.Property(e => e.MdrRate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MDR (Rate)");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Merchant ID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Merchant Name");

                entity.Property(e => e.MerchantShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Merchant Share");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Message Code");

                entity.Property(e => e.PosAssignedTxnNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("POS Assigned Txn No.");

                entity.Property(e => e.RcbcShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RCBC Share");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Reference Number");

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Referred By");

                entity.Property(e => e.ReferrerAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Referrer Account No");

                entity.Property(e => e.ReferrerFeeShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ReferrerFee Share");

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementAccNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Settlement Acc No.");

                entity.Property(e => e.SubscriberSAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Subscriber's Account No.");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Terminal ID");

                entity.Property(e => e.TotalAmountPhp)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("Total Amount (PHP)");

                entity.Property(e => e.TraceNumber)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Trace Number");

                entity.Property(e => e.TransactionAmountPhp)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("Transaction Amount (PHP)");

                entity.Property(e => e.TransactionDate)
                    .HasMaxLength(4000)
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionFee)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("Transaction Fee");

                entity.Property(e => e.TransactionStatus)
                    .HasMaxLength(2000)
                    .HasColumnName("Transaction Status");

                entity.Property(e => e.TransactionTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Time")
                    .IsFixedLength();

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Type");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.ToTable("region");

                entity.Property(e => e.RegionId).HasColumnName("region_id");

                entity.Property(e => e.IslandId).HasColumnName("island_id");

                entity.Property(e => e.Region1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("region");

                entity.HasOne(d => d.Island)
                    .WithMany(p => p.InverseIsland)
                    .HasForeignKey(d => d.IslandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__region__island_i__5ACF527F");
            });

            modelBuilder.Entity<ReportAccessRight>(entity =>
            {
                entity.HasKey(e => e.AccessRightsId)
                    .HasName("PK__ReportAc__EE28FE1222B2808A");

                entity.Property(e => e.AccessRightsId).HasColumnName("AccessRightsID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsAccessible).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportTypeId).HasColumnName("ReportTypeID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<ReportAccessRightsHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportAccessRights_History");

                entity.Property(e => e.AccessRightsId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AccessRightsID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsAccessible).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ReportTypeId).HasColumnName("ReportTypeID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<ReportDetail>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.HasIndex(e => e.TransactionDateTime, "indx_transactiondatetime_for_sort");

                entity.Property(e => e.TranId)
                    .ValueGeneratedNever()
                    .HasColumnName("TranID");

                entity.Property(e => e.BillerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BILLER_NAME");

                entity.Property(e => e.BinNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CARD_TYPE");

                entity.Property(e => e.CreditAccountNo)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_ACCOUNT_NO");

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_CARD_NO");

                entity.Property(e => e.CreditTrxnAmount)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("CREDIT_TRXN_AMOUNT");

                entity.Property(e => e.DebitAccountNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEBIT_ACCOUNT_NO");

                entity.Property(e => e.DebitCardNo)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("DEBIT_CARD_NO");

                entity.Property(e => e.DebitTrxnAmount)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("DEBIT_TRXN_AMOUNT");

                entity.Property(e => e.Filler)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FILLER");

                entity.Property(e => e.IssuingBankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Issuing Bank Name");

                entity.Property(e => e.LocationBranch)
                    .HasMaxLength(2000)
                    .HasColumnName("Location/Branch");

                entity.Property(e => e.MerchSttlmntAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MERCH_STTLMNT_ACCT_NO");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MERCHANT_ID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MERCHANT_NAME");

                entity.Property(e => e.MerchantShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MERCHANT_SHARE");

                entity.Property(e => e.MrdAmount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MRD_AMOUNT");

                entity.Property(e => e.MrdRate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MRD_RATE");

                entity.Property(e => e.MsgCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MSG_CODE");

                entity.Property(e => e.PosAssignTrxnNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("POS_ASSIGN_TRXN_NO");

                entity.Property(e => e.RcbcShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RCBC_SHARE");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFERRED_BY");

                entity.Property(e => e.ReferrerAccntNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REFERRER_ACCNT_NO");

                entity.Property(e => e.ReferrerShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("REFERRER_SHARE");

                entity.Property(e => e.SubsAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SUBS_ACCOUNT_NO");

                entity.Property(e => e.TermId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TERM_ID");

                entity.Property(e => e.TotalAmountPhp)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("TotalAmount_PHP");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TrcNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TRC_NO");

                entity.Property(e => e.TrxnAmount)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("TRXN_AMOUNT");

                entity.Property(e => e.TrxnCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRXN_CODE");

                entity.Property(e => e.TrxnDate)
                    .HasMaxLength(4000)
                    .HasColumnName("TRXN_DATE");

                entity.Property(e => e.TrxnFee)
                    .HasColumnType("numeric(23, 8)")
                    .HasColumnName("TRXN_FEE");

                entity.Property(e => e.TrxnStat)
                    .HasMaxLength(2000)
                    .HasColumnName("TRXN_STAT");

                entity.Property(e => e.TrxnTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRXN_TIME")
                    .IsFixedLength();

                entity.Property(e => e.TrxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRXN_TYPE");
            });

            modelBuilder.Entity<ReportType>(entity =>
            {
                entity.ToTable("ReportType");

                entity.HasIndex(e => e.ShortName, "UQ__ReportTy__A6160FD190BCC0C6")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RequestType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RequestType");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestTypeDescription).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");
            });

            modelBuilder.Entity<ResetPasswordQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ResetPassword_Queue");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ResponseCodeConfig>(entity =>
            {
                entity.ToTable("ResponseCodeConfig");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ApiresponseCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("APIResponseCode");

                entity.Property(e => e.ApiresponseMsg)
                    .IsUnicode(false)
                    .HasColumnName("APIResponseMsg");

                entity.Property(e => e.ClientResponseCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClientResponseMsg).IsUnicode(false);

                entity.Property(e => e.DbresponseCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DBResponseCode");

                entity.Property(e => e.DbresponseMsg)
                    .IsUnicode(false)
                    .HasColumnName("DBResponseMsg");

                entity.Property(e => e.TranSubType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TranType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RoleCategory");

                entity.Property(e => e.Descriptions)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RoleMaster");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustIdentity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustIdlen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustIDLen");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RemarkForDeleteRole)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoleDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RoleID");
            });

            modelBuilder.Entity<RoleMaster10022020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RoleMaster_10022020");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustIdentity)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustIdlen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustIDLen");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RemarkForDeleteRole)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoleDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RoleID");
            });

            modelBuilder.Entity<RoleMasterQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RoleMaster_Queue");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.RoleDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<ServerAeskey>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServerAESKeys");

                entity.Property(e => e.Aeskey).HasColumnName("AESKey");

                entity.Property(e => e.Createddate)
                    .HasColumnType("datetime")
                    .HasColumnName("createddate");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lastupdateddate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastupdateddate");

                entity.Property(e => e.Random3).HasColumnName("random3");

                entity.Property(e => e.Random4).HasColumnName("random4");

                entity.Property(e => e.Random6).HasColumnName("random6");

                entity.Property(e => e.RandomNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("random_num");

                entity.Property(e => e.RequestDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("request_datetime");

                entity.Property(e => e.Serverid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");
            });

            modelBuilder.Entity<SetPasswordLink>(entity =>
            {
                entity.ToTable("SetPasswordLink");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RequestFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("UniqueID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SetPinlink>(entity =>
            {
                entity.ToTable("SetPINLink");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RequestFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("UniqueID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.Countm).HasColumnName("COUNTM");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(255)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantName).HasMaxLength(255);

                entity.Property(e => e.Month).HasMaxLength(255);

                entity.Property(e => e.Month1).HasColumnName("MONTH1");

                entity.Property(e => e.TranDescription).HasMaxLength(255);
            });

            modelBuilder.Entity<SignOnLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SignOnLog");

                entity.Property(e => e.CurrentValue).IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Keys)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousValue).IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SubTranMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SubTranMenu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubMenuDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TranTypeId).HasColumnName("TranTypeID");
            });

            modelBuilder.Entity<TblMerchant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblMerchant");

                entity.HasIndex(e => e.MerchantId, "indx_merchant_id_for_sort");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ActivatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Activated_ON");

                entity.Property(e => e.Address).HasMaxLength(2000);

                entity.Property(e => e.AgingDays)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Balance)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DateBoarded).HasColumnType("datetime");

                entity.Property(e => e.DiscountRate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DistributedCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Email_id");

                entity.Property(e => e.EncNic).HasColumnName("EncNIC");

                entity.Property(e => e.EnrollDatetime).HasColumnType("datetime");

                entity.Property(e => e.Fuelcompany)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MCC");

                entity.Property(e => e.Mccid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MCCID");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Merchant_Type");

                entity.Property(e => e.MerchantType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantType");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.NameOnReceipt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nic)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NIC");

                entity.Property(e => e.OperatorContactNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParticipantId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ParticipantID");

                entity.Property(e => e.PartnerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("partnerCode");

                entity.Property(e => e.PartnerMerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PartnerMerchantID");

                entity.Property(e => e.PartnerSessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PartnerSessionID");

                entity.Property(e => e.SeNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Se_number");

                entity.Property(e => e.SecEmailId)
                    .HasMaxLength(2000)
                    .HasColumnName("Sec_EmailId");

                entity.Property(e => e.SettlementBalance)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Settlement_Balance");

                entity.Property(e => e.SettlementType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlazoningDays)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLAZoningDays");

                entity.Property(e => e.UpiVpa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPI_VPA")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Upibank)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UPIBank");

                entity.Property(e => e.Upiid)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UPIID");

                entity.Property(e => e.Zone)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMerchantDetail>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.MerchantId }, "IX_userid_merchantid_sort");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TblMerchantEnrollUpdateHistory>(entity =>
            {
                entity.ToTable("TblMerchantEnrollUpdateHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApiresponseCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("APIResponseCode");

                entity.Property(e => e.ApiresponseDtTime)
                    .HasColumnType("datetime")
                    .HasColumnName("APIResponseDtTime");

                entity.Property(e => e.ApiresponseMsg)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("APIResponseMsg");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.TranType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMerchantReportEmailId>(entity =>
            {
                entity.ToTable("TblMerchantReportEmailId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailBodyPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailException).HasMaxLength(1000);

                entity.Property(e => e.EmailId).HasMaxLength(2000);

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMerchantReportEmailIdArchival>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblMerchantReportEmailId_Archival");

                entity.Property(e => e.ArchivalCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ArchivalId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailException).HasMaxLength(1000);

                entity.Property(e => e.EmailId).HasMaxLength(2000);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblOtherBankBinConfiguration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblOtherBankBinConfiguration");

                entity.Property(e => e.BankAbrevation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Bid).ValueGeneratedOnAdd();

                entity.Property(e => e.CardBrand)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOtherBankBinConfiguration09072020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblOtherBankBinConfiguration_09072020");

                entity.Property(e => e.BankAbrevation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Bid).ValueGeneratedOnAdd();

                entity.Property(e => e.CardBrand)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblOtherBankBinConfiguration30032020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblOtherBankBinConfiguration_30032020");

                entity.Property(e => e.BankAbrevation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Bid).ValueGeneratedOnAdd();

                entity.Property(e => e.CardBrand)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IssuerCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblReferrerDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferrerAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferrerEmail).HasMaxLength(100);

                entity.Property(e => e.ReferrerId).ValueGeneratedOnAdd();

                entity.Property(e => e.ReferrerMobile)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReferrerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSwitchRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TblSwitchRequest");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RequestId).HasMaxLength(500);

                entity.Property(e => e.Stan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTerminal>(entity =>
            {
                entity.HasKey(e => e.TerminalName)
                    .HasName("pk_term");

                entity.HasIndex(e => new { e.TerminalId, e.MerchantId }, "<Name of Missing Index, sysname,>");

                entity.Property(e => e.TerminalName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(500)
                    .HasColumnName("account_no");

                entity.Property(e => e.ActivatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Activated_ON");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApayDeviceId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("APay_DeviceID");

                entity.Property(e => e.ApayImei)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("APay_IMEI");

                entity.Property(e => e.AppVer)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("App_Ver");

                entity.Property(e => e.BatchDate)
                    .HasColumnType("date")
                    .HasColumnName("Batch_Date");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Batch_No");

                entity.Property(e => e.CertificationUpload)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DailyLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Daily_Limit");

                entity.Property(e => e.DeviceAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceSerialNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirmwareVersion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gcmid)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("GCMID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Imei)
                    .IsUnicode(false)
                    .HasColumnName("IMEI");

                entity.Property(e => e.InstalledOperationalDate).HasColumnType("datetime");

                entity.Property(e => e.LogOnSessionKey)
                    .HasMaxLength(500)
                    .HasColumnName("LogOn_SessionKey");

                entity.Property(e => e.LogoPath)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("logoPath");

                entity.Property(e => e.Logonkey).HasColumnName("logonkey");

                entity.Property(e => e.Menu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.Model)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.MonthlyLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Monthly_Limit");

                entity.Property(e => e.MpospesaPodSerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MPOSPesaPodSerialNumber");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OneTimeLimit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("OneTime_Limit");

                entity.Property(e => e.OtherInfoPicture)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OtpFlag).HasColumnName("OTP_Flag");

                entity.Property(e => e.OtpValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OTP_Value");

                entity.Property(e => e.PhoneSerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PictureFileBack)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Pin)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlatformType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PrinterSerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ShopPicture)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SimSerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Simid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIMID");

                entity.Property(e => e.SmartNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SrId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SrID");

                entity.Property(e => e.Stan).HasColumnName("stan");

                entity.Property(e => e.State)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.SwiperId)
                    .IsUnicode(false)
                    .HasColumnName("Swiper_ID");

                entity.Property(e => e.TerminalAddress)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.TerminalMasterKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalSecondKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipFlag)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UserPin)
                    .HasMaxLength(500)
                    .HasColumnName("userPIN");

                entity.Property(e => e.VcrRoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vcrRO_COde")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VersionNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TelcoMaster>(entity =>
            {
                entity.HasKey(e => e.TelcoId)
                    .HasName("PK__TelcoMas__4FF2D74F69049C75");

                entity.ToTable("TelcoMaster");

                entity.Property(e => e.TelcoId).HasColumnName("TelcoID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TelcoCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelcoName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TelcoMasterQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TelcoMaster_Queue");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.TelcoCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelcoId).HasColumnName("TelcoID");

                entity.Property(e => e.TelcoName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.ToTable("Template");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EmailTemplate).IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSms)
                    .HasColumnName("IsSMS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Smstemplate)
                    .IsUnicode(false)
                    .HasColumnName("SMSTemplate");

                entity.Property(e => e.TemplateCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TerminalCounter>(entity =>
            {
                entity.ToTable("TerminalCounter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.TerminalStan).HasColumnName("TerminalSTAN");
            });

            modelBuilder.Entity<TestTbl>(entity =>
            {
                entity.ToTable("TestTbl");

                entity.HasIndex(e => new { e.Transno, e.Transdate }, "UQ__TestTbl__19E8A37FB253DB3D")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Transdate)
                    .HasColumnType("datetime")
                    .HasColumnName("transdate");

                entity.Property(e => e.Transno).HasColumnName("transno");
            });

            modelBuilder.Entity<TmpReprintCustom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TmpReprintCustom");

                entity.Property(e => e.AuthCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvailableTotal)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rrn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RRN");

                entity.Property(e => e.Stan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STAN");

                entity.Property(e => e.SubscriberNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TranAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TranTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TranType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionFlag)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TranType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TranType");

                entity.HasIndex(e => e.TranType1, "UQ__TranType__C9A054E645968E49")
                    .IsUnique();

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MasTranTypeVerify)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MasTransType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Smsbody).HasColumnName("SMSBody");

                entity.Property(e => e.TranDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TranType1).HasColumnName("TranType");

                entity.Property(e => e.TranTypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TranTypeID");
            });

            modelBuilder.Entity<TranTypeAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TranTypeAccess");
            });

            modelBuilder.Entity<TranTypeRight>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SubTranId).HasColumnName("SubTranID");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");
            });

            modelBuilder.Entity<TranTypeRightsQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TranTypeRights_Queue");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.SubTranId).HasColumnName("SubTranID");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");
            });

            modelBuilder.Entity<TransactionTypeSummaryDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Percentage).HasColumnType("numeric(17, 4)");

                entity.Property(e => e.TranType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("numeric(17, 4)");
            });

            modelBuilder.Entity<UploadBillerListHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UploadBillerListHistory");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(2000);

                entity.Property(e => e.BillerName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.UploadFileName)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.UploadId).HasColumnName("UploadID");

                entity.Property(e => e.ValidationMsg)
                    .HasMaxLength(800)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UploadFsmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UploadFSMaster");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Error)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullFilePath)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UploadMerchantListHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UploadMerchantListHistory");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(2000);

                entity.Property(e => e.AgingDays).HasMaxLength(500);

                entity.Property(e => e.BalanceInquiry)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceInquiryFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BankFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillPayment)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CashIn)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationUpload)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ConvenienceFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateBoarded)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ELoad)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("eLoad");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EncNic).HasColumnName("EncNIC");

                entity.Property(e => e.FeeType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FundTransfer)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InstalledOperationalDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MCC");

                entity.Property(e => e.MerchantCount).HasMaxLength(500);

                entity.Property(e => e.MerchantFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MpospesaPodSerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MPOSPesaPodSerialNumber");

                entity.Property(e => e.NameOnReceipt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nic)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NIC");

                entity.Property(e => e.Operation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorContactNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneSerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pinchange)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PINChange");

                entity.Property(e => e.PrinterSerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.ReferralAccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralEmailId).HasMaxLength(100);

                entity.Property(e => e.ReferralMobileNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReferrerFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ReferrerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SecEmailId)
                    .HasMaxLength(2000)
                    .HasColumnName("Sec_EmailId");

                entity.Property(e => e.SimSerialNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlazoningDays)
                    .HasMaxLength(500)
                    .HasColumnName("SLAZoningDays");

                entity.Property(e => e.SmartNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalAddress)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.TerminalName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UploadFileName)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.UploadId).HasColumnName("UploadID");

                entity.Property(e => e.ValidationMsg)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Withdraw)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.WithdrawalFee).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Zone)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UrbanRuralStatistic>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Area)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Island)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Percentage).HasColumnType("numeric(17, 4)");

                entity.Property(e => e.TxnVal).HasColumnType("numeric(17, 4)");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserDetail");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gcmid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("GCMID");

                entity.Property(e => e.Imeino)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IMEINo");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SerialId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SerialID");

                entity.Property(e => e.UserDetailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UserDetailID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserStatusQueue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserStatus_Queue");

                entity.Property(e => e.CheckerId).HasColumnName("CheckerID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FormStatusId).HasColumnName("FormStatusID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MakerId).HasColumnName("MakerID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).IsUnicode(false);

                entity.Property(e => e.RequestTypeId).HasColumnName("RequestTypeID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<VwDownloadReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_DownloadReport");

                entity.Property(e => e.BinNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Card Type");

                entity.Property(e => e.CreditAccountNo)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTranAmount).HasColumnType("numeric(17, 2)");

                entity.Property(e => e.DebitAccountNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Debit Account No.");

                entity.Property(e => e.DebitCardNo)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DebitTranAmount).HasColumnType("numeric(17, 2)");

                entity.Property(e => e.IssuingBankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Issuing Bank Name");

                entity.Property(e => e.LocationBranch)
                    .HasMaxLength(2000)
                    .HasColumnName("Location/Branch");

                entity.Property(e => e.MdrAmount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MDR (Amount)");

                entity.Property(e => e.MdrRate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MDR (Rate)");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Merchant ID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Merchant Name");

                entity.Property(e => e.MerchantShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Merchant Share");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Message Code");

                entity.Property(e => e.PosAssignedTxnNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("POS Assigned Txn No.");

                entity.Property(e => e.RcbcShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RCBC Share");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Reference Number");

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Referred By");

                entity.Property(e => e.ReferrerAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Referrer Account No");

                entity.Property(e => e.ReferrerFeeShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ReferrerFee Share");

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementAccNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Settlement Acc No.");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Terminal ID");

                entity.Property(e => e.TotalAmountPhp)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("Total Amount (PHP)");

                entity.Property(e => e.TraceNumber)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Trace Number");

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.TransactionAmountPhp)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("Transaction Amount (PHP)");

                entity.Property(e => e.TransactionDate)
                    .HasMaxLength(4000)
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionFee)
                    .HasColumnType("numeric(23, 8)")
                    .HasColumnName("Transaction Fee");

                entity.Property(e => e.TransactionStatus)
                    .HasMaxLength(2000)
                    .HasColumnName("Transaction Status");

                entity.Property(e => e.TransactionTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Time")
                    .IsFixedLength();

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Type");
            });

            modelBuilder.Entity<VwHandOffreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_HandOFFReport");

                entity.Property(e => e.BillerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BILLER_NAME");

                entity.Property(e => e.BinNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CARD_TYPE");

                entity.Property(e => e.CreditAccountNo)
                    .HasMaxLength(28)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_ACCOUNT_NO");

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_CARD_NO");

                entity.Property(e => e.CreditTrxnAmount)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("CREDIT_TRXN_AMOUNT");

                entity.Property(e => e.DebitAccountNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DEBIT_ACCOUNT_NO");

                entity.Property(e => e.DebitCardNo)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .HasColumnName("DEBIT_CARD_NO");

                entity.Property(e => e.DebitTrxnAmount)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("DEBIT_TRXN_AMOUNT");

                entity.Property(e => e.Filler)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FILLER");

                entity.Property(e => e.IssuingBankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Issuing Bank Name");

                entity.Property(e => e.LocationBranch)
                    .HasMaxLength(2000)
                    .HasColumnName("Location/Branch");

                entity.Property(e => e.MerchSttlmntAcctNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MERCH_STTLMNT_ACCT_NO");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MERCHANT_ID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MERCHANT_NAME");

                entity.Property(e => e.MerchantShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("MERCHANT_SHARE");

                entity.Property(e => e.MrdAmount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MRD_AMOUNT");

                entity.Property(e => e.MrdRate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MRD_RATE");

                entity.Property(e => e.MsgCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MSG_CODE");

                entity.Property(e => e.PosAssignTrxnNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("POS_ASSIGN_TRXN_NO");

                entity.Property(e => e.RcbcShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RCBC_SHARE");

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFERRED_BY");

                entity.Property(e => e.ReferrerAccntNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REFERRER_ACCNT_NO");

                entity.Property(e => e.ReferrerShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("REFERRER_SHARE");

                entity.Property(e => e.SubsAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SUBS_ACCOUNT_NO");

                entity.Property(e => e.TermId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TERM_ID");

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TrcNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("TRC_NO");

                entity.Property(e => e.TrxnAmount)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("TRXN_AMOUNT");

                entity.Property(e => e.TrxnCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRXN_CODE");

                entity.Property(e => e.TrxnDate)
                    .HasMaxLength(4000)
                    .HasColumnName("TRXN_DATE");

                entity.Property(e => e.TrxnFee)
                    .HasColumnType("numeric(23, 8)")
                    .HasColumnName("TRXN_FEE");

                entity.Property(e => e.TrxnStat)
                    .HasMaxLength(2000)
                    .HasColumnName("TRXN_STAT");

                entity.Property(e => e.TrxnTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TRXN_TIME")
                    .IsFixedLength();

                entity.Property(e => e.TrxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRXN_TYPE");
            });

            modelBuilder.Entity<VwReconciliationReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_ReconciliationReport");

                entity.Property(e => e.BinNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Card Type");

                entity.Property(e => e.CreditAccountNo)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTranAmount).HasColumnType("numeric(17, 2)");

                entity.Property(e => e.DebitAccountNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Debit Account No.");

                entity.Property(e => e.DebitCardNo)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.DebitTranAmount).HasColumnType("numeric(17, 2)");

                entity.Property(e => e.IssuingBankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Issuing Bank Name");

                entity.Property(e => e.LocationBranch)
                    .HasMaxLength(2000)
                    .HasColumnName("Location/Branch");

                entity.Property(e => e.MdrAmount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MDR (Amount)");

                entity.Property(e => e.MdrRate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MDR (Rate)");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Merchant ID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Merchant Name");

                entity.Property(e => e.MerchantShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Merchant Share");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("Message Code");

                entity.Property(e => e.PosAssignedTxnNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("POS Assigned Txn No.");

                entity.Property(e => e.RcbcShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RCBC Share");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("Reference Number");

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Referred By");

                entity.Property(e => e.ReferrerAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Referrer Account No");

                entity.Property(e => e.ReferrerFeeShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ReferrerFee Share");

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SettlementAccNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Settlement Acc No.");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Terminal ID");

                entity.Property(e => e.TotalAmountPhp)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("Total Amount (PHP)");

                entity.Property(e => e.TraceNumber)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Trace Number");

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.TransactionAmountPhp)
                    .HasColumnType("numeric(17, 2)")
                    .HasColumnName("Transaction Amount (PHP)");

                entity.Property(e => e.TransactionDate)
                    .HasMaxLength(4000)
                    .HasColumnName("Transaction Date");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionFee)
                    .HasColumnType("numeric(23, 8)")
                    .HasColumnName("Transaction Fee");

                entity.Property(e => e.TransactionStatus)
                    .HasMaxLength(2000)
                    .HasColumnName("Transaction Status");

                entity.Property(e => e.TransactionTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Time")
                    .IsFixedLength();

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Transaction Type");
            });

            modelBuilder.Entity<VwReversalTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_ReversalTransaction");

                entity.Property(e => e.OriginalStan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReversalResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReversalResponseMsg).HasMaxLength(2000);

                entity.Property(e => e.ReversalStan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReversalSTAN");

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");
            });

            modelBuilder.Entity<VwTxnDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_TxnData");

                entity.Property(e => e.Address)
                    .HasMaxLength(301)
                    .IsUnicode(false);

                entity.Property(e => e.Apistan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APISTAN");

                entity.Property(e => e.AuthCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.BillerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAccountNo)
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAccountNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DebitCardNo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Mdramount)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MDRAmount");

                entity.Property(e => e.Mdrrate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MDRRate");

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantSettlementAccNumber)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralAmount)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Referror)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseMsg).IsUnicode(false);

                entity.Property(e => e.Rrnnumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("RRNNumber");

                entity.Property(e => e.SubscribersAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TerminalID");

                entity.Property(e => e.TransactionAmount).HasColumnType("numeric(17, 8)");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionFee).HasColumnType("numeric(17, 8)");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence<int>("EchoSignOnSequence")
                .StartsAt(100001)
                .HasMin(100001)
                .HasMax(999999)
                .IsCyclic();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
