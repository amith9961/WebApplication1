using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models
{
    public partial class postgresContext : DbContext
    {
        public postgresContext()
        {
        }

        public postgresContext(DbContextOptions<postgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleAssetTypeFileExtension> ArticleAssetTypeFileExtensions { get; set; }
        public virtual DbSet<ArticleJob> ArticleJobs { get; set; }
        public virtual DbSet<ArticleTypesetter> ArticleTypesetters { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<AssetCategory> AssetCategories { get; set; }
        public virtual DbSet<AssetCategoryCode> AssetCategoryCodes { get; set; }
        public virtual DbSet<AssetRoleAction> AssetRoleActions { get; set; }
        public virtual DbSet<AssetStageAction> AssetStageActions { get; set; }
        public virtual DbSet<AssetStatus> AssetStatuses { get; set; }
        public virtual DbSet<AssetStatusAction> AssetStatusActions { get; set; }
        public virtual DbSet<AssetStatusCode> AssetStatusCodes { get; set; }
        public virtual DbSet<AssetType> AssetTypes { get; set; }
        public virtual DbSet<AssetTypeCode> AssetTypeCodes { get; set; }
        public virtual DbSet<AssetTypeSource> AssetTypeSources { get; set; }
        public virtual DbSet<AssetTypeSourceCode> AssetTypeSourceCodes { get; set; }
        public virtual DbSet<AssetTypeVisibility> AssetTypeVisibilities { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentType> CommentTypes { get; set; }
        public virtual DbSet<CommentTypeCode> CommentTypeCodes { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FileAction> FileActions { get; set; }
        public virtual DbSet<FileActionType> FileActionTypes { get; set; }
        public virtual DbSet<FileActionTypeCode> FileActionTypeCodes { get; set; }
        public virtual DbSet<FileExtension> FileExtensions { get; set; }
        public virtual DbSet<FileStatus> FileStatuses { get; set; }
        public virtual DbSet<FileStatusCode> FileStatusCodes { get; set; }
        public virtual DbSet<HdbActionLog> HdbActionLogs { get; set; }
        public virtual DbSet<HdbCronEvent> HdbCronEvents { get; set; }
        public virtual DbSet<HdbCronEventInvocationLog> HdbCronEventInvocationLogs { get; set; }
        public virtual DbSet<HdbMetadatum> HdbMetadata { get; set; }
        public virtual DbSet<HdbScheduledEvent> HdbScheduledEvents { get; set; }
        public virtual DbSet<HdbScheduledEventInvocationLog> HdbScheduledEventInvocationLogs { get; set; }
        public virtual DbSet<HdbSchemaNotification> HdbSchemaNotifications { get; set; }
        public virtual DbSet<HdbVersion> HdbVersions { get; set; }
        public virtual DbSet<ImpersonationActionHistory> ImpersonationActionHistories { get; set; }
        public virtual DbSet<JournalTypesetter> JournalTypesetters { get; set; }
        public virtual DbSet<PublishedArticle> PublishedArticles { get; set; }
        public virtual DbSet<PublishedArticleContent> PublishedArticleContents { get; set; }
        public virtual DbSet<PublishedAuthorAffiliation> PublishedAuthorAffiliations { get; set; }
        public virtual DbSet<PublishedAuthorDetail> PublishedAuthorDetails { get; set; }
        public virtual DbSet<PublishedFile> PublishedFiles { get; set; }
        public virtual DbSet<PublishedKeyword> PublishedKeywords { get; set; }
        public virtual DbSet<PublishedStatus> PublishedStatuses { get; set; }
        public virtual DbSet<PublishedStatusesCode> PublishedStatusesCodes { get; set; }
        public virtual DbSet<RoleCode> RoleCodes { get; set; }
        public virtual DbSet<Stage> Stages { get; set; }
        public virtual DbSet<StageCode> StageCodes { get; set; }
        public virtual DbSet<StageHistory> StageHistories { get; set; }
        public virtual DbSet<Submission> Submissions { get; set; }
        public virtual DbSet<Typesetter> Typesetters { get; set; }
        public virtual DbSet<UploadRequest> UploadRequests { get; set; }
        public virtual DbSet<UploadRequestFile> UploadRequestFiles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ZipContentFile> ZipContentFiles { get; set; }
        public virtual DbSet<ZipContentFileType> ZipContentFileTypes { get; set; }
        public virtual DbSet<ZipContentFileTypeCode> ZipContentFileTypeCodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("User ID=postgres;Password=postgrespassword;Host=localhost;Port=5432;Database=postgres;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.utf8");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => new { e.SpaceId, e.Id })
                    .HasName("article_pkey");

                entity.ToTable("article");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcceptedOn).HasColumnName("acceptedOn");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.JournalId).HasColumnName("journalId");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.PublishedOn).HasColumnName("publishedOn");

                entity.Property(e => e.StageId).HasColumnName("stageId");

                entity.Property(e => e.Title).HasColumnName("title");
            });

            modelBuilder.Entity<ArticleAssetTypeFileExtension>(entity =>
            {
                entity.ToTable("articleAssetTypeFileExtension");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ArticleAssetTypeId).HasColumnName("articleAssetTypeId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FileExtensionId).HasColumnName("fileExtensionId");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.HasOne(d => d.ArticleAssetType)
                    .WithMany(p => p.ArticleAssetTypeFileExtensions)
                    .HasForeignKey(d => d.ArticleAssetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetType_assetTypeFileExtension_fkey");

                entity.HasOne(d => d.FileExtension)
                    .WithMany(p => p.ArticleAssetTypeFileExtensions)
                    .HasForeignKey(d => d.FileExtensionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("asseType_fileExtension_fkey");
            });

            modelBuilder.Entity<ArticleJob>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.SpaceId })
                    .HasName("articleJobs_pkey");

                entity.ToTable("articleJobs");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasColumnName("jobId");

                entity.Property(e => e.LastActionUserId).HasColumnName("lastActionUserId");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Summary).HasColumnName("summary");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.ArticleJobs)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("articleJobs_status_fkey");
            });

            modelBuilder.Entity<ArticleTypesetter>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpaceId })
                    .HasName("articleTypesetter_pkey");

                entity.ToTable("articleTypesetter");

                entity.HasIndex(e => e.Id, "articleTypesetter_id_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"ProductionArticleTypesetter_ProductionArticleTypesetterId_seq\"'::regclass)");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.AssignmentDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("assignmentDate");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IsCurrent).HasColumnName("isCurrent");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Typesetter)
                    .WithMany(p => p.ArticleTypesetters)
                    .HasForeignKey(d => new { d.UserId, d.SpaceId })
                    .HasConstraintName("articleTypesetter_userId_spaceId_fkey");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.HasKey(e => new { e.SpaceId, e.Id })
                    .HasName("asset_pkey");

                entity.ToTable("asset");

                entity.HasIndex(e => new { e.Id, e.ArticleId, e.SpaceId, e.ProductionArticleAssetNumber }, "ProductionArticleAsset_ProductionArticleAssetId_ProductionArtic")
                    .IsUnique();

                entity.HasIndex(e => new { e.SpaceId, e.ArticleId }, "asset_spaceId_articleId_idx");

                entity.HasIndex(e => e.StatusId, "asset_statusId_idx");

                entity.HasIndex(e => e.TypeId, "asset_typeId_idx");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"Asset_Id_seq\"'::regclass)");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.AssetNumber)
                    .HasColumnName("assetNumber")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("modifiedDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("asset_categoryId_fkey");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("asset_modifiedBy_fkey");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("asset_statusId_fkey");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Assets)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("asset_typeId_fkey");
            });

            modelBuilder.Entity<AssetCategory>(entity =>
            {
                entity.ToTable("assetCategory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.CodeNavigation)
                    .WithMany(p => p.AssetCategories)
                    .HasForeignKey(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetCategory_code_fkey");
            });

            modelBuilder.Entity<AssetCategoryCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("assetCategoryCode_pkey");

                entity.ToTable("assetCategoryCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            modelBuilder.Entity<AssetRoleAction>(entity =>
            {
                entity.HasKey(e => new { e.AssetType, e.RoleCode, e.ActionType })
                    .HasName("assetRoleAction_pkey");

                entity.ToTable("assetRoleAction");

                entity.Property(e => e.AssetType).HasColumnName("assetType");

                entity.Property(e => e.RoleCode).HasColumnName("roleCode");

                entity.Property(e => e.ActionType).HasColumnName("actionType");

                entity.HasOne(d => d.ActionTypeNavigation)
                    .WithMany(p => p.AssetRoleActions)
                    .HasForeignKey(d => d.ActionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetRoleAction_actionType_fkey");

                entity.HasOne(d => d.AssetTypeNavigation)
                    .WithMany(p => p.AssetRoleActions)
                    .HasForeignKey(d => d.AssetType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetRoleAction_assetType_fkey");

                entity.HasOne(d => d.RoleCodeNavigation)
                    .WithMany(p => p.AssetRoleActions)
                    .HasForeignKey(d => d.RoleCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetRoleAction_roleCode_fkey");
            });

            modelBuilder.Entity<AssetStageAction>(entity =>
            {
                entity.HasKey(e => new { e.AssetType, e.StageCode, e.ActionType })
                    .HasName("assetStageAction_pkey");

                entity.ToTable("assetStageAction");

                entity.Property(e => e.AssetType).HasColumnName("assetType");

                entity.Property(e => e.StageCode).HasColumnName("stageCode");

                entity.Property(e => e.ActionType).HasColumnName("actionType");

                entity.HasOne(d => d.ActionTypeNavigation)
                    .WithMany(p => p.AssetStageActions)
                    .HasForeignKey(d => d.ActionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetStageAction_actionType_fkey");

                entity.HasOne(d => d.AssetTypeNavigation)
                    .WithMany(p => p.AssetStageActions)
                    .HasForeignKey(d => d.AssetType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetStageAction_assetType_fkey");

                entity.HasOne(d => d.StageCodeNavigation)
                    .WithMany(p => p.AssetStageActions)
                    .HasForeignKey(d => d.StageCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetStageAction_stageCode_fkey");
            });

            modelBuilder.Entity<AssetStatus>(entity =>
            {
                entity.ToTable("assetStatus");

                entity.HasIndex(e => e.Code, "assetStatus_code_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "assetStatus_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.CodeNavigation)
                    .WithOne(p => p.AssetStatus)
                    .HasForeignKey<AssetStatus>(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetStatus_code_fkey");
            });

            modelBuilder.Entity<AssetStatusAction>(entity =>
            {
                entity.HasKey(e => new { e.AssetType, e.StatusCode, e.ActionType })
                    .HasName("assetStatusAction_pkey");

                entity.ToTable("assetStatusAction");

                entity.Property(e => e.AssetType).HasColumnName("assetType");

                entity.Property(e => e.StatusCode).HasColumnName("statusCode");

                entity.Property(e => e.ActionType).HasColumnName("actionType");

                entity.HasOne(d => d.ActionTypeNavigation)
                    .WithMany(p => p.AssetStatusActions)
                    .HasForeignKey(d => d.ActionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetStatusAction_actionType_fkey");

                entity.HasOne(d => d.AssetTypeNavigation)
                    .WithMany(p => p.AssetStatusActions)
                    .HasForeignKey(d => d.AssetType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetStatusAction_assetType_fkey");

                entity.HasOne(d => d.StatusCodeNavigation)
                    .WithMany(p => p.AssetStatusActions)
                    .HasForeignKey(d => d.StatusCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetStatusAction_statusCode_fkey");
            });

            modelBuilder.Entity<AssetStatusCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("assetStatusCode_pkey");

                entity.ToTable("assetStatusCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.ToTable("assetType");

                entity.HasIndex(e => e.CategoryId, "assetType_categoryId_idx");

                entity.HasIndex(e => e.Code, "assetType_code_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "assetType_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DefaultCategoryId).HasColumnName("defaultCategoryId");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AssetTypes)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetType_categoryId_fkey");

                entity.HasOne(d => d.CodeNavigation)
                    .WithOne(p => p.AssetType)
                    .HasForeignKey<AssetType>(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetType_code_fkey");

                entity.HasOne(d => d.DefaultCategory)
                    .WithMany(p => p.AssetTypes)
                    .HasForeignKey(d => d.DefaultCategoryId)
                    .HasConstraintName("assetType_defaultCategoryId_fkey");
            });

            modelBuilder.Entity<AssetTypeCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("assetTypeCode_pkey");

                entity.ToTable("assetTypeCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            modelBuilder.Entity<AssetTypeSource>(entity =>
            {
                entity.ToTable("assetTypeSource");

                entity.HasIndex(e => e.Code, "assetTypeCategory_code_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "assetTypeCategory_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.CodeNavigation)
                    .WithOne(p => p.AssetTypeSource)
                    .HasForeignKey<AssetTypeSource>(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetTypeCategory_code_fkey");
            });

            modelBuilder.Entity<AssetTypeSourceCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("assetTypeCategoryCode_pkey");

                entity.ToTable("assetTypeSourceCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            modelBuilder.Entity<AssetTypeVisibility>(entity =>
            {
                entity.HasKey(e => new { e.AssetTypeId, e.HasuraRole })
                    .HasName("assetTypeVisibility_pkey");

                entity.ToTable("assetTypeVisibility");

                entity.Property(e => e.AssetTypeId).HasColumnName("assetTypeId");

                entity.Property(e => e.HasuraRole).HasColumnName("hasuraRole");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.HasOne(d => d.AssetType)
                    .WithMany(p => p.AssetTypeVisibilities)
                    .HasForeignKey(d => d.AssetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("assetTypeVisibility_id_fkey");
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => new { e.SpaceId, e.Id })
                    .HasName("author_pkey");

                entity.ToTable("author");

                entity.HasIndex(e => e.ArticleId, "author_articleId_idx");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"ArticleAuthor_ArticleAuthorId_seq\"'::regclass)");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasColumnName("roleCode")
                    .HasDefaultValueSql("'default'::text");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comment");

                entity.HasIndex(e => new { e.ArticleId, e.SpaceId, e.TypeId }, "comment_articleId_spaceId_typeId_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.CommentModificationDate).HasColumnName("commentModificationDate");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("comment_typeId_fkey");
            });

            modelBuilder.Entity<CommentType>(entity =>
            {
                entity.ToTable("commentType");

                entity.HasIndex(e => e.Code, "commentType_code_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "commentType_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.CodeNavigation)
                    .WithOne(p => p.CommentType)
                    .HasForeignKey<CommentType>(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("commentType_code_fkey");
            });

            modelBuilder.Entity<CommentTypeCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("commentTypeCode_pkey");

                entity.ToTable("commentTypeCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.HasKey(e => new { e.SpaceId, e.Id })
                    .HasName("file_pkey");

                entity.ToTable("file");

                entity.HasIndex(e => e.AssetId, "file_spaceId_assetId_idx");

                entity.HasIndex(e => e.StatusId, "file_statusId_idx");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"ArticleFile_Id_seq\"'::regclass)");

                entity.Property(e => e.AssetId).HasColumnName("assetId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ErrorMessage).HasColumnName("errorMessage");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension");

                entity.Property(e => e.FileServerId)
                    .IsRequired()
                    .HasColumnName("fileServerId");

                entity.Property(e => e.IsLatest)
                    .IsRequired()
                    .HasColumnName("isLatest")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.LastActionDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("lastActionDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.LastActionUserId).HasColumnName("lastActionUserId");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasComment("Final name of the file after renaming");

                entity.Property(e => e.OriginalName)
                    .IsRequired()
                    .HasColumnName("originalName")
                    .HasComment("Full file name, with extension");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasComment("Size of the file in kilobytes");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.Version).HasColumnName("version");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("file_statusId_fkey");
            });

            modelBuilder.Entity<FileAction>(entity =>
            {
                entity.HasKey(e => new { e.SpaceId, e.Id })
                    .HasName("fileAction_pkey");

                entity.ToTable("fileAction");

                entity.HasIndex(e => new { e.SpaceId, e.FileId }, "fileAction_spaceId_fileId_idx");

                entity.HasIndex(e => e.TypeId, "fileAction_typeId_idx");

                entity.HasIndex(e => e.UserId, "fileAction_userId_idx");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"ArticleFileAction_ArticleFileActionId_seq\"'::regclass)");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FileId).HasColumnName("fileId");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.FileActions)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fileAction_typeId_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FileActions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fileAction_userId_fkey");
            });

            modelBuilder.Entity<FileActionType>(entity =>
            {
                entity.ToTable("fileActionType");

                entity.HasIndex(e => e.Code, "fileActionType_code_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "fileActionType_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.CodeNavigation)
                    .WithOne(p => p.FileActionType)
                    .HasForeignKey<FileActionType>(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fileActionType_code_fkey");
            });

            modelBuilder.Entity<FileActionTypeCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("fileActionTypeCode_pkey");

                entity.ToTable("fileActionTypeCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            modelBuilder.Entity<FileExtension>(entity =>
            {
                entity.ToTable("fileExtension");

                entity.HasIndex(e => e.Extension, "fileExtension_extension_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");
            });

            modelBuilder.Entity<FileStatus>(entity =>
            {
                entity.ToTable("fileStatus");

                entity.HasIndex(e => e.Code, "fileStatus_code_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "fileStatus_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.CodeNavigation)
                    .WithOne(p => p.FileStatus)
                    .HasForeignKey<FileStatus>(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fileStatus_code_fkey");
            });

            modelBuilder.Entity<FileStatusCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("fileStatusCode_pkey");

                entity.ToTable("fileStatusCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            modelBuilder.Entity<HdbActionLog>(entity =>
            {
                entity.ToTable("hdb_action_log", "hdb_catalog");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("hdb_catalog.gen_hasura_uuid()");

                entity.Property(e => e.ActionName).HasColumnName("action_name");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Errors)
                    .HasColumnType("jsonb")
                    .HasColumnName("errors");

                entity.Property(e => e.InputPayload)
                    .IsRequired()
                    .HasColumnType("jsonb")
                    .HasColumnName("input_payload");

                entity.Property(e => e.RequestHeaders)
                    .IsRequired()
                    .HasColumnType("jsonb")
                    .HasColumnName("request_headers");

                entity.Property(e => e.ResponsePayload)
                    .HasColumnType("jsonb")
                    .HasColumnName("response_payload");

                entity.Property(e => e.ResponseReceivedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("response_received_at");

                entity.Property(e => e.SessionVariables)
                    .IsRequired()
                    .HasColumnType("jsonb")
                    .HasColumnName("session_variables");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status");
            });

            modelBuilder.Entity<HdbCronEvent>(entity =>
            {
                entity.ToTable("hdb_cron_events", "hdb_catalog");

                entity.HasIndex(e => e.Status, "hdb_cron_event_status");

                entity.HasIndex(e => new { e.TriggerName, e.ScheduledTime }, "hdb_cron_events_unique_scheduled")
                    .IsUnique()
                    .HasFilter("(status = 'scheduled'::text)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("hdb_catalog.gen_hasura_uuid()");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.NextRetryAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("next_retry_at");

                entity.Property(e => e.ScheduledTime)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("scheduled_time");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'scheduled'::text");

                entity.Property(e => e.Tries).HasColumnName("tries");

                entity.Property(e => e.TriggerName)
                    .IsRequired()
                    .HasColumnName("trigger_name");
            });

            modelBuilder.Entity<HdbCronEventInvocationLog>(entity =>
            {
                entity.ToTable("hdb_cron_event_invocation_logs", "hdb_catalog");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("hdb_catalog.gen_hasura_uuid()");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Request)
                    .HasColumnType("json")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("json")
                    .HasColumnName("response");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.HdbCronEventInvocationLogs)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("hdb_cron_event_invocation_logs_event_id_fkey");
            });

            modelBuilder.Entity<HdbMetadatum>(entity =>
            {
                entity.ToTable("hdb_metadata", "hdb_catalog");

                entity.HasIndex(e => e.ResourceVersion, "hdb_metadata_resource_version_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Metadata)
                    .IsRequired()
                    .HasColumnType("json")
                    .HasColumnName("metadata");

                entity.Property(e => e.ResourceVersion)
                    .HasColumnName("resource_version")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<HdbScheduledEvent>(entity =>
            {
                entity.ToTable("hdb_scheduled_events", "hdb_catalog");

                entity.HasIndex(e => e.Status, "hdb_scheduled_event_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("hdb_catalog.gen_hasura_uuid()");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.HeaderConf)
                    .HasColumnType("json")
                    .HasColumnName("header_conf");

                entity.Property(e => e.NextRetryAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("next_retry_at");

                entity.Property(e => e.Payload)
                    .HasColumnType("json")
                    .HasColumnName("payload");

                entity.Property(e => e.RetryConf)
                    .HasColumnType("json")
                    .HasColumnName("retry_conf");

                entity.Property(e => e.ScheduledTime)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("scheduled_time");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'scheduled'::text");

                entity.Property(e => e.Tries).HasColumnName("tries");

                entity.Property(e => e.WebhookConf)
                    .IsRequired()
                    .HasColumnType("json")
                    .HasColumnName("webhook_conf");
            });

            modelBuilder.Entity<HdbScheduledEventInvocationLog>(entity =>
            {
                entity.ToTable("hdb_scheduled_event_invocation_logs", "hdb_catalog");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("hdb_catalog.gen_hasura_uuid()");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Request)
                    .HasColumnType("json")
                    .HasColumnName("request");

                entity.Property(e => e.Response)
                    .HasColumnType("json")
                    .HasColumnName("response");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.HdbScheduledEventInvocationLogs)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("hdb_scheduled_event_invocation_logs_event_id_fkey");
            });

            modelBuilder.Entity<HdbSchemaNotification>(entity =>
            {
                entity.ToTable("hdb_schema_notifications", "hdb_catalog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.InstanceId).HasColumnName("instance_id");

                entity.Property(e => e.Notification)
                    .IsRequired()
                    .HasColumnType("json")
                    .HasColumnName("notification");

                entity.Property(e => e.ResourceVersion)
                    .HasColumnName("resource_version")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("now()");
            });

            modelBuilder.Entity<HdbVersion>(entity =>
            {
                entity.HasKey(e => e.HasuraUuid)
                    .HasName("hdb_version_pkey");

                entity.ToTable("hdb_version", "hdb_catalog");

                entity.Property(e => e.HasuraUuid)
                    .HasColumnName("hasura_uuid")
                    .HasDefaultValueSql("hdb_catalog.gen_hasura_uuid()");

                entity.Property(e => e.CliState)
                    .IsRequired()
                    .HasColumnType("jsonb")
                    .HasColumnName("cli_state")
                    .HasDefaultValueSql("'{}'::jsonb");

                entity.Property(e => e.ConsoleState)
                    .IsRequired()
                    .HasColumnType("jsonb")
                    .HasColumnName("console_state")
                    .HasDefaultValueSql("'{}'::jsonb");

                entity.Property(e => e.UpgradedOn)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("upgraded_on");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version");
            });

            modelBuilder.Entity<ImpersonationActionHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("impersonationActionHistory");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("createdDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ImpersonatedRole)
                    .IsRequired()
                    .HasColumnName("impersonatedRole");

                entity.Property(e => e.ImpersonatedUserId).HasColumnName("impersonatedUserId");

                entity.Property(e => e.LoggedInUserId).HasColumnName("loggedInUserId");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");
            });

            modelBuilder.Entity<JournalTypesetter>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpaceId })
                    .HasName("journalTypesetter_pkey");

                entity.ToTable("journalTypesetter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Typesetter)
                    .WithMany(p => p.JournalTypesetters)
                    .HasForeignKey(d => new { d.UserId, d.SpaceId })
                    .HasConstraintName("journalTypesetter_spaceId_userId_fkey");
            });

            modelBuilder.Entity<PublishedArticle>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.SpaceId })
                    .HasName("publishedArticle_pkey");

                entity.ToTable("publishedArticle");

                entity.HasIndex(e => e.ArticleId, "publishedArticle_articleId_key")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "publishedArticle_id_key")
                    .IsUnique();

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.Abstract)
                    .IsRequired()
                    .HasColumnName("abstract");

                entity.Property(e => e.ArticleTitle)
                    .IsRequired()
                    .HasColumnName("articleTitle");

                entity.Property(e => e.ArticleTypeName)
                    .IsRequired()
                    .HasColumnName("articleTypeName");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ElocationId).HasColumnName("elocationId");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.PublishedDate)
                    .HasColumnType("date")
                    .HasColumnName("publishedDate");

                entity.Property(e => e.Volume).HasColumnName("volume");
            });

            modelBuilder.Entity<PublishedArticleContent>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.SpaceId })
                    .HasName("publishedArticleContent_pkey");

                entity.ToTable("publishedArticleContent");

                entity.HasIndex(e => e.ArticleId, "publishedArticleContent_articleId_key")
                    .IsUnique();

                entity.HasIndex(e => e.Id, "publishedArticleContent_id_key")
                    .IsUnique();

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");
            });

            modelBuilder.Entity<PublishedAuthorAffiliation>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpaceId })
                    .HasName("publishedAuthorAffiliations_pkey");

                entity.ToTable("publishedAuthorAffiliations");

                entity.HasIndex(e => e.Id, "publishedAuthorAffiliations_id_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.AuthorId).HasColumnName("authorId");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Institution)
                    .IsRequired()
                    .HasColumnName("institution");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.SequenceNumber).HasColumnName("sequenceNumber");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.PublishedAuthorAffiliations)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("publishedAuthorAffiliations_authorId_fkey");
            });

            modelBuilder.Entity<PublishedAuthorDetail>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.UserId, e.SpaceId })
                    .HasName("publishedAuthorDetails_pkey");

                entity.ToTable("publishedAuthorDetails");

                entity.HasIndex(e => e.Id, "publishedAuthorDetails_id_key")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "publishedAuthorDetails_userId_key")
                    .IsUnique();

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("emailId");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IsCorrespondingAuthor).HasColumnName("isCorrespondingAuthor");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.SequenceNumber).HasColumnName("sequenceNumber");
            });

            modelBuilder.Entity<PublishedFile>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpaceId })
                    .HasName("scheduledFiles_pkey");

                entity.ToTable("publishedFiles");

                entity.HasIndex(e => new { e.SpaceId, e.ArticleId, e.AssetId, e.FileId }, "scheduledFiles_spaceId_articleId_assetId_fileId_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"scheduledFiles_id_seq\"'::regclass)");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.AssetId).HasColumnName("assetId");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("time without time zone")
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FileId).HasColumnName("fileId");

                entity.Property(e => e.JobId).HasColumnName("jobId");

                entity.Property(e => e.LoggedInUserId).HasColumnName("loggedInUserId");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("time without time zone")
                    .HasColumnName("modificationDate");

                entity.Property(e => e.PublishedDateTime).HasColumnName("publishedDateTime");

                entity.Property(e => e.PublishedStatusId).HasColumnName("publishedStatusId");

                entity.Property(e => e.ScheduledDateTime).HasColumnName("scheduledDateTime");

                entity.HasOne(d => d.LoggedInUser)
                    .WithMany(p => p.PublishedFiles)
                    .HasForeignKey(d => d.LoggedInUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("scheduledFiles_loggedInUserId_fkey");

                entity.HasOne(d => d.PublishedStatus)
                    .WithMany(p => p.PublishedFiles)
                    .HasForeignKey(d => d.PublishedStatusId)
                    .HasConstraintName("scheduledFiles_publishedStatusId_fkey");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.PublishedFiles)
                    .HasForeignKey(d => new { d.SpaceId, d.ArticleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("scheduledFiles_spaceId_articleId_fkey");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.PublishedFiles)
                    .HasForeignKey(d => new { d.SpaceId, d.AssetId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("scheduledFiles_spaceId_assetId_fkey");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.PublishedFiles)
                    .HasForeignKey(d => new { d.SpaceId, d.FileId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("scheduledFiles_spaceId_fileId_fkey");
            });

            modelBuilder.Entity<PublishedKeyword>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpaceId, e.ArticleId })
                    .HasName("publishedKeywords_pkey");

                entity.ToTable("publishedKeywords");

                entity.HasIndex(e => e.Id, "publishedKeywords_id_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasColumnName("keyword");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.SequenceNumber).HasColumnName("sequenceNumber");
            });

            modelBuilder.Entity<PublishedStatus>(entity =>
            {
                entity.ToTable("publishedStatuses");

                entity.HasIndex(e => e.Code, "publishedStatuses_code_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "publishedStatuses_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.CodeNavigation)
                    .WithOne(p => p.PublishedStatus)
                    .HasForeignKey<PublishedStatus>(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("publishedStatuses_code_fkey");
            });

            modelBuilder.Entity<PublishedStatusesCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("publishedStatusesCode_pkey");

                entity.ToTable("publishedStatusesCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            modelBuilder.Entity<RoleCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("roleCode_pkey");

                entity.ToTable("roleCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            modelBuilder.Entity<Stage>(entity =>
            {
                entity.ToTable("stage");

                entity.HasIndex(e => e.Code, "stage_code_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "stage_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"ArticleStage_Code_seq\"'::regclass)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.CodeNavigation)
                    .WithOne(p => p.Stage)
                    .HasForeignKey<Stage>(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("stage_code_fkey");
            });

            modelBuilder.Entity<StageCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("stageCode_pkey");

                entity.ToTable("stageCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            modelBuilder.Entity<StageHistory>(entity =>
            {
                entity.HasKey(e => new { e.SpaceId, e.Id })
                    .HasName("stageHistory_pkey");

                entity.ToTable("stageHistory");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"ArticleStageHistory_ArticleStageHistoryId_seq\"'::regclass)");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.StageId).HasColumnName("stageId");

                entity.Property(e => e.StartDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("startDate");
            });

            modelBuilder.Entity<Submission>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpaceId })
                    .HasName("submission_pkey");

                entity.ToTable("submission");

                entity.HasIndex(e => new { e.ArticleId, e.SpaceId }, "submission_spaceId_articleId_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"ProductionArticleSubmission_ProductionArticleSubmissionId_seq\"'::regclass)");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.ArticleTypeId).HasColumnName("articleTypeId");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Doi)
                    .IsRequired()
                    .HasColumnName("doi");

                entity.Property(e => e.JournalName)
                    .IsRequired()
                    .HasColumnName("journalName");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("modificationDate");

                entity.Property(e => e.SectionId).HasColumnName("sectionId");

                entity.Property(e => e.SectionName).HasColumnName("sectionName");

                entity.Property(e => e.SubmissionDate).HasColumnName("submissionDate");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Typesetter>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SpaceId })
                    .HasName("typesetter_pkey");

                entity.ToTable("typesetter");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("isDefault")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Typesetters)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("typesetter_id_fkey");
            });

            modelBuilder.Entity<UploadRequest>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpaceId })
                    .HasName("uploadRequest_pkey");

                entity.ToTable("uploadRequest");

                entity.HasIndex(e => e.Id, "uploadRequest_Id_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"ProductionArticleRequest_ProductionArticleRequestId_seq\"'::regclass)");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.ArticleId).HasColumnName("articleId");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.CompletedDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("completedDate");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.RequestDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("requestDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UploadRequests)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("uploadRequest_userId_fkey");
            });

            modelBuilder.Entity<UploadRequestFile>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpaceId })
                    .HasName("uploadRequestFile_pkey");

                entity.ToTable("uploadRequestFile");

                entity.HasIndex(e => e.Id, "uploadRequestFile_id_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"ProductionArticleRequestFile_ProductionArticleRequestFileId_seq\"'::regclass)");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.AssetId).HasColumnName("assetId");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Extension).HasColumnName("extension");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.OriginalFileId).HasColumnName("originalFileId");

                entity.Property(e => e.ProvisionDate)
                    .HasColumnType("timestamp with time zone")
                    .HasColumnName("provisionDate");

                entity.Property(e => e.UploadRequestId).HasColumnName("uploadRequestId");

                entity.HasOne(d => d.UploadRequest)
                    .WithMany(p => p.UploadRequestFiles)
                    .HasForeignKey(d => new { d.UploadRequestId, d.SpaceId })
                    .HasConstraintName("uploadRequestFile_spaceId_uploadRequestId_fkey");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.FirstName).HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName");

                entity.Property(e => e.MiddleName).HasColumnName("middleName");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");
            });

            modelBuilder.Entity<ZipContentFile>(entity =>
            {
                entity.HasKey(e => new { e.SpaceId, e.Id })
                    .HasName("zipContentFile_pkey");

                entity.ToTable("zipContentFile");

                entity.HasIndex(e => e.Id, "zipContentFile_id_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.SpaceId, e.FileId }, "zipContentFile_spaceId_fileId_idx");

                entity.HasIndex(e => e.TypeId, "zipContentFile_typeId_idx");

                entity.Property(e => e.SpaceId).HasColumnName("spaceId");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('\"ArticleZipContentFile_ArticleZipContentFileId_seq\"'::regclass)");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("extension");

                entity.Property(e => e.FileId).HasColumnName("fileId");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ZipContentFiles)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("ProductionArticleZipContentFile_ProductionArticleZipContentF");
            });

            modelBuilder.Entity<ZipContentFileType>(entity =>
            {
                entity.ToTable("zipContentFileType");

                entity.HasIndex(e => e.Code, "zipContentFileType_code_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "zipContentFileType_name_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.ModificationDate).HasColumnName("modificationDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.HasOne(d => d.CodeNavigation)
                    .WithOne(p => p.ZipContentFileType)
                    .HasForeignKey<ZipContentFileType>(d => d.Code)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zipContentFileType_code_fkey");
            });

            modelBuilder.Entity<ZipContentFileTypeCode>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("zipContentFileTypeCode_pkey");

                entity.ToTable("zipContentFileTypeCode");

                entity.Property(e => e.Code).HasColumnName("code");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
