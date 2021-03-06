﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SF.Data;
using SF.Entitys;

namespace SF.WebHost.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20170327092217_AddInstallModule")]
    partial class AddInstallModule
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Core_RoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<long>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Value");

                    b.HasKey("UserId");

                    b.HasAlternateKey("UserId", "LoginProvider", "Name");

                    b.ToTable("Core_UserToken");
                });

            modelBuilder.Entity("SF.Core.AutoHistorys.Internal.AutoHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AfterJson");

                    b.Property<string>("BeforeJson");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Kind");

                    b.Property<string>("SourceId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Core_AutoHistory");
                });

            modelBuilder.Entity("SF.Core.Infrastructure.Modules.InstalledModule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<DateTime>("DateActivated");

                    b.Property<DateTime>("DateDeactivated");

                    b.Property<DateTime>("DateInstalled");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<bool>("Installed");

                    b.Property<string>("ModuleAssemblyName");

                    b.Property<string>("ModuleName");

                    b.Property<string>("ModuleVersion");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Core_InstalledModule");
                });

            modelBuilder.Entity("SF.Core.Infrastructure.Plugins.Models.InstalledPlugin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<DateTime>("DateActivated");

                    b.Property<DateTime>("DateDeactivated");

                    b.Property<DateTime>("DateInstalled");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<bool>("Installed");

                    b.Property<string>("PluginAssemblyName");

                    b.Property<string>("PluginName");

                    b.Property<string>("PluginVersion");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Core_InstalledPlugin");
                });

            modelBuilder.Entity("SF.Entitys.AddressEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("ContactName");

                    b.Property<long>("CountryId");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<long>("DistrictId");

                    b.Property<string>("Phone");

                    b.Property<int>("SortIndex");

                    b.Property<long>("StateOrProvinceId");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("StateOrProvinceId");

                    b.ToTable("Entitys_AddressEntity");
                });

            modelBuilder.Entity("SF.Entitys.CountryEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Name");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Entitys_CountryEntity");
                });

            modelBuilder.Entity("SF.Entitys.DistrictEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<int>("SortIndex");

                    b.Property<long>("StateOrProvinceId");

                    b.Property<string>("Type");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("StateOrProvinceId");

                    b.ToTable("Entitys_DistrictEntity");
                });

            modelBuilder.Entity("SF.Entitys.EntityType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Name");

                    b.Property<string>("RoutingAction");

                    b.Property<string>("RoutingController");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Entitys_EntityType");
                });

            modelBuilder.Entity("SF.Entitys.MediaEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("FileName");

                    b.Property<int>("FileSize");

                    b.Property<int>("MediaType");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Entitys_MediaEntity");
                });

            modelBuilder.Entity("SF.Entitys.ModuleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AllowDelete");

                    b.Property<int?>("AllowEdit");

                    b.Property<int?>("AllowExpand");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<int?>("DeleteMark");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Description")
                        .HasMaxLength(280);

                    b.Property<string>("EnCode")
                        .HasMaxLength(127);

                    b.Property<int?>("EnabledMark");

                    b.Property<string>("FullName")
                        .HasMaxLength(127);

                    b.Property<string>("Icon")
                        .HasMaxLength(127);

                    b.Property<int?>("IsMenu");

                    b.Property<int?>("IsPublic");

                    b.Property<long?>("ParentId");

                    b.Property<int>("SortIndex");

                    b.Property<string>("Target")
                        .HasMaxLength(127);

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<string>("UrlAddress")
                        .HasMaxLength(127);

                    b.HasKey("Id");

                    b.ToTable("Core_Module");
                });

            modelBuilder.Entity("SF.Entitys.NotificationEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttemptCount");

                    b.Property<string>("Body");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsSuccessSend");

                    b.Property<string>("Language")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("LastFailAttemptDate");

                    b.Property<string>("LastFailAttemptMessage");

                    b.Property<int>("MaxAttemptCount");

                    b.Property<string>("ObjectId")
                        .HasMaxLength(128);

                    b.Property<string>("ObjectTypeId")
                        .HasMaxLength(128);

                    b.Property<string>("Recipient")
                        .HasMaxLength(128);

                    b.Property<string>("Sender")
                        .HasMaxLength(128);

                    b.Property<string>("SendingGateway")
                        .HasMaxLength(128);

                    b.Property<DateTime?>("SentDate");

                    b.Property<int>("SortIndex");

                    b.Property<DateTime?>("StartSendingDate");

                    b.Property<string>("Subject")
                        .HasMaxLength(512);

                    b.Property<string>("Type")
                        .HasMaxLength(128);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Entitys_NotificationEntity");
                });

            modelBuilder.Entity("SF.Entitys.NotificationTemplateEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Language")
                        .HasMaxLength(10);

                    b.Property<string>("NotificationTypeId")
                        .HasMaxLength(128);

                    b.Property<string>("ObjectId")
                        .HasMaxLength(128);

                    b.Property<string>("ObjectTypeId")
                        .HasMaxLength(128);

                    b.Property<string>("Recipient");

                    b.Property<string>("Sender");

                    b.Property<int>("SortIndex");

                    b.Property<string>("Subject");

                    b.Property<string>("TemplateEngine")
                        .HasMaxLength(64);

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Entitys_NotificationTemplateEntity");
                });

            modelBuilder.Entity("SF.Entitys.PermissionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActionAddress");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Description");

                    b.Property<long>("ModuleId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Core_Permission");
                });

            modelBuilder.Entity("SF.Entitys.RoleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<int>("Enabled");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.Property<long>("SiteId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Core_Role");
                });

            modelBuilder.Entity("SF.Entitys.RoleModuleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<long>("ModuleId");

                    b.Property<long>("RoleId");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Core_RoleModule");
                });

            modelBuilder.Entity("SF.Entitys.RolePermissionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<long>("PermissionId");

                    b.Property<long>("RoleId");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("Core_RolePermission");
                });

            modelBuilder.Entity("SF.Entitys.SettingEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Description")
                        .HasMaxLength(1024);

                    b.Property<bool>("IsEnum");

                    b.Property<bool>("IsLocaleDependant");

                    b.Property<bool>("IsMultiValue");

                    b.Property<bool>("IsSystem");

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("ObjectType")
                        .HasMaxLength(128);

                    b.Property<string>("SettingValueType")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Core_SettingValue");
                });

            modelBuilder.Entity("SF.Entitys.SettingValueEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("BooleanValue");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<DateTime?>("DateTimeValue");

                    b.Property<decimal>("DecimalValue");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<int>("IntegerValue");

                    b.Property<string>("Locale")
                        .HasMaxLength(64);

                    b.Property<string>("LongTextValue");

                    b.Property<long>("SettingId");

                    b.Property<string>("ShortTextValue")
                        .HasMaxLength(512);

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("SettingId");

                    b.ToTable("Entitys_SettingValueEntity");
                });

            modelBuilder.Entity("SF.Entitys.SiteHost", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("HostName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<long>("SiteId");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("HostName");

                    b.HasIndex("SiteId");

                    b.ToTable("Core_SiteHost");
                });

            modelBuilder.Entity("SF.Entitys.SiteSettings", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountApprovalEmailCsv");

                    b.Property<string>("AddThisDotComUsername")
                        .HasMaxLength(50);

                    b.Property<string>("AliasId")
                        .HasMaxLength(36);

                    b.Property<bool>("AllowDbFallbackWithLdap");

                    b.Property<bool>("AllowNewRegistration");

                    b.Property<bool>("AllowPersistentLogin");

                    b.Property<bool>("AutoCreateLdapUserOnFirstLogin");

                    b.Property<bool>("CaptchaOnLogin");

                    b.Property<bool>("CaptchaOnRegistration");

                    b.Property<string>("CompanyCountry")
                        .HasMaxLength(10);

                    b.Property<string>("CompanyFax")
                        .HasMaxLength(20);

                    b.Property<string>("CompanyLocality")
                        .HasMaxLength(200);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(250);

                    b.Property<string>("CompanyPhone")
                        .HasMaxLength(20);

                    b.Property<string>("CompanyPostalCode")
                        .HasMaxLength(20);

                    b.Property<string>("CompanyPublicEmail")
                        .HasMaxLength(100);

                    b.Property<string>("CompanyRegion")
                        .HasMaxLength(200);

                    b.Property<string>("CompanyStreetAddress")
                        .HasMaxLength(250);

                    b.Property<string>("CompanyStreetAddress2")
                        .HasMaxLength(250);

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DefaultEmailFromAddress")
                        .HasMaxLength(100);

                    b.Property<string>("DefaultEmailFromAlias")
                        .HasMaxLength(100);

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<bool>("DisableDbAuth");

                    b.Property<string>("DkimDomain")
                        .HasMaxLength(255);

                    b.Property<string>("DkimPrivateKey");

                    b.Property<string>("DkimPublicKey");

                    b.Property<string>("DkimSelector")
                        .HasMaxLength(128);

                    b.Property<bool>("EmailLdapDbFallback");

                    b.Property<bool>("EnabledAuthorization");

                    b.Property<string>("FacebookAppId")
                        .HasMaxLength(100);

                    b.Property<string>("FacebookAppSecret");

                    b.Property<string>("GoogleAnalyticsProfileId")
                        .HasMaxLength(25);

                    b.Property<string>("GoogleClientId")
                        .HasMaxLength(100);

                    b.Property<string>("GoogleClientSecret");

                    b.Property<bool>("IsDataProtected");

                    b.Property<bool>("IsServerAdminSite");

                    b.Property<string>("LdapDomain")
                        .HasMaxLength(255);

                    b.Property<int>("LdapPort");

                    b.Property<string>("LdapRootDN")
                        .HasMaxLength(255);

                    b.Property<string>("LdapServer")
                        .HasMaxLength(255);

                    b.Property<string>("LdapUserDNKey")
                        .HasMaxLength(10);

                    b.Property<string>("LoginInfoBottom");

                    b.Property<string>("LoginInfoTop");

                    b.Property<int>("MaxInvalidPasswordAttempts");

                    b.Property<string>("MicrosoftClientId")
                        .HasMaxLength(100);

                    b.Property<string>("MicrosoftClientSecret");

                    b.Property<int>("MinRequiredPasswordLength");

                    b.Property<string>("OidConnectAppId")
                        .HasMaxLength(255);

                    b.Property<string>("OidConnectAppSecret");

                    b.Property<string>("PreferredHostName")
                        .HasMaxLength(250);

                    b.Property<string>("PrivacyPolicy");

                    b.Property<bool>("ReallyDeleteUsers");

                    b.Property<string>("RecaptchaPrivateKey")
                        .HasMaxLength(255);

                    b.Property<string>("RecaptchaPublicKey")
                        .HasMaxLength(255);

                    b.Property<string>("RegistrationAgreement");

                    b.Property<string>("RegistrationPreamble");

                    b.Property<bool>("RequireApprovalBeforeLogin");

                    b.Property<bool>("RequireConfirmedEmail");

                    b.Property<bool>("RequireConfirmedPhone");

                    b.Property<bool>("RequiresQuestionAndAnswer");

                    b.Property<bool>("SignEmailWithDkim");

                    b.Property<string>("SiteFolderName")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("")
                        .HasMaxLength(50);

                    b.Property<bool>("SiteIsClosed");

                    b.Property<string>("SiteIsClosedMessage");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("SmsClientId")
                        .HasMaxLength(255);

                    b.Property<string>("SmsFrom")
                        .HasMaxLength(100);

                    b.Property<string>("SmsSecureToken");

                    b.Property<string>("SmtpPassword");

                    b.Property<int>("SmtpPort");

                    b.Property<string>("SmtpPreferredEncoding")
                        .HasMaxLength(20);

                    b.Property<bool>("SmtpRequiresAuth");

                    b.Property<string>("SmtpServer")
                        .HasMaxLength(200);

                    b.Property<bool>("SmtpUseSsl");

                    b.Property<string>("SmtpUser")
                        .HasMaxLength(500);

                    b.Property<int>("SortIndex");

                    b.Property<string>("Theme")
                        .HasMaxLength(100);

                    b.Property<string>("TimeZoneId")
                        .HasMaxLength(50);

                    b.Property<string>("TwitterConsumerKey")
                        .HasMaxLength(100);

                    b.Property<string>("TwitterConsumerSecret");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<bool>("UseEmailForLogin");

                    b.Property<bool>("UseLdapAuth");

                    b.HasKey("Id");

                    b.HasIndex("AliasId");

                    b.HasIndex("SiteFolderName");

                    b.ToTable("Core_SiteSettings");
                });

            modelBuilder.Entity("SF.Entitys.StateOrProvinceEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CountryId");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Name");

                    b.Property<int>("SortIndex");

                    b.Property<string>("Type");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Entitys_StateOrProvinceEntity");
                });

            modelBuilder.Entity("SF.Entitys.UrlSlugEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<long>("EntityId");

                    b.Property<long>("EntityTypeId");

                    b.Property<string>("Slug");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("EntityTypeId");

                    b.ToTable("Entitys_UrlSlugEntity");
                });

            modelBuilder.Entity("SF.Entitys.UserAddressEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AddressId");

                    b.Property<int>("AddressType");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<DateTimeOffset?>("LastUsedOn");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Entitys_UserAddressEntity");
                });

            modelBuilder.Entity("SF.Entitys.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<bool>("AccountApproved");

                    b.Property<string>("AccountState")
                        .HasMaxLength(128);

                    b.Property<DateTime?>("AllowEndTime");

                    b.Property<DateTime?>("AllowStartTime");

                    b.Property<string>("AnswerQuestion");

                    b.Property<string>("AvatarUrl");

                    b.Property<DateTime?>("Birthday");

                    b.Property<int?>("CheckOnLine");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<long?>("CurrentShippingAddressId");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<long?>("DepartmentId");

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<long?>("DutyId");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<DateTime?>("FirstVisit");

                    b.Property<string>("Gender");

                    b.Property<bool>("IsAdministrator");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsLockedOut");

                    b.Property<DateTime?>("LastVisit");

                    b.Property<DateTime?>("LockEndDate");

                    b.Property<DateTime?>("LockStartDate");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<int?>("LogOnCount");

                    b.Property<string>("MSN");

                    b.Property<long?>("ManagerId");

                    b.Property<string>("Mobile");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("OICQ");

                    b.Property<long?>("OrganizeId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<long?>("PostId");

                    b.Property<DateTime?>("PreviousVisit");

                    b.Property<string>("Question");

                    b.Property<int?>("SecurityLevel");

                    b.Property<string>("SecurityStamp");

                    b.Property<long>("SiteId");

                    b.Property<string>("TimeZoneId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<Guid>("UserGuid");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("UserNo");

                    b.Property<int?>("UserOnLine");

                    b.Property<string>("UserType")
                        .HasMaxLength(128);

                    b.Property<string>("WeChat");

                    b.Property<string>("WebSiteUrl");

                    b.Property<long?>("WorkGroupId");

                    b.HasKey("Id");

                    b.HasIndex("CurrentShippingAddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Core_User");
                });

            modelBuilder.Entity("SF.Entitys.UserLocation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CaptureCount");

                    b.Property<string>("City")
                        .HasMaxLength(255);

                    b.Property<string>("Continent")
                        .HasMaxLength(255);

                    b.Property<string>("Country")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<DateTime>("FirstCaptureUtc");

                    b.Property<string>("HostName")
                        .HasMaxLength(255);

                    b.Property<string>("IpAddress")
                        .HasMaxLength(50);

                    b.Property<long>("IpAddressLong");

                    b.Property<string>("Isp")
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastCaptureUtc");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Region")
                        .HasMaxLength(255);

                    b.Property<long>("SiteId");

                    b.Property<int>("SortIndex");

                    b.Property<string>("TimeZone")
                        .HasMaxLength(255);

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("IpAddress");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserLocation");
                });

            modelBuilder.Entity("SF.Entitys.UserRoleEntity", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<long>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Core_UserRole");
                });

            modelBuilder.Entity("SF.Module.ActivityLog.Models.ActivityEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ActivityTypeId");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<long>("EntityId");

                    b.Property<long>("EntityTypeId");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ActivityTypeId");

                    b.ToTable("Core_Activity");
                });

            modelBuilder.Entity("SF.Module.ActivityLog.Models.ActivityTypeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Core_ActivityType");
                });

            modelBuilder.Entity("SF.Module.Backend.Data.Entitys.AreaEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreaCode")
                        .HasMaxLength(127);

                    b.Property<string>("AreaName")
                        .HasMaxLength(127);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<int?>("DeleteMark");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Description")
                        .HasMaxLength(280);

                    b.Property<int?>("EnabledMark");

                    b.Property<int?>("Layer");

                    b.Property<long?>("ParentId");

                    b.Property<string>("QuickQuery")
                        .HasMaxLength(127);

                    b.Property<string>("SimpleSpelling")
                        .HasMaxLength(127);

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Backend_AreaEntity");
                });

            modelBuilder.Entity("SF.Module.Backend.Data.Entitys.DataItemDetailEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<int?>("DeleteMark");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<int?>("EnabledMark");

                    b.Property<int?>("IsDefault");

                    b.Property<string>("ItemCode");

                    b.Property<long>("ItemId");

                    b.Property<string>("ItemName");

                    b.Property<string>("ItemValue");

                    b.Property<long?>("ParentId");

                    b.Property<string>("QuickQuery");

                    b.Property<string>("SimpleSpelling");

                    b.Property<int?>("SortCode");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Core_DataItemDetail");
                });

            modelBuilder.Entity("SF.Module.Backend.Data.Entitys.DataItemEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<int?>("DeleteMark");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<int?>("EnabledMark");

                    b.Property<int?>("IsNav");

                    b.Property<int?>("IsTree");

                    b.Property<string>("ItemCode")
                        .HasMaxLength(1000);

                    b.Property<string>("ItemName")
                        .HasMaxLength(1000);

                    b.Property<long?>("ParentId");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Core_DataItem");
                });

            modelBuilder.Entity("SF.Module.Backend.Data.Entitys.DepartmentEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Description")
                        .HasMaxLength(280);

                    b.Property<string>("Email");

                    b.Property<string>("EnCode")
                        .HasMaxLength(127);

                    b.Property<int?>("EnabledMark");

                    b.Property<string>("Fax");

                    b.Property<string>("FullName")
                        .HasMaxLength(127);

                    b.Property<string>("InnerPhone");

                    b.Property<int?>("Layer");

                    b.Property<string>("Manager");

                    b.Property<long?>("ManagerId");

                    b.Property<string>("Nature");

                    b.Property<long?>("OrganizeId");

                    b.Property<string>("OuterPhone");

                    b.Property<long?>("ParentId");

                    b.Property<string>("ShortName");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Backend_DepartmentEntity");
                });

            modelBuilder.Entity("SF.Module.Backend.Data.Entitys.DMOSEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Category");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<long?>("DepartmentId");

                    b.Property<string>("Description")
                        .HasMaxLength(280);

                    b.Property<string>("EnCode")
                        .HasMaxLength(127);

                    b.Property<int?>("EnabledMark");

                    b.Property<string>("FullName")
                        .HasMaxLength(127);

                    b.Property<long?>("OrganizeId");

                    b.Property<DateTime?>("OverdueTime");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Backend_DMOSEntity");
                });

            modelBuilder.Entity("SF.Module.Backend.Data.Entitys.OrganizeEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("BusinessScope");

                    b.Property<int?>("Category");

                    b.Property<long?>("CityId");

                    b.Property<long?>("CountyId");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Description")
                        .HasMaxLength(280);

                    b.Property<string>("Email");

                    b.Property<string>("EnCode")
                        .HasMaxLength(127);

                    b.Property<int?>("EnabledMark");

                    b.Property<string>("Fax");

                    b.Property<DateTime?>("FoundedTime");

                    b.Property<string>("FullName")
                        .HasMaxLength(127);

                    b.Property<string>("InnerPhone");

                    b.Property<int?>("Layer");

                    b.Property<string>("Manager");

                    b.Property<string>("ManagerId");

                    b.Property<string>("Nature");

                    b.Property<string>("OuterPhone");

                    b.Property<long?>("ParentId");

                    b.Property<string>("Postalcode");

                    b.Property<long?>("ProvinceId");

                    b.Property<string>("ShortName");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<string>("WebAddress");

                    b.HasKey("Id");

                    b.ToTable("Backend_OrganizeEntity");
                });

            modelBuilder.Entity("SF.Module.Localization.Models.CultureEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Name");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Localization_CultureEntity");
                });

            modelBuilder.Entity("SF.Module.Localization.Models.ResourceEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<long?>("CultureId");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTimeOffset?>("DeletedOn");

                    b.Property<string>("Key");

                    b.Property<int>("SortIndex");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CultureId");

                    b.ToTable("Localization_ResourceEntity");
                });

            modelBuilder.Entity("SF.Module.LoggingStorage.Models.LogItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Culture")
                        .HasMaxLength(10);

                    b.Property<int>("EventId");

                    b.Property<string>("IpAddress")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LogDateUtc")
                        .HasColumnName("LogDate");

                    b.Property<string>("LogLevel")
                        .HasMaxLength(20);

                    b.Property<string>("Logger")
                        .HasMaxLength(255);

                    b.Property<string>("Message");

                    b.Property<string>("ShortUrl")
                        .HasMaxLength(255);

                    b.Property<string>("StateJson");

                    b.Property<string>("Thread")
                        .HasMaxLength(255);

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Code_SystemLog");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("SF.Entitys.RoleEntity")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("SF.Entitys.UserEntity")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("SF.Entitys.UserEntity")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SF.Entitys.AddressEntity", b =>
                {
                    b.HasOne("SF.Entitys.CountryEntity", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("SF.Entitys.DistrictEntity", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("SF.Entitys.StateOrProvinceEntity", "StateOrProvince")
                        .WithMany()
                        .HasForeignKey("StateOrProvinceId");
                });

            modelBuilder.Entity("SF.Entitys.DistrictEntity", b =>
                {
                    b.HasOne("SF.Entitys.StateOrProvinceEntity", "StateOrProvince")
                        .WithMany()
                        .HasForeignKey("StateOrProvinceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SF.Entitys.RoleModuleEntity", b =>
                {
                    b.HasOne("SF.Entitys.ModuleEntity", "Module")
                        .WithMany("RoleModules")
                        .HasForeignKey("ModuleId");

                    b.HasOne("SF.Entitys.RoleEntity", "Role")
                        .WithMany("RoleModules")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("SF.Entitys.RolePermissionEntity", b =>
                {
                    b.HasOne("SF.Entitys.PermissionEntity", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId");

                    b.HasOne("SF.Entitys.RoleEntity", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("SF.Entitys.SettingValueEntity", b =>
                {
                    b.HasOne("SF.Entitys.SettingEntity", "Setting")
                        .WithMany("SettingValues")
                        .HasForeignKey("SettingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SF.Entitys.StateOrProvinceEntity", b =>
                {
                    b.HasOne("SF.Entitys.CountryEntity", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SF.Entitys.UrlSlugEntity", b =>
                {
                    b.HasOne("SF.Entitys.EntityType", "EntityType")
                        .WithMany()
                        .HasForeignKey("EntityTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SF.Entitys.UserAddressEntity", b =>
                {
                    b.HasOne("SF.Entitys.AddressEntity", "Address")
                        .WithMany("UserAddresses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SF.Entitys.UserEntity", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SF.Entitys.UserEntity", b =>
                {
                    b.HasOne("SF.Entitys.UserAddressEntity", "CurrentShippingAddress")
                        .WithMany()
                        .HasForeignKey("CurrentShippingAddressId");
                });

            modelBuilder.Entity("SF.Entitys.UserRoleEntity", b =>
                {
                    b.HasOne("SF.Entitys.RoleEntity", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SF.Entitys.UserEntity", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SF.Module.ActivityLog.Models.ActivityEntity", b =>
                {
                    b.HasOne("SF.Module.ActivityLog.Models.ActivityTypeEntity", "ActivityType")
                        .WithMany("ActivityEntitys")
                        .HasForeignKey("ActivityTypeId");
                });

            modelBuilder.Entity("SF.Module.Backend.Data.Entitys.DataItemDetailEntity", b =>
                {
                    b.HasOne("SF.Module.Backend.Data.Entitys.DataItemEntity", "DataItem")
                        .WithMany("DataItemDetailEntitys")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SF.Module.Localization.Models.ResourceEntity", b =>
                {
                    b.HasOne("SF.Module.Localization.Models.CultureEntity", "Culture")
                        .WithMany("Resources")
                        .HasForeignKey("CultureId");
                });
        }
    }
}
