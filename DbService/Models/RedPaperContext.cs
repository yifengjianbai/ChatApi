using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DbService.Models
{
    public partial class RedPaperContext : DbContext
    {
        public RedPaperContext()
        {
        }

        public RedPaperContext(DbContextOptions<RedPaperContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Applications { get; set; }
        public virtual DbSet<BuilderTable> BuilderTables { get; set; }
        public virtual DbSet<BuilderTableColumn> BuilderTableColumns { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryType> CategoryTypes { get; set; }
        public virtual DbSet<DataPrivilegeRule> DataPrivilegeRules { get; set; }
        public virtual DbSet<FlowInstance> FlowInstances { get; set; }
        public virtual DbSet<FlowInstanceOperationHistory> FlowInstanceOperationHistories { get; set; }
        public virtual DbSet<FlowInstanceTransitionHistory> FlowInstanceTransitionHistories { get; set; }
        public virtual DbSet<FlowScheme> FlowSchemes { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<FrmLeaveReq> FrmLeaveReqs { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<ModuleElement> ModuleElements { get; set; }
        public virtual DbSet<OpenJob> OpenJobs { get; set; }
        public virtual DbSet<Org> Orgs { get; set; }
        public virtual DbSet<Relevance> Relevances { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RpAccountChanging> RpAccountChangings { get; set; }
        public virtual DbSet<RpBadge> RpBadges { get; set; }
        public virtual DbSet<RpChatOfflineMsg> RpChatOfflineMsgs { get; set; }
        public virtual DbSet<RpChatReadFlag> RpChatReadFlags { get; set; }
        public virtual DbSet<RpChatUnlock> RpChatUnlocks { get; set; }
        public virtual DbSet<RpCoinCharge> RpCoinCharges { get; set; }
        public virtual DbSet<RpCoinsSell> RpCoinsSells { get; set; }
        public virtual DbSet<RpCommentLiked> RpCommentLikeds { get; set; }
        public virtual DbSet<RpExpAcquireSetting> RpExpAcquireSettings { get; set; }
        public virtual DbSet<RpExpSignAcquireSetting> RpExpSignAcquireSettings { get; set; }
        public virtual DbSet<RpGoodsSell> RpGoodsSells { get; set; }
        public virtual DbSet<RpGoodsShopping> RpGoodsShoppings { get; set; }
        public virtual DbSet<RpGrowthBadge> RpGrowthBadges { get; set; }
        public virtual DbSet<RpGrowthCoinConvert> RpGrowthCoinConverts { get; set; }
        public virtual DbSet<RpGrowthExperience> RpGrowthExperiences { get; set; }
        public virtual DbSet<RpGrowthUpgrade> RpGrowthUpgrades { get; set; }
        public virtual DbSet<RpLevelExpSetting> RpLevelExpSettings { get; set; }
        public virtual DbSet<RpMeetReport> RpMeetReports { get; set; }
        public virtual DbSet<RpMomentComment> RpMomentComments { get; set; }
        public virtual DbSet<RpMomentGift> RpMomentGifts { get; set; }
        public virtual DbSet<RpMomentInfo> RpMomentInfos { get; set; }
        public virtual DbSet<RpMomentLiked> RpMomentLikeds { get; set; }
        public virtual DbSet<RpMomentShare> RpMomentShares { get; set; }
        public virtual DbSet<RpOrdinaryUserAwardGood> RpOrdinaryUserAwardGoods { get; set; }
        public virtual DbSet<RpOrdinaryUserAwardSetting> RpOrdinaryUserAwardSettings { get; set; }
        public virtual DbSet<RpPubMedium> RpPubMedia { get; set; }
        public virtual DbSet<RpRank> RpRanks { get; set; }
        public virtual DbSet<RpShareRecord> RpShareRecords { get; set; }
        public virtual DbSet<RpSigninRecord> RpSigninRecords { get; set; }
        public virtual DbSet<RpStuffsInBag> RpStuffsInBags { get; set; }
        public virtual DbSet<RpSystemSetting> RpSystemSettings { get; set; }
        public virtual DbSet<RpTag> RpTags { get; set; }
        public virtual DbSet<RpUserAccount> RpUserAccounts { get; set; }
        public virtual DbSet<RpUserBadge> RpUserBadges { get; set; }
        public virtual DbSet<RpUserBag> RpUserBags { get; set; }
        public virtual DbSet<RpUserBagInOut> RpUserBagInOuts { get; set; }
        public virtual DbSet<RpUserFollowed> RpUserFolloweds { get; set; }
        public virtual DbSet<RpUserInfo> RpUserInfos { get; set; }
        public virtual DbSet<RpUserMeetUp> RpUserMeetUps { get; set; }
        public virtual DbSet<RpUserNotify> RpUserNotifies { get; set; }
        public virtual DbSet<RpUserTrack> RpUserTracks { get; set; }
        public virtual DbSet<RpVipUserCharge> RpVipUserCharges { get; set; }
        public virtual DbSet<RpVipUserChargeSettting> RpVipUserChargeSetttings { get; set; }
        public virtual DbSet<RpVipUserInfo> RpVipUserInfos { get; set; }
        public virtual DbSet<RpVipUserRequire> RpVipUserRequires { get; set; }
        public virtual DbSet<RpWeeklyReport> RpWeeklyReports { get; set; }
        public virtual DbSet<RpWishList> RpWishLists { get; set; }
        public virtual DbSet<RpWishProcess> RpWishProcesses { get; set; }
        public virtual DbSet<RpWithdrawApply> RpWithdrawApplies { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<SysLog> SysLogs { get; set; }
        public virtual DbSet<SysMessage> SysMessages { get; set; }
        public virtual DbSet<UploadFile> UploadFiles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WmsInboundOrderDtbl> WmsInboundOrderDtbls { get; set; }
        public virtual DbSet<WmsInboundOrderTbl> WmsInboundOrderTbls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.0.171;Database=RedPaper;User Id=sa;Password=hardman2019;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<Application>(entity =>
            {
                entity.ToTable("Application");

                entity.HasComment("应用");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("AppId");

                entity.Property(e => e.AppSecret)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("应用密钥");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建日期");

                entity.Property(e => e.CreateUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasComment("应用描述");

                entity.Property(e => e.Disable).HasComment("是否可用");

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("应用图标");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("应用名称");
            });

            modelBuilder.Entity<BuilderTable>(entity =>
            {
                entity.ToTable("BuilderTable");

                entity.HasComment("代码生成器的表信息");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasComment("编号");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("实体类名称");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .HasComment("表描述、中文名称");

                entity.Property(e => e.CreateTime)
                    .HasPrecision(0)
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(50)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人姓名");

                entity.Property(e => e.DetailComment)
                    .HasMaxLength(500)
                    .HasComment("子表描述、中文名称");

                entity.Property(e => e.DetailTableName)
                    .HasMaxLength(255)
                    .HasComment("子表英文全称");

                entity.Property(e => e.Folder)
                    .HasMaxLength(300)
                    .HasComment("代码相对文件夹路径");

                entity.Property(e => e.ModuleCode)
                    .HasMaxLength(255)
                    .HasComment("模块标识");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(300)
                    .HasComment("模块名称");

                entity.Property(e => e.Namespace)
                    .HasMaxLength(100)
                    .HasComment("命名空间");

                entity.Property(e => e.Options)
                    .HasMaxLength(1000)
                    .HasComment("其它生成选项");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("表英文全称");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(50)
                    .HasComment("分类ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .HasComment("分类名称");

                entity.Property(e => e.UpdateTime)
                    .HasPrecision(0)
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(50)
                    .HasComment("修改人ID");

                entity.Property(e => e.UpdateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("修改人姓名");
            });

            modelBuilder.Entity<BuilderTableColumn>(entity =>
            {
                entity.ToTable("BuilderTableColumn");

                entity.HasComment("代码生成器的字段信息");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("编号");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(200)
                    .HasComment("列名称");

                entity.Property(e => e.ColumnType)
                    .HasMaxLength(100)
                    .HasComment("列类型");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .HasComment("列描述");

                entity.Property(e => e.CreateTime)
                    .HasPrecision(0)
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(50)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人姓名");

                entity.Property(e => e.EditCol).HasComment("修改时的列位置");

                entity.Property(e => e.EditRow).HasComment("修改时的行位置");

                entity.Property(e => e.EditType)
                    .HasMaxLength(200)
                    .HasComment("编辑类型（文本框、文本域、下拉框、复选框、单选框、日期控件）");

                entity.Property(e => e.EntityName)
                    .HasMaxLength(200)
                    .HasComment("实体名称");

                entity.Property(e => e.EntityType)
                    .HasMaxLength(500)
                    .HasComment("实体类型");

                entity.Property(e => e.HtmlType)
                    .HasMaxLength(200)
                    .HasComment("显示类型（文本框、文本域、下拉框、复选框、单选框、日期控件）");

                entity.Property(e => e.IsEdit).HasComment("是否编辑字段");

                entity.Property(e => e.IsIncrement).HasComment("是否自增");

                entity.Property(e => e.IsInsert).HasComment("是否为插入字段");

                entity.Property(e => e.IsKey).HasComment("是否主键");

                entity.Property(e => e.IsList).HasComment("是否列表字段");

                entity.Property(e => e.IsQuery).HasComment("是否查询字段");

                entity.Property(e => e.IsRequired).HasComment("是否必填");

                entity.Property(e => e.MaxLength).HasComment("最大长度");

                entity.Property(e => e.QueryType)
                    .HasMaxLength(200)
                    .HasComment("查询方式（等于、不等于、大于、小于、范围）");

                entity.Property(e => e.Sort).HasComment("排序");

                entity.Property(e => e.TableId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("归属表编号");

                entity.Property(e => e.TableName)
                    .HasMaxLength(255)
                    .HasComment("表名称");

                entity.Property(e => e.UpdateTime)
                    .HasPrecision(0)
                    .HasComment("修改时间");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(50)
                    .HasComment("修改人ID");

                entity.Property(e => e.UpdateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("修改人姓名");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.HasComment("分类表，也可用作数据字典。表示一个全集，比如：男、女、未知。关联的分类类型表示按什么进行的分类，如：按照性别对人类对象集");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("创建人");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DtCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类标识");

                entity.Property(e => e.DtValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("通常与分类标识一致，但万一有不一样的情况呢？");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("分类名称或描述");

                entity.Property(e => e.SortNo).HasComment("排序号");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasComment("最后更新时间");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后更新人ID");

                entity.Property(e => e.UpdateUserName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("最后更新人");
            });

            modelBuilder.Entity<CategoryType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CATEGORYTYPE")
                    .IsClustered(false);

                entity.ToTable("CategoryType");

                entity.HasComment("分类类型");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类表ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("名称");
            });

            modelBuilder.Entity<DataPrivilegeRule>(entity =>
            {
                entity.ToTable("DataPrivilegeRule");

                entity.HasComment("系统授权规制表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("数据ID");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("创建人");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("权限描述");

                entity.Property(e => e.Enable).HasComment("是否可用");

                entity.Property(e => e.PrivilegeRules)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("权限规则");

                entity.Property(e => e.SortNo).HasComment("排序号");

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("资源标识（模块编号）");

                entity.Property(e => e.SubSourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("二级资源标识");

                entity.Property(e => e.UpdateTime).HasComment("最后更新时间");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后更新人ID");

                entity.Property(e => e.UpdateUserName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("最后更新人");
            });

            modelBuilder.Entity<FlowInstance>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_FLOWINSTANCE")
                    .IsClustered(false);

                entity.ToTable("FlowInstance");

                entity.HasComment("工作流流程实例表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("主键Id");

                entity.Property(e => e.ActivityId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("当前节点ID");

                entity.Property(e => e.ActivityName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("当前节点名称");

                entity.Property(e => e.ActivityType).HasComment("当前节点类型（0会签节点）");

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("实例编号");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户主键");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.CustomName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("自定义名称");

                entity.Property(e => e.DbName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("数据库名称");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("实例备注");

                entity.Property(e => e.Disabled).HasComment("有效标志");

                entity.Property(e => e.FlowLevel).HasComment("等级");

                entity.Property(e => e.FrmContentData)
                    .HasColumnType("text")
                    .HasComment("表单中的控件属性描述");

                entity.Property(e => e.FrmContentParse)
                    .HasColumnType("text")
                    .HasComment("表单控件位置模板");

                entity.Property(e => e.FrmData)
                    .HasColumnType("text")
                    .HasComment("表单数据");

                entity.Property(e => e.FrmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("表单ID");

                entity.Property(e => e.FrmType).HasComment("表单类型");

                entity.Property(e => e.InstanceSchemeId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("流程实例模板Id");

                entity.Property(e => e.IsFinish).HasComment("是否完成");

                entity.Property(e => e.MakerList)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("执行人");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("所属部门");

                entity.Property(e => e.PreviousId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("前一个ID");

                entity.Property(e => e.SchemeContent)
                    .IsUnicode(false)
                    .HasComment("流程模板内容");

                entity.Property(e => e.SchemeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("流程模板ID");

                entity.Property(e => e.SchemeType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("流程类型");
            });

            modelBuilder.Entity<FlowInstanceOperationHistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_FLOWINSTANCEOPERATIONHISTOR")
                    .IsClustered(false);

                entity.ToTable("FlowInstanceOperationHistory");

                entity.HasComment("工作流实例操作记录");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("主键Id");

                entity.Property(e => e.Content)
                    .HasMaxLength(200)
                    .HasComment("操作内容");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户主键");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.InstanceId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("实例进程Id");
            });

            modelBuilder.Entity<FlowInstanceTransitionHistory>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_FLOWINSTANCETRANSITIONHISTO")
                    .IsClustered(false);

                entity.ToTable("FlowInstanceTransitionHistory");

                entity.HasComment("工作流实例流转历史记录");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("主键Id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("转化时间");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("操作人Id");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("操作人名称");

                entity.Property(e => e.FromNodeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("开始节点Id");

                entity.Property(e => e.FromNodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("开始节点名称");

                entity.Property(e => e.FromNodeType).HasComment("开始节点类型");

                entity.Property(e => e.InstanceId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("实例Id");

                entity.Property(e => e.IsFinish).HasComment("是否结束");

                entity.Property(e => e.ToNodeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("结束节点Id");

                entity.Property(e => e.ToNodeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("结束节点名称");

                entity.Property(e => e.ToNodeType).HasComment("结束节点类型");

                entity.Property(e => e.TransitionSate).HasComment("转化状态");
            });

            modelBuilder.Entity<FlowScheme>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_FLOWSCHEME")
                    .IsClustered(false);

                entity.ToTable("FlowScheme");

                entity.HasComment("工作流模板信息表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("主键Id");

                entity.Property(e => e.AuthorizeType).HasComment("模板权限类型：0完全公开,1指定部门/人员");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户主键");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.DeleteMark).HasComment("删除标记");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("备注");

                entity.Property(e => e.Disabled).HasComment("有效");

                entity.Property(e => e.FrmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("表单ID");

                entity.Property(e => e.FrmType).HasComment("表单类型");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.ModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("修改用户主键");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("修改用户");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("所属部门");

                entity.Property(e => e.SchemeCanUser)
                    .IsUnicode(false)
                    .HasComment("流程模板使用者");

                entity.Property(e => e.SchemeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("流程编号");

                entity.Property(e => e.SchemeContent)
                    .IsUnicode(false)
                    .HasComment("流程内容");

                entity.Property(e => e.SchemeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("流程名称");

                entity.Property(e => e.SchemeType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("流程分类");

                entity.Property(e => e.SchemeVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("流程内容版本");

                entity.Property(e => e.SortCode).HasComment("排序码");
            });

            modelBuilder.Entity<Form>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_FORM")
                    .IsClustered(false);

                entity.ToTable("Form");

                entity.HasComment("表单模板表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("表单模板Id");

                entity.Property(e => e.Content)
                    .HasColumnType("text")
                    .HasComment("表单原html模板未经处理的");

                entity.Property(e => e.ContentData)
                    .HasColumnType("text")
                    .HasComment("表单中的控件属性描述");

                entity.Property(e => e.ContentParse)
                    .HasColumnType("text")
                    .HasComment("表单控件位置模板");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户主键");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.DbName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("数据库名称");

                entity.Property(e => e.DeleteMark).HasComment("删除标记");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasComment("备注");

                entity.Property(e => e.Disabled).HasComment("有效");

                entity.Property(e => e.Fields).HasComment("字段个数");

                entity.Property(e => e.FrmType).HasComment("表单类型，0：默认动态表单；1：Web自定义表单");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasComment("修改时间");

                entity.Property(e => e.ModifyUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("修改用户主键");

                entity.Property(e => e.ModifyUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("修改用户");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("表单名称");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("所属部门");

                entity.Property(e => e.SortCode).HasComment("排序码");

                entity.Property(e => e.WebId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("系统页面标识，当表单类型为用Web自定义的表单时，需要标识加载哪个页面");
            });

            modelBuilder.Entity<FrmLeaveReq>(entity =>
            {
                entity.ToTable("FrmLeaveReq");

                entity.HasComment("模拟一个自定页面的表单，该数据会关联到流程实例FrmData，可用于复杂页面的设计及后期的数据分析");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("ID");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("附件，用于提交病假证据等");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户主键");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建用户");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasComment("结束日期");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasComment("结束时间");

                entity.Property(e => e.FlowInstanceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("所属流程实例");

                entity.Property(e => e.RequestComment)
                    .HasMaxLength(500)
                    .HasComment("请假说明");

                entity.Property(e => e.RequestType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasComment("请假分类，病假，事假，公休等");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasComment("开始日期");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasComment("开始时间");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasComment("请假人姓名");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module");

                entity.HasComment("功能模块表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("功能模块流水号");

                entity.Property(e => e.CascadeId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("节点语义ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HotKey)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("热键");

                entity.Property(e => e.IconName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("节点图标文件名称");

                entity.Property(e => e.IsAutoExpand).HasComment("是否自动展开");

                entity.Property(e => e.IsLeaf)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否叶子节点");

                entity.Property(e => e.IsSys).HasComment("是否为系统模块");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("功能模块名称");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("父节点流水号");

                entity.Property(e => e.ParentName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("父节点名称");

                entity.Property(e => e.SortNo).HasComment("排序号");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("当前状态");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("主页面URL");

                entity.Property(e => e.Vector)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("矢量图标");
            });

            modelBuilder.Entity<ModuleElement>(entity =>
            {
                entity.ToTable("ModuleElement");

                entity.HasComment("模块元素表(需要权限控制的按钮)");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("流水号");

                entity.Property(e => e.Attr)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("元素附加属性");

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("元素样式");

                entity.Property(e => e.DomId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("DOM ID");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("元素图标");

                entity.Property(e => e.ModuleId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("功能模块Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("名称");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("备注");

                entity.Property(e => e.Script)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("元素调用脚本");

                entity.Property(e => e.Sort).HasComment("排序字段");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .HasComment("分类名称");
            });

            modelBuilder.Entity<OpenJob>(entity =>
            {
                entity.ToTable("OpenJob");

                entity.HasComment("定时任务");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("创建人");

                entity.Property(e => e.Cron)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("CRON表达式");

                entity.Property(e => e.ErrorCount).HasComment("异常次数");

                entity.Property(e => e.JobCall)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("任务地址");

                entity.Property(e => e.JobCallParams)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("任务参数，JSON格式");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("任务名称");

                entity.Property(e => e.JobType).HasComment("任务执行方式0：本地任务；1：外部接口任务");

                entity.Property(e => e.LastErrorTime)
                    .HasColumnType("datetime")
                    .HasComment("最后一次失败时间");

                entity.Property(e => e.LastRunTime)
                    .HasColumnType("datetime")
                    .HasComment("最后一次执行时间");

                entity.Property(e => e.NextRunTime)
                    .HasColumnType("datetime")
                    .HasComment("下次执行时间");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("所属部门");

                entity.Property(e => e.Remark)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasComment("备注");

                entity.Property(e => e.RunCount).HasComment("任务执行次数");

                entity.Property(e => e.Status).HasComment("任务运行状态（0：停止，1：正在运行，2：暂停）");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasComment("最后更新时间");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后更新人ID");

                entity.Property(e => e.UpdateUserName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("最后更新人");
            });

            modelBuilder.Entity<Org>(entity =>
            {
                entity.ToTable("Org");

                entity.HasComment("组织表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("流水号");

                entity.Property(e => e.BizCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("业务对照码");

                entity.Property(e => e.CascadeId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("节点语义ID");

                entity.Property(e => e.CreateId).HasComment("创建人ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.CustomCode)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("自定义扩展码");

                entity.Property(e => e.HotKey)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("热键");

                entity.Property(e => e.IconName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("节点图标文件名称");

                entity.Property(e => e.IsAutoExpand).HasComment("是否自动展开");

                entity.Property(e => e.IsLeaf)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否叶子节点");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("组织名称");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("父节点流水号");

                entity.Property(e => e.ParentName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("父节点名称");

                entity.Property(e => e.SortNo).HasComment("排序号");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("当前状态");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .HasComment("分类名称");
            });

            modelBuilder.Entity<Relevance>(entity =>
            {
                entity.ToTable("Relevance");

                entity.HasComment("多对多关系集中映射");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("流水号");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("描述");

                entity.Property(e => e.ExtendInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("扩展信息");

                entity.Property(e => e.FirstId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("第一个表主键ID");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("映射标识");

                entity.Property(e => e.OperateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("授权时间");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("授权人");

                entity.Property(e => e.SecondId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("第二个表主键ID");

                entity.Property(e => e.Status).HasComment("状态");

                entity.Property(e => e.ThirdId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("第三个表主键ID");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.ToTable("Resource");

                entity.HasComment("资源表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("资源标识");

                entity.Property(e => e.AppId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("资源所属应用ID");

                entity.Property(e => e.AppName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("所属应用名称");

                entity.Property(e => e.CascadeId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("节点语义ID");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("创建人");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("描述");

                entity.Property(e => e.Disable).HasComment("是否可用");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasComment("名称");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("父节点流ID");

                entity.Property(e => e.ParentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("父节点名称");

                entity.Property(e => e.SortNo).HasComment("排序号");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("分类名称");

                entity.Property(e => e.UpdateTime).HasComment("最后更新时间");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后更新人ID");

                entity.Property(e => e.UpdateUserName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("最后更新人");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.HasComment("角色表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Id");

                entity.Property(e => e.CreateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("角色名称");

                entity.Property(e => e.Status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("当前状态");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .HasComment("分类名称");
            });

            modelBuilder.Entity<RpAccountChanging>(entity =>
            {
                entity.HasKey(e => e.ChangingId);

                entity.ToTable("rpAccountChanging");

                entity.HasComment("账变记录");

                entity.Property(e => e.ChangingId)
                    .ValueGeneratedNever()
                    .HasColumnName("changingId");

                entity.Property(e => e.ChangeType)
                    .HasColumnName("changeType")
                    .HasComment("变动类型： 0，购买金币\r\n           1，购买礼物\r\n           2，提现");

                entity.Property(e => e.CoinsAfter)
                    .HasColumnName("coinsAfter")
                    .HasComment("变动后数量");

                entity.Property(e => e.CoinsBefore).HasColumnName("coinsBefore");

                entity.Property(e => e.CoinsChanged)
                    .HasColumnName("coinsChanged")
                    .HasComment("变动金币数量");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userName");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpAccountChangings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpAccountChanging_rpUserInfo");
            });

            modelBuilder.Entity<RpBadge>(entity =>
            {
                entity.HasKey(e => e.BadgeId);

                entity.ToTable("rpBadge");

                entity.HasComment("勋章");

                entity.Property(e => e.BadgeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("badgeId");

                entity.Property(e => e.BadgeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("badgeCode")
                    .HasComment("勋章编码");

                entity.Property(e => e.BadgeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("badgeName")
                    .HasComment("勋章名称");

                entity.Property(e => e.BadgePic)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("badgePic")
                    .HasComment("勋章图片");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate");
            });

            modelBuilder.Entity<RpChatOfflineMsg>(entity =>
            {
                entity.HasKey(e => e.MsgId);

                entity.ToTable("rpChatOfflineMsg");

                entity.HasComment("离线消息");

                entity.HasIndex(e => e.UserId, "IXFK_rpChatOfflineMsg_rpUserInfo");

                entity.Property(e => e.MsgId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("msgId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.ExpireTime)
                    .HasColumnType("datetime")
                    .HasColumnName("expireTime")
                    .HasComment("离线消息过期时间：超过过期时间系统将删除离线信息");

                entity.Property(e => e.FriendId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("friendId");

                entity.Property(e => e.MsgContent)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("msgContent");

                entity.Property(e => e.MsgContentType)
                    .HasColumnName("msgContentType")
                    .HasComment("信息类型：1-文字 2-图片 3-音频 4-视频 ");

                entity.Property(e => e.MsgType)
                    .HasColumnName("msgType")
                    .HasComment("消息类型");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sessionId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpChatOfflineMsgs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpChatOfflineMsg_rpUserInfo");
            });

            modelBuilder.Entity<RpChatReadFlag>(entity =>
            {
                entity.HasKey(e => e.FlagId);

                entity.ToTable("rpChatReadFlag");

                entity.HasComment("聊天消息已读");

                entity.Property(e => e.FlagId).HasColumnName("flagId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.MsgId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("msgId");

                entity.Property(e => e.SenderId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("senderId");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sessionId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpChatReadFlags)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpChatReadFlag_rpUserInfo");
            });

            modelBuilder.Entity<RpChatUnlock>(entity =>
            {
                entity.HasKey(e => e.LockId);

                entity.ToTable("rpChatUnlock");

                entity.HasComment("聊天解锁");

                entity.HasIndex(e => e.UserId, "IXFK_rpChatUnlock_rpUserInfo");

                entity.Property(e => e.LockId).HasColumnName("lockId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("解锁时间");

                entity.Property(e => e.FriendId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("friendId")
                    .HasComment("聊友id");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .HasColumnName("memo")
                    .HasComment("备注");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpChatUnlocks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpChatUnlock_rpUserInfo");
            });

            modelBuilder.Entity<RpCoinCharge>(entity =>
            {
                entity.HasKey(e => e.ChargeId);

                entity.ToTable("rpCoinCharge");

                entity.HasComment("金币充值");

                entity.Property(e => e.ChargeId).HasColumnName("chargeId");

                entity.Property(e => e.CoinCount).HasColumnName("coinCount");

                entity.Property(e => e.CostMoney)
                    .HasColumnType("money")
                    .HasColumnName("costMoney")
                    .HasComment("花费金额（人民币）");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .HasColumnName("memo")
                    .HasComment("备注");

                entity.Property(e => e.SellCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sellCode");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpCoinCharges)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpCoinCharge_rpUserInfo");
            });

            modelBuilder.Entity<RpCoinsSell>(entity =>
            {
                entity.HasKey(e => e.SellCode)
                    .HasName("PK_rpCoinChargeInfo");

                entity.ToTable("rpCoinsSell");

                entity.HasComment("金币售卖信息");

                entity.Property(e => e.SellCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sellCode");

                entity.Property(e => e.CoinCount)
                    .HasColumnName("coinCount")
                    .HasComment("金币数量");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("最后更新");

                entity.Property(e => e.ListOrder).HasColumnName("listOrder");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .HasColumnName("memo")
                    .HasComment("折扣备注");

                entity.Property(e => e.OnSale)
                    .HasColumnName("onSale")
                    .HasComment("是否折扣 值为true时，前端app会显示折扣信息（memo)");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasColumnName("price")
                    .HasComment("售价");
            });

            modelBuilder.Entity<RpCommentLiked>(entity =>
            {
                entity.HasKey(e => e.LikeId);

                entity.ToTable("rpCommentLiked");

                entity.HasComment("评论点赞");

                entity.Property(e => e.LikeId).HasColumnName("likeId");

                entity.Property(e => e.CommentId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("commentId");

                entity.Property(e => e.LikedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("likedTime");

                entity.Property(e => e.LikedUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("likedUserId");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.RpCommentLikeds)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("FK_rpCommentLiked_rpMomentComments");
            });

            modelBuilder.Entity<RpExpAcquireSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId)
                    .HasName("PK_rpExperienceAcquisitionSetting");

                entity.ToTable("rpExpAcquireSetting");

                entity.HasComment("经验值获取配置");

                entity.Property(e => e.SettingId).HasColumnName("settingId");

                entity.Property(e => e.ActionType)
                    .HasColumnName("actionType")
                    .HasComment("操作类型：\r\n1-发布动态\r\n2-发布愿望\r\n3-每日登录\r\n4-邀请注册\r\n5-每日分享\r\n6-礼物打赏");

                entity.Property(e => e.ExpValue)
                    .HasColumnName("expValue")
                    .HasComment("经验值");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("更新时间");

                entity.Property(e => e.LimitNum)
                    .HasColumnName("limitNum")
                    .HasComment("素人每天限制次数");

                entity.Property(e => e.VipExpValue)
                    .HasColumnName("vipExpValue")
                    .HasComment("达人获取经验值");

                entity.Property(e => e.VipLimitNum)
                    .HasColumnName("vipLimitNum")
                    .HasComment("达人每天限制次数");
            });

            modelBuilder.Entity<RpExpSignAcquireSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("rpExpSignAcquireSetting");

                entity.HasComment("用户签到经验值设置");

                entity.Property(e => e.SettingId).HasColumnName("settingId");

                entity.Property(e => e.DayNum)
                    .HasColumnName("dayNum")
                    .HasComment("签到天数");

                entity.Property(e => e.ExpValue)
                    .HasColumnName("expValue")
                    .HasComment("经验值");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("更新时间");

                entity.Property(e => e.VipMultipe)
                    .HasColumnName("vipMultipe")
                    .HasDefaultValueSql("((1))")
                    .HasComment("vip获取经验倍数");
            });

            modelBuilder.Entity<RpGoodsSell>(entity =>
            {
                entity.HasKey(e => e.GoodsCode);

                entity.ToTable("rpGoodsSell");

                entity.HasComment("商品售卖信息");

                entity.Property(e => e.GoodsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("goodsCode");

                entity.Property(e => e.CoinCount)
                    .HasColumnName("coinCount")
                    .HasComment("价格");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("goodsName")
                    .HasComment("商品名称");

                entity.Property(e => e.GoodsPic)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("goodsPic")
                    .HasComment("商品图片");

                entity.Property(e => e.GoodsType)
                    .HasColumnName("goodsType")
                    .HasComment("商品种类 ： 0,道具 1,礼物");

                entity.Property(e => e.ListOrder).HasColumnName("listOrder");

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("memo")
                    .HasComment("备注");

                entity.Property(e => e.OnSale)
                    .HasColumnName("onSale")
                    .HasComment("是否折扣销售");
            });

            modelBuilder.Entity<RpGoodsShopping>(entity =>
            {
                entity.HasKey(e => e.ShoppingId);

                entity.ToTable("rpGoodsShopping");

                entity.HasComment("商品购买");

                entity.Property(e => e.ShoppingId)
                    .ValueGeneratedNever()
                    .HasColumnName("shoppingId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("购买时间");

                entity.Property(e => e.GoodsCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("goodsCode")
                    .HasComment("商品编码");

                entity.Property(e => e.GoodsCount)
                    .HasColumnName("goodsCount")
                    .HasDefaultValueSql("((1))")
                    .HasComment("购买数量");

                entity.Property(e => e.GoodsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("goodsName");

                entity.Property(e => e.GoodsPrice)
                    .HasColumnName("goodsPrice")
                    .HasComment("商品价格（金币价格）");

                entity.Property(e => e.GoodsType)
                    .HasColumnName("goodsType")
                    .HasComment("商品类型");

                entity.Property(e => e.OrderCoins)
                    .HasColumnName("orderCoins")
                    .HasComment("订单总金币数");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpGoodsShoppings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpGoodsShopping_rpUserInfo");
            });

            modelBuilder.Entity<RpGrowthBadge>(entity =>
            {
                entity.HasKey(e => e.BadgeId);

                entity.ToTable("rpGrowthBadge");

                entity.HasComment("授勋记录");

                entity.Property(e => e.BadgeId).HasColumnName("badgeId");

                entity.Property(e => e.BadegCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("badegCode")
                    .HasComment("勋章编码");

                entity.Property(e => e.BadgeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("badgeName")
                    .HasComment("勋章名称");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("升级时间");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .HasColumnName("memo")
                    .HasComment("备注");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userName")
                    .HasComment("用户名称");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpGrowthBadges)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpGrowthBadge_rpUserInfo");
            });

            modelBuilder.Entity<RpGrowthCoinConvert>(entity =>
            {
                entity.HasKey(e => e.ConvertId)
                    .HasName("PK_rpGrowthCoinConverted");

                entity.ToTable("rpGrowthCoinConvert");

                entity.HasComment("金币转化记录");

                entity.Property(e => e.ConvertId).HasColumnName("convertId");

                entity.Property(e => e.ConvertExperience).HasColumnName("convertExperience");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.CreatedCoins).HasColumnName("createdCoins");

                entity.Property(e => e.LeftExperience)
                    .HasColumnName("leftExperience")
                    .HasComment("未转换经验值= 新增经验值-转化的经验值");

                entity.Property(e => e.Memo)
                    .HasColumnType("datetime")
                    .HasColumnName("memo")
                    .HasComment("备注");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userName");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpGrowthCoinConverts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpGrowthCoinConverted_rpUserInfo");
            });

            modelBuilder.Entity<RpGrowthExperience>(entity =>
            {
                entity.HasKey(e => e.ExpId)
                    .HasName("PK_Table1");

                entity.ToTable("rpGrowthExperience");

                entity.HasComment("用户经验值");

                entity.Property(e => e.ExpId).HasColumnName("expId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.ExpGrowth).HasColumnName("expGrowth");

                entity.Property(e => e.GrowthAction)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("growthAction")
                    .HasComment("增长行为");

                entity.Property(e => e.GrowthType)
                    .HasColumnName("growthType")
                    .HasComment("增长类型 : 0,评论\r\n           1，点赞\r\n           2，礼物\r\n           3，转发\r\n           4，签到");

                entity.Property(e => e.Memo)
                    .HasMaxLength(100)
                    .HasColumnName("memo")
                    .HasComment("备注");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userName");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpGrowthExperiences)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpUserExperience_rpUserInfo");
            });

            modelBuilder.Entity<RpGrowthUpgrade>(entity =>
            {
                entity.HasKey(e => e.UpgradeId);

                entity.ToTable("rpGrowthUpgrade");

                entity.HasComment("用户升级");

                entity.Property(e => e.UpgradeId).HasColumnName("upgradeId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("升级时间");

                entity.Property(e => e.FromLevel)
                    .HasColumnName("fromLevel")
                    .HasComment("升级前的级别");

                entity.Property(e => e.Memo)
                    .HasMaxLength(50)
                    .HasColumnName("memo")
                    .HasComment("备注");

                entity.Property(e => e.ToLevel)
                    .HasColumnName("toLevel")
                    .HasComment("升级后的级别");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userName")
                    .HasComment("用户名");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpGrowthUpgrades)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpGrowthUpgrade_rpUserInfo");
            });

            modelBuilder.Entity<RpLevelExpSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("rpLevelExpSetting");

                entity.HasComment("等级经验配置");

                entity.Property(e => e.SettingId).HasColumnName("settingId");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("创建时间");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasComment("等级");

                entity.Property(e => e.ThreadholdExp)
                    .HasColumnName("threadholdExp")
                    .HasComment("门限经验值");
            });

            modelBuilder.Entity<RpMeetReport>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("rpMeetReport");

                entity.HasComment("用户相遇报告");

                entity.Property(e => e.ReportId).HasColumnName("reportId");

                entity.Property(e => e.ArriveCount)
                    .HasColumnName("arriveCount")
                    .HasComment("到达次数");

                entity.Property(e => e.BeginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("beginTime")
                    .HasComment("统计数据开始时间");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city")
                    .HasComment("城市");

                entity.Property(e => e.Counry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("counry")
                    .HasComment("国家");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("district")
                    .HasComment("区县");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("endTime")
                    .HasComment("统计数据截止时间");

                entity.Property(e => e.MetPersonCount)
                    .HasColumnName("metPersonCount")
                    .HasComment("相遇的人数");

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("province")
                    .HasComment("省");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("street")
                    .HasComment("街道");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户id");
            });

            modelBuilder.Entity<RpMomentComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("rpMomentComments");

                entity.HasComment("动态评论");

                entity.Property(e => e.CommentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("commentId");

                entity.Property(e => e.CommentText)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("commentText")
                    .HasComment("评论内容");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.LikedCount).HasColumnName("likedCount");

                entity.Property(e => e.MomentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("momentId");

                entity.Property(e => e.UserAvatar)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userAvatar");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("评论人id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userName")
                    .HasComment("评论人名称");

                entity.HasOne(d => d.Moment)
                    .WithMany(p => p.RpMomentComments)
                    .HasForeignKey(d => d.MomentId)
                    .HasConstraintName("FK_rpMomentComments_rpMomentInfo");
            });

            modelBuilder.Entity<RpMomentGift>(entity =>
            {
                entity.HasKey(e => e.GiftId);

                entity.ToTable("rpMomentGifts");

                entity.HasComment("动态礼物");

                entity.Property(e => e.GiftId).HasColumnName("giftId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.DonorAvatar)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("donorAvatar")
                    .HasComment("赠送人头像");

                entity.Property(e => e.DonorId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("donorId")
                    .HasComment("赠送人id");

                entity.Property(e => e.DonorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("donorName")
                    .HasComment("赠送人名称");

                entity.Property(e => e.GiftCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("giftCode")
                    .HasComment("礼物编码");

                entity.Property(e => e.GiftName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("giftName");

                entity.Property(e => e.GiftPic)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("giftPic")
                    .HasComment("礼物图片");

                entity.Property(e => e.GiftPrice)
                    .HasColumnName("giftPrice")
                    .HasComment("礼物价格（金币价格）");

                entity.Property(e => e.MomentId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("momentId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.Moment)
                    .WithMany(p => p.RpMomentGifts)
                    .HasForeignKey(d => d.MomentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpMomentGifts_rpMomentInfo");
            });

            modelBuilder.Entity<RpMomentInfo>(entity =>
            {
                entity.HasKey(e => e.MomentId)
                    .HasName("PK_rpUserMoments");

                entity.ToTable("rpMomentInfo");

                entity.HasComment("用户瞬间");

                entity.Property(e => e.MomentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("momentId");

                entity.Property(e => e.AtUserIds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("atUserIds")
                    .HasComment("@的用户编号（多个 以半角英文逗号隔开）");

                entity.Property(e => e.AtWishId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("atWishId")
                    .HasComment("关联的愿望Id");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city")
                    .HasComment("所在城市");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("content")
                    .HasComment("动态内容");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("发布时间");

                entity.Property(e => e.GiftCount)
                    .HasColumnName("giftCount")
                    .HasComment("得到礼物数量");

                entity.Property(e => e.GpsInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gpsInfo")
                    .HasComment("Gps信息：记录经纬度，格式：1231.0098,2342.123");

                entity.Property(e => e.HasAttath)
                    .HasColumnName("hasAttath")
                    .HasComment("是否有附件 为true 需要在媒体库中查找相关的媒体文件");

                entity.Property(e => e.IsAnonymous)
                    .HasColumnName("isAnonymous")
                    .HasComment("是否匿名发布");

                entity.Property(e => e.IsFree).HasColumnName("isFree");

                entity.Property(e => e.IsVipMoment)
                    .HasColumnName("isVipMoment")
                    .HasComment("是否vip动态 ：vip动态在app端将用特色效果显示");

                entity.Property(e => e.LikeCount)
                    .HasColumnName("likeCount")
                    .HasComment("点赞数量");

                entity.Property(e => e.MomentType)
                    .HasColumnName("momentType")
                    .HasComment("动态类型 ：0，图文\r\n           1，声音\r\n           2，视频");

                entity.Property(e => e.OnTop)
                    .HasColumnName("onTop")
                    .HasComment("是否置顶");

                entity.Property(e => e.Scope)
                    .HasColumnName("scope")
                    .HasComment("动态可见范围 \r\n所有人可见-0\r\n仅好友可见-1\r\n仅自己可见-2\r\n管理删除 -3 不对用户开放此选项");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.Property(e => e.UserLocation)
                    .HasMaxLength(50)
                    .HasColumnName("userLocation")
                    .HasComment("用户位置信息");

                entity.Property(e => e.VisitCount)
                    .HasColumnName("visitCount")
                    .HasComment("浏览次数");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpMomentInfos)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpMomentInfo_rpUserInfo");
            });

            modelBuilder.Entity<RpMomentLiked>(entity =>
            {
                entity.HasKey(e => e.LikeId);

                entity.ToTable("rpMomentLiked");

                entity.HasComment("动态点赞信息");

                entity.Property(e => e.LikeId).HasColumnName("likeId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.LikeUserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("likeUserName")
                    .HasComment("点赞人名称");

                entity.Property(e => e.LikedAvatar)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("likedAvatar")
                    .HasComment("点赞人头像");

                entity.Property(e => e.LikedUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("likedUserId")
                    .HasComment("点赞人");

                entity.Property(e => e.MomentId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("momentId");

                entity.HasOne(d => d.Moment)
                    .WithMany(p => p.RpMomentLikeds)
                    .HasForeignKey(d => d.MomentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpMomentLiked_rpMomentInfo");
            });

            modelBuilder.Entity<RpMomentShare>(entity =>
            {
                entity.HasKey(e => e.ShareId);

                entity.ToTable("rpMomentShare");

                entity.HasComment("动态分享");

                entity.Property(e => e.ShareId).HasColumnName("shareId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("分享时间");

                entity.Property(e => e.MomentId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("momentId");

                entity.Property(e => e.ShareType)
                    .HasColumnName("shareType")
                    .HasComment("分享类型 1，微信\r\n         2，朋友圈\r\n         3，平台内部\r\n         4，QQ\r\n         5，QQ空间\r\n         6，微博\r\n       ");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("分享人id");

                entity.HasOne(d => d.Moment)
                    .WithMany(p => p.RpMomentShares)
                    .HasForeignKey(d => d.MomentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpMomentShare_rpMomentInfo");
            });

            modelBuilder.Entity<RpOrdinaryUserAwardGood>(entity =>
            {
                entity.ToTable("rpOrdinaryUserAwardGoods");

                entity.HasComment("素人奖励商品");

                entity.HasIndex(e => e.OrdinaryUserAwardSettingId, "IXFK_rpOrdinaryUserAwardGoods_rpOrdinaryUserAwardSetting");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .HasComment("商品数量");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.GoodsCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("goodsCode")
                    .HasComment("商品编号");

                entity.Property(e => e.OrdinaryUserAwardSettingId).HasColumnName("ordinaryUserAwardSettingId");

                entity.HasOne(d => d.OrdinaryUserAwardSetting)
                    .WithMany(p => p.RpOrdinaryUserAwardGoods)
                    .HasForeignKey(d => d.OrdinaryUserAwardSettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpOrdinaryUserAwardGoods_rpOrdinaryUserAwardSetting");
            });

            modelBuilder.Entity<RpOrdinaryUserAwardSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("rpOrdinaryUserAwardSetting");

                entity.HasComment("素人奖励配置");

                entity.Property(e => e.SettingId).HasColumnName("settingId");

                entity.Property(e => e.ChatFreeCountPerWeek)
                    .HasColumnName("chatFreeCountPerWeek")
                    .HasComment("每周免费私聊次数");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("更新时间");

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasComment("等级");

                entity.Property(e => e.MomentFreeCountPerWeek)
                    .HasColumnName("momentFreeCountPerWeek")
                    .HasComment("每周发布动态免费次数");
            });

            modelBuilder.Entity<RpPubMedium>(entity =>
            {
                entity.HasKey(e => e.MediaId)
                    .HasName("PK_rpMomentAttachments");

                entity.ToTable("rpPubMedia");

                entity.HasComment("发布的媒体文件");

                entity.Property(e => e.MediaId).HasColumnName("mediaId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.MediaType)
                    .HasColumnName("mediaType")
                    .HasComment("附件类型 ： 0，图片\r\n            1，声音\r\n            2，视频\r\n            3，红笺卡片");

                entity.Property(e => e.MediaUrl)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mediaUrl")
                    .HasComment("附件地址");

                entity.Property(e => e.TopicId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("topicId")
                    .HasComment("主题id ");

                entity.Property(e => e.TopicType)
                    .HasColumnName("topicType")
                    .HasComment("主题类型： 0，动态   topicId 为动态表主键\r\n           1，愿望   topicId 为愿望表主键\r\n           2，聊天信息");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户Id");
            });

            modelBuilder.Entity<RpRank>(entity =>
            {
                entity.HasKey(e => e.RankId);

                entity.ToTable("rpRank");

                entity.HasComment("用户排行榜");

                entity.Property(e => e.RankId).HasColumnName("rankId");

                entity.Property(e => e.AvatarUrl)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("avatarUrl")
                    .HasComment("用户头像");

                entity.Property(e => e.BeginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("beginTime")
                    .HasComment("统计数据开始时间");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("endTime")
                    .HasComment("统计数据截止时间");

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nickName")
                    .HasComment("用户昵称");

                entity.Property(e => e.RankNum)
                    .HasColumnName("rankNum")
                    .HasComment("排名");

                entity.Property(e => e.RankType)
                    .HasColumnName("rankType")
                    .HasComment("排行榜分类： 0-愿望榜 1-达人榜");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户id");
            });

            modelBuilder.Entity<RpShareRecord>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("rpShareRecord");

                entity.HasComment("分享记录");

                entity.HasIndex(e => e.UserId, "IXFK_rpShareRecord_rpUserInfo");

                entity.Property(e => e.RecordId).HasColumnName("recordId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.ShareType)
                    .HasColumnName("shareType")
                    .HasComment("分享类型：1-微信好友，2-微信朋友圈，3-红笺App");

                entity.Property(e => e.TopicId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("topicId")
                    .HasComment("主题id");

                entity.Property(e => e.TopicType)
                    .HasColumnName("topicType")
                    .HasComment("主题类型：1-动态 2-愿望 3-周报 4-好友邀请");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpShareRecords)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpShareRecord_rpUserInfo");
            });

            modelBuilder.Entity<RpSigninRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rpSigninRecord");

                entity.Property(e => e.RecordId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("recordId");

                entity.Property(e => e.SignNum).HasColumnName("signNum");

                entity.Property(e => e.SignTime)
                    .HasColumnType("datetime")
                    .HasColumnName("signTime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpSigninRecord_rpUserInfo");
            });

            modelBuilder.Entity<RpStuffsInBag>(entity =>
            {
                entity.HasKey(e => e.StuffId)
                    .HasName("PK_rpStuffInBag");

                entity.ToTable("rpStuffsInBag");

                entity.HasComment("背包内容");

                entity.Property(e => e.StuffId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stuffId");

                entity.Property(e => e.BagId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bagId")
                    .HasComment("背包id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("获取时间");

                entity.Property(e => e.FromType)
                    .HasColumnName("fromType")
                    .HasComment("物品来源途径 0：购买\r\n             1：其它用户赠送");

                entity.Property(e => e.FromUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fromUserId")
                    .HasComment("来源用户id");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .HasColumnName("memo")
                    .HasComment("备注信息");

                entity.Property(e => e.StuffCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stuffCode");

                entity.Property(e => e.StuffName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("stuffName")
                    .HasComment("物品名称");

                entity.Property(e => e.StuffType)
                    .HasColumnName("stuffType")
                    .HasComment("物品种类 0：道具\r\n         1：礼物");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户Id");

                entity.HasOne(d => d.Bag)
                    .WithMany(p => p.RpStuffsInBags)
                    .HasForeignKey(d => d.BagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpStuffInBag_rpUserBags");
            });

            modelBuilder.Entity<RpSystemSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("rpSystemSetting");

                entity.Property(e => e.SettingId).HasColumnName("settingId");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("key");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<RpTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("rpTag");

                entity.HasComment("标签");

                entity.Property(e => e.TagId).HasColumnName("tagId");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("更新时间");

                entity.Property(e => e.TagText)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("tagText")
                    .HasComment("标签文本");

                entity.Property(e => e.TagType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("tagType");
            });

            modelBuilder.Entity<RpUserAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("rpUserAccount");

                entity.HasComment("用户账户表");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accountId");

                entity.Property(e => e.AmountCoins)
                    .HasColumnName("amountCoins")
                    .HasComment("累计金币数量 ：用户充值总的金币数量");

                entity.Property(e => e.AmountExperience).HasColumnName("amountExperience");

                entity.Property(e => e.ConvertExperience).HasColumnName("convertExperience");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.CurrCoins)
                    .HasColumnName("currCoins")
                    .HasComment("金币数量：当前用户可用的金币数量");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("更新时间");

                entity.Property(e => e.NewExperience)
                    .HasColumnName("newExperience")
                    .HasComment("新增长经验值：未转化金币的经验值");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.Property(e => e.UserLevel)
                    .HasColumnName("userLevel")
                    .HasComment("用户等级");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpUserAccounts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpUserAccount_rpUserInfo");
            });

            modelBuilder.Entity<RpUserBadge>(entity =>
            {
                entity.HasKey(e => e.UserBadgeId);

                entity.ToTable("rpUserBadges");

                entity.HasComment("用户成就勋章");

                entity.Property(e => e.UserBadgeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userBadgeId");

                entity.Property(e => e.BadgeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("badgeCode")
                    .HasComment("勋章编码");

                entity.Property(e => e.BadgeId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("badgeId");

                entity.Property(e => e.BadgeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("badgeName")
                    .HasComment("勋章名称");

                entity.Property(e => e.BadgePic)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("badgePic");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("授勋时间");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpUserBadges)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpUserBadges_rpUserInfo");
            });

            modelBuilder.Entity<RpUserBag>(entity =>
            {
                entity.HasKey(e => e.BagId)
                    .HasName("PK_rpUserBags");

                entity.ToTable("rpUserBag");

                entity.HasComment("用户背包");

                entity.Property(e => e.BagId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bagId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.GiftCount)
                    .HasColumnName("giftCount")
                    .HasComment("礼物数量");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("更新时间");

                entity.Property(e => e.PropCount)
                    .HasColumnName("propCount")
                    .HasComment("道具数量");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpUserBags)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpUserBags_rpUserInfo");
            });

            modelBuilder.Entity<RpUserBagInOut>(entity =>
            {
                entity.HasKey(e => e.AcctionId)
                    .HasName("PK_rpStuffInOutBag");

                entity.ToTable("rpUserBagInOut");

                entity.HasComment("背包存取记录");

                entity.Property(e => e.AcctionId).HasColumnName("acctionId");

                entity.Property(e => e.AboutUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("aboutUserId")
                    .HasComment("相关的用户Id");

                entity.Property(e => e.ActionType)
                    .HasColumnName("actionType")
                    .HasComment("存取行为 ：0，存入\r\n           1，取出");

                entity.Property(e => e.BagId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bagId");

                entity.Property(e => e.BehaviorType)
                    .HasColumnName("behaviorType")
                    .HasComment("操作行为 ：0-打赏，1-赠送，2-提现，3-使用");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("获取时间");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .HasColumnName("memo")
                    .HasComment("备注信息");

                entity.Property(e => e.StuffCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stuffCode");

                entity.Property(e => e.StuffName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("stuffName")
                    .HasComment("物品名称");

                entity.Property(e => e.StuffType)
                    .HasColumnName("stuffType")
                    .HasComment("物品种类 0：道具\r\n         1：礼物");

                entity.Property(e => e.StuffValue)
                    .HasColumnName("stuffValue")
                    .HasComment("物品金币价值");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户Id");

                entity.HasOne(d => d.Bag)
                    .WithMany(p => p.RpUserBagInOuts)
                    .HasForeignKey(d => d.BagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpUserBagInOut_rpUserBags");
            });

            modelBuilder.Entity<RpUserFollowed>(entity =>
            {
                entity.HasKey(e => e.FollowId);

                entity.ToTable("rpUserFollowed");

                entity.HasComment("用户的关注");

                entity.Property(e => e.FollowId).HasColumnName("followId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("关注时间");

                entity.Property(e => e.FollowedId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("followedId")
                    .HasComment("关注的用户id");

                entity.Property(e => e.FollowedName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("followedName");

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .HasColumnName("remark")
                    .HasComment("备注");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpUserFolloweds)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpUserFollowed_rpUserInfo");
            });

            modelBuilder.Entity<RpUserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("rpUserInfo");

                entity.HasComment("用户信息");

                entity.HasIndex(e => e.UserNum, "Index_rpUserNum");

                entity.HasIndex(e => e.UserNum, "UK_rpUserNum")
                    .IsUnique();

                entity.HasIndex(e => e.Phone, "UK_rpUserPhone")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasComment("年纪");

                entity.Property(e => e.AvatarUrl)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("avatarUrl")
                    .HasComment("头像地址");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday")
                    .HasComment("生日");

                entity.Property(e => e.Genders)
                    .HasColumnName("genders")
                    .HasComment("性别：\r\n0, 男\r\n1,女");

                entity.Property(e => e.InviteUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inviteUserId")
                    .HasComment("邀请人id");

                entity.Property(e => e.IsOnline).HasColumnName("isOnline");

                entity.Property(e => e.IsVip)
                    .HasColumnName("isVip")
                    .HasComment("是否达人，默认否");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("最后更新时间");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("loginTime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .HasColumnName("memo")
                    .HasComment("备注信息 ：仅用于平台运营使用，不在app端显示");

                entity.Property(e => e.NickName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nickName")
                    .HasComment("昵称");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password")
                    .HasComment("登录密码：数据库中MD5加密存储");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .HasComment("电话");

                entity.Property(e => e.RegistTime)
                    .HasColumnType("datetime")
                    .HasColumnName("registTime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("注册时间");

                entity.Property(e => e.UserNum)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("userNum");

                entity.Property(e => e.UserStatus)
                    .HasColumnName("userStatus")
                    .HasComment("用户状态 0:正常 1：禁用 2：达人过期");

                entity.Property(e => e.UserTags)
                    .IsRequired()
                    .HasColumnName("userTags")
                    .HasComment("用户标签");

                entity.Property(e => e.WeChatOpenId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("weChatOpenId");
            });

            modelBuilder.Entity<RpUserMeetUp>(entity =>
            {
                entity.HasKey(e => e.MetId);

                entity.ToTable("rpUserMeetUp");

                entity.HasComment("用户相遇记录");

                entity.Property(e => e.MetId).HasColumnName("metId");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("datetime")
                    .HasColumnName("creatTime")
                    .HasComment("创建时间");

                entity.Property(e => e.MetDistance)
                    .HasColumnName("metDistance")
                    .HasComment("相遇距离");

                entity.Property(e => e.MetGps)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("metGps")
                    .HasComment("相遇的经纬度");

                entity.Property(e => e.MetSpot)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("metSpot")
                    .HasComment("相遇地点");

                entity.Property(e => e.MetUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("metUserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpUserMeetUps)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpUserMeetUp_rpUserInfo");
            });

            modelBuilder.Entity<RpUserNotify>(entity =>
            {
                entity.HasKey(e => e.NotifyId)
                    .HasName("PK_rpUserNotification");

                entity.ToTable("rpUserNotify");

                entity.HasComment("用户通知消息 ");

                entity.Property(e => e.NotifyId).HasColumnName("notifyId");

                entity.Property(e => e.CreateTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.HasRead)
                    .HasColumnName("hasRead")
                    .HasComment("是否已读");

                entity.Property(e => e.NotifyText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("notifyText")
                    .HasComment("通知内容");

                entity.Property(e => e.NotifyType)
                    .HasColumnName("notifyType")
                    .HasComment("通知类型： 0，系统消息\r\n           1，点赞消息\r\n           2，评论消息\r\n           3，礼物消息\r\n           4 关注消息\r\n           5，愿望消息\r\n           ..........\r\n\r\n\r\n          \r\n           ");

                entity.Property(e => e.OtherUsers)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("otherUsers")
                    .HasComment("与通知相关的用户 用户Id用逗号隔开");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpUserNotifies)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpUserNotification_rpUserInfo");
            });

            modelBuilder.Entity<RpUserTrack>(entity =>
            {
                entity.HasKey(e => e.TrackId);

                entity.ToTable("rpUserTrack");

                entity.HasComment("用户足迹");

                entity.Property(e => e.TrackId)
                    .ValueGeneratedNever()
                    .HasColumnName("trackId");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("address")
                    .HasComment("地址信息");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("city")
                    .HasComment("城市");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("country")
                    .HasDefaultValueSql("('中国')")
                    .HasComment("国家");

                entity.Property(e => e.CreatTime)
                    .HasColumnType("datetime")
                    .HasColumnName("creatTime")
                    .HasComment("创建时间");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("district")
                    .HasComment("区县");

                entity.Property(e => e.GpsLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gpsLocation")
                    .HasComment("GPS位置：经度，纬度");

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("province")
                    .HasComment("省");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("street")
                    .HasComment("街道");

                entity.Property(e => e.StreetNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("streetNumber")
                    .HasComment("门牌号");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpUserTracks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpUserTrack_rpUserInfo");
            });

            modelBuilder.Entity<RpVipUserCharge>(entity =>
            {
                entity.HasKey(e => e.ChargeId);

                entity.ToTable("rpVipUserCharge");

                entity.HasComment("达人充值记录");

                entity.Property(e => e.ChargeId).HasColumnName("chargeId");

                entity.Property(e => e.BeginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("beginDate");

                entity.Property(e => e.ChargeFee)
                    .HasColumnType("money")
                    .HasColumnName("chargeFee")
                    .HasComment("充值金额");

                entity.Property(e => e.ChargeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("chargeTime")
                    .HasComment("充值时间");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("endDate");

                entity.Property(e => e.Memo)
                    .HasMaxLength(200)
                    .HasColumnName("memo")
                    .HasComment("备注");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.Property(e => e.VipDuration)
                    .HasColumnName("vipDuration")
                    .HasComment("达人会员时长（天）");

                entity.Property(e => e.VipUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vipUserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpVipUserCharges)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_rpVipUserCharge_rpUserInfo");
            });

            modelBuilder.Entity<RpVipUserChargeSettting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("rpVipUserChargeSettting");

                entity.HasComment("达人充值配置");

                entity.Property(e => e.SettingId).HasColumnName("settingId");

                entity.Property(e => e.ChargeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("chargeName")
                    .HasComment("名称");

                entity.Property(e => e.CostMoney)
                    .HasColumnType("money")
                    .HasColumnName("costMoney")
                    .HasComment("金额");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("创建时间");

                entity.Property(e => e.VipDuration)
                    .HasColumnName("vipDuration")
                    .HasComment("vip时长");
            });

            modelBuilder.Entity<RpVipUserInfo>(entity =>
            {
                entity.HasKey(e => e.VipId);

                entity.ToTable("rpVipUserInfo");

                entity.HasComment("达人用户信息");

                entity.Property(e => e.VipId).HasColumnName("vipId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.Property(e => e.VipDateBegin)
                    .HasColumnType("datetime")
                    .HasColumnName("vipDateBegin")
                    .HasComment("达人开始时间");

                entity.Property(e => e.VipExpired)
                    .HasColumnType("datetime")
                    .HasColumnName("vipExpired")
                    .HasComment("达人结束时间");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpVipUserInfos)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_rpVipUserInfo_rpUserInfo");
            });

            modelBuilder.Entity<RpVipUserRequire>(entity =>
            {
                entity.HasKey(e => e.RequireId);

                entity.ToTable("rpVipUserRequire");

                entity.HasComment("达人匹配要求");

                entity.Property(e => e.RequireId).HasColumnName("requireId");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastUpdate")
                    .HasComment("更新时间");

                entity.Property(e => e.ReqAgeMax)
                    .HasColumnName("reqAgeMax")
                    .HasComment("最大年纪");

                entity.Property(e => e.ReqAgeMin)
                    .HasColumnName("reqAgeMin")
                    .HasComment("最低年纪");

                entity.Property(e => e.ReqUserGender)
                    .HasColumnName("reqUserGender")
                    .HasComment("要求的性别");

                entity.Property(e => e.ReqUserTags)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reqUserTags")
                    .HasComment("对方标签");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpVipUserRequires)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_rpVipUserRequire_rpUserInfo");
            });

            modelBuilder.Entity<RpWeeklyReport>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("rpWeeklyReport");

                entity.HasComment("用户周报");

                entity.Property(e => e.ReportId).HasColumnName("reportId");

                entity.Property(e => e.BeginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("beginTime");

                entity.Property(e => e.CommentCount).HasColumnName("commentCount");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("endTime")
                    .HasComment("统计数据截止时间");

                entity.Property(e => e.GetAwardCount)
                    .HasColumnName("getAwardCount")
                    .HasComment("被打赏数量");

                entity.Property(e => e.GiveAwardCount)
                    .HasColumnName("giveAwardCount")
                    .HasComment("打赏别人数量");

                entity.Property(e => e.MomentCount).HasColumnName("momentCount");

                entity.Property(e => e.MomentLikeCount).HasColumnName("momentLikeCount");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("用户id");
            });

            modelBuilder.Entity<RpWishList>(entity =>
            {
                entity.HasKey(e => e.WishId);

                entity.ToTable("rpWishList");

                entity.HasComment("愿望池");

                entity.Property(e => e.WishId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wishId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime");

                entity.Property(e => e.FinishTime)
                    .HasColumnType("datetime")
                    .HasColumnName("finishTime");

                entity.Property(e => e.GiftCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("giftCode")
                    .HasComment("对应的礼物编码");

                entity.Property(e => e.GiftName)
                    .HasMaxLength(50)
                    .HasColumnName("giftName")
                    .HasComment("对应礼物名称");

                entity.Property(e => e.GiftPicUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("giftPicUrl")
                    .HasComment("礼物图片");

                entity.Property(e => e.GiftValue)
                    .HasColumnName("giftValue")
                    .HasComment("礼物价值：金币数量");

                entity.Property(e => e.IsFree).HasColumnName("isFree");

                entity.Property(e => e.PubTime)
                    .HasColumnType("datetime")
                    .HasColumnName("pubTime")
                    .HasComment("发布时间");

                entity.Property(e => e.RealizeType)
                    .HasColumnName("realizeType")
                    .HasComment("实现方式： 0，大家帮\r\n           1，一人帮");

                entity.Property(e => e.RealizeUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("realizeUser")
                    .HasComment("指定帮忙的用户id");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("发布人id");

                entity.Property(e => e.WishCatalog)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wishCatalog");

                entity.Property(e => e.WishDesc)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnName("wishDesc")
                    .HasComment("愿望描述");

                entity.Property(e => e.WishDescType).HasColumnName("wishDescType");

                entity.Property(e => e.WishName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("wishName")
                    .HasComment("愿望名称");

                entity.Property(e => e.WishProgress)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("wishProgress")
                    .HasComment(" 愿望进度");

                entity.Property(e => e.WishStatus)
                    .HasColumnName("wishStatus")
                    .HasComment("愿望状态 ： 0，草稿\r\n            1，已发布\r\n            2，进行中\r\n            3，完成\r\n            4，撤销");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RpWishLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpWishList_rpUserInfo");
            });

            modelBuilder.Entity<RpWishProcess>(entity =>
            {
                entity.HasKey(e => e.ProcessId);

                entity.ToTable("rpWishProcess");

                entity.HasComment("愿望实现");

                entity.Property(e => e.ProcessId).HasColumnName("processId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("创建时间");

                entity.Property(e => e.GiftCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("giftCode");

                entity.Property(e => e.GiftName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("giftName")
                    .HasComment("礼物名称");

                entity.Property(e => e.GiftValue)
                    .HasColumnName("giftValue")
                    .HasComment("礼物价值");

                entity.Property(e => e.ProcessUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("processUser");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId")
                    .HasComment("愿望发布人id");

                entity.Property(e => e.WishId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wishId")
                    .HasComment("愿望Id");

                entity.HasOne(d => d.Wish)
                    .WithMany(p => p.RpWishProcesses)
                    .HasForeignKey(d => d.WishId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rpWishProcess_rpWishList");
            });

            modelBuilder.Entity<RpWithdrawApply>(entity =>
            {
                entity.HasKey(e => e.ApplyId);

                entity.ToTable("rpWithdrawApply");

                entity.HasComment("提现申请");

                entity.HasIndex(e => e.OrderCode, "uk_rpWithdrawOrderCode")
                    .IsUnique();

                entity.Property(e => e.ApplyId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("applyId");

                entity.Property(e => e.ActualMoney)
                    .HasColumnType("money")
                    .HasColumnName("actualMoney")
                    .HasComment("用户到账金额");

                entity.Property(e => e.ApplyStatus)
                    .HasColumnName("applyStatus")
                    .HasComment("状态： 0，申请中\r\n       1，提现成功\r\n       2，被驳回");

                entity.Property(e => e.CoinCount).HasColumnName("coinCount");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("createTime")
                    .HasComment("申请时间");

                entity.Property(e => e.FinishTime)
                    .HasColumnType("datetime")
                    .HasColumnName("finishTime")
                    .HasComment("完成时间 ：提现成功或者被驳回的时间");

                entity.Property(e => e.HandleFee)
                    .HasColumnType("money")
                    .HasColumnName("handleFee")
                    .HasComment("手续费");

                entity.Property(e => e.HandleFeePer)
                    .HasColumnType("decimal(5, 4)")
                    .HasColumnName("handleFeePer");

                entity.Property(e => e.OrderCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("orderCode")
                    .HasComment("订单编号 生成规则：年（2位）+月（2位)+日（2位）+业务流水号（5位）");

                entity.Property(e => e.TotalMoney)
                    .HasColumnType("money")
                    .HasColumnName("totalMoney")
                    .HasComment("总金额");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userId");

                entity.Property(e => e.VipId).HasColumnName("vipId");

                entity.HasOne(d => d.Vip)
                    .WithMany(p => p.RpWithdrawApplies)
                    .HasForeignKey(d => d.VipId)
                    .HasConstraintName("FK_rpWithdrawApply_rpVipUserInfo");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.HasComment("出入库信息表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("数据ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("产品名称");

                entity.Property(e => e.Number).HasComment("产品数量");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("组织ID");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 1)")
                    .HasComment("产品单价");

                entity.Property(e => e.Status).HasComment("出库/入库");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("操作时间");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("操作人");

                entity.Property(e => e.Viewable)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("可见范围");
            });

            modelBuilder.Entity<SysLog>(entity =>
            {
                entity.ToTable("SysLog");

                entity.HasComment("系统日志");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Id");

                entity.Property(e => e.Application)
                    .HasMaxLength(50)
                    .HasComment("所属应用");

                entity.Property(e => e.Content)
                    .HasMaxLength(1000)
                    .HasComment("日志内容");

                entity.Property(e => e.CreateId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("操作人ID");

                entity.Property(e => e.CreateName)
                    .HasMaxLength(200)
                    .HasComment("操作人");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("记录时间");

                entity.Property(e => e.Href)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("操作所属模块地址");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("操作机器的IP地址");

                entity.Property(e => e.Result).HasComment("操作的结果：0：成功；1：失败；");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .HasComment("分类名称");
            });

            modelBuilder.Entity<SysMessage>(entity =>
            {
                entity.ToTable("SysMessage");

                entity.HasComment("系统消息表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Id");

                entity.Property(e => e.Content)
                    .HasMaxLength(1000)
                    .HasComment("消息内容");

                entity.Property(e => e.CreateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("创建时间");

                entity.Property(e => e.FromId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("消息源头");

                entity.Property(e => e.FromName)
                    .HasMaxLength(50)
                    .HasComment("消息源头名称");

                entity.Property(e => e.FromStatus).HasComment("-1:已删除；0:默认");

                entity.Property(e => e.Href)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("点击消息跳转的页面等");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasComment("消息标题");

                entity.Property(e => e.ToId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("到达");

                entity.Property(e => e.ToName)
                    .HasMaxLength(50)
                    .HasComment("消息到达名称");

                entity.Property(e => e.ToStatus).HasComment("-1:已删除；0:默认未读；1：已读");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .HasComment("分类名称");
            });

            modelBuilder.Entity<UploadFile>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_FILE")
                    .IsClustered(false);

                entity.ToTable("UploadFile");

                entity.HasComment("文件");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Id");

                entity.Property(e => e.BelongApp)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("所属应用");

                entity.Property(e => e.BelongAppId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("所属应用ID");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("上传时间");

                entity.Property(e => e.CreateUserId).HasComment("上传人");

                entity.Property(e => e.CreateUserName)
                    .HasMaxLength(50)
                    .HasComment("上传人姓名");

                entity.Property(e => e.DeleteMark).HasComment("删除标识");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasComment("描述");

                entity.Property(e => e.Enable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("是否可用");

                entity.Property(e => e.Extension)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("扩展名称");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasComment("文件名称");

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("文件路径");

                entity.Property(e => e.FileSize).HasComment("文件大小");

                entity.Property(e => e.FileType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("文件类型");

                entity.Property(e => e.SortCode).HasComment("排序");

                entity.Property(e => e.Thumbnail)
                    .HasMaxLength(500)
                    .HasComment("缩略图");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasComment("用户基本信息表");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("流水号");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("用户登录帐号");

                entity.Property(e => e.BizCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("业务对照码");

                entity.Property(e => e.CreateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("经办时间");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("用户姓名");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .HasComment("密码");

                entity.Property(e => e.Sex).HasComment("性别");

                entity.Property(e => e.Status).HasComment("用户状态");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("分类ID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .HasComment("分类名称");
            });

            modelBuilder.Entity<WmsInboundOrderDtbl>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.OrderId })
                    .HasName("PK__WmsInbou__DE2DE9BB34BC7C0B");

                entity.ToTable("WmsInboundOrderDtbl");

                entity.HasComment("入库通知单明细");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("入库通知单明细号");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("入库通知单号");

                entity.Property(e => e.AsnStatus).HasComment("到货状况(SYS_GOODSARRIVESTATUS)");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("创建人");

                entity.Property(e => e.ExpireDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("失效日期");

                entity.Property(e => e.GoodsBatch)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("商品批号");

                entity.Property(e => e.GoodsId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("商品编号");

                entity.Property(e => e.HoldNum)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("占用数量");

                entity.Property(e => e.InNum)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("到货数量");

                entity.Property(e => e.InStockStatus).HasComment("是否收货中(0:非收货中,1:收货中)");

                entity.Property(e => e.LeaveNum)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("剩余数量");

                entity.Property(e => e.OrderNum)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("通知数量");

                entity.Property(e => e.OwnerId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasComment("货主编号");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 6)")
                    .HasComment("含税单价");

                entity.Property(e => e.PriceNoTax)
                    .HasColumnType("decimal(18, 6)")
                    .HasComment("无税单价");

                entity.Property(e => e.ProdDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("生产日期");

                entity.Property(e => e.QualityFlg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("品质(SYS_QUALITYFLAG)");

                entity.Property(e => e.Remark)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasComment("备注");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("税率");

                entity.Property(e => e.UpdateTime).HasComment("最后更新时间");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后更新人ID");

                entity.Property(e => e.UpdateUserName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("最后更新人");
            });

            modelBuilder.Entity<WmsInboundOrderTbl>(entity =>
            {
                entity.ToTable("WmsInboundOrderTbl");

                entity.HasComment("入库通知单（入库订单）");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("入库通知单号");

                entity.Property(e => e.CreateTime).HasComment("创建时间");

                entity.Property(e => e.CreateUserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("创建人ID");

                entity.Property(e => e.CreateUserName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("创建人");

                entity.Property(e => e.Enable).HasComment("有效标志");

                entity.Property(e => e.ExternalNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("相关单据号");

                entity.Property(e => e.ExternalType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("相关单据类型");

                entity.Property(e => e.GoodsType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("商品类别");

                entity.Property(e => e.InBondedArea).HasComment("是否入保税库(0:否,1:是)");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("入库类型(SYS_INSTCTYPE)");

                entity.Property(e => e.OrgId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("所属部门");

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("货主编号(固定值CQM)");

                entity.Property(e => e.PurchaseNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasComment("采购单号");

                entity.Property(e => e.Remark)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasComment("备注");

                entity.Property(e => e.ReturnBoxNum)
                    .HasColumnType("decimal(8, 0)")
                    .HasComment("销退箱数");

                entity.Property(e => e.ScheduledInboundTime).HasComment("预定入库时间");

                entity.Property(e => e.ShipperId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("承运人编号");

                entity.Property(e => e.Status).HasComment("入库通知单状态(SYS_INSTCINFORMSTATUS)");

                entity.Property(e => e.StockId)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("仓库编号");

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("供应商编号");

                entity.Property(e => e.TransferType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("承运方式");

                entity.Property(e => e.UpdateTime).HasComment("最后更新时间");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("最后更新人ID");

                entity.Property(e => e.UpdateUserName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("最后更新人");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
