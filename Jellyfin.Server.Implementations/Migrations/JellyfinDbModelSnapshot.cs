﻿// <auto-generated />
using System;
using Jellyfin.Server.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Jellyfin.Server.Implementations.Migrations
{
    [DbContext(typeof(JellyfinDb))]
    partial class JellyfinDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("jellyfin")
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Jellyfin.Data.Entities.AccessSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("INTEGER");

                    b.Property<double>("EndHour")
                        .HasColumnType("REAL");

                    b.Property<double>("StartHour")
                        .HasColumnType("REAL");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AccessSchedule");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.ActivityLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemId")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<int>("LogSeverity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(512);

                    b.Property<string>("Overview")
                        .HasColumnType("TEXT")
                        .HasMaxLength(512);

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShortOverview")
                        .HasColumnType("TEXT")
                        .HasMaxLength(512);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ActivityLogs");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Group_Groups_Guid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Group_Groups_Guid");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.ImageInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ImageInfo");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kind")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("Permission_GroupPermissions_Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Permission_Permissions_Guid")
                        .HasColumnType("TEXT");

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Permission_GroupPermissions_Id");

                    b.HasIndex("Permission_Permissions_Guid");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.Preference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kind")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("Preference_Preferences_Guid")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("Preference_Preferences_Id")
                        .HasColumnType("TEXT");

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(65535);

                    b.HasKey("Id");

                    b.HasIndex("Preference_Preferences_Guid");

                    b.HasIndex("Preference_Preferences_Id");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.ProviderMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProviderData")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(65535);

                    b.Property<Guid?>("ProviderMapping_ProviderMappings_Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("ProviderSecrets")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(65535);

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProviderMapping_ProviderMappings_Id");

                    b.ToTable("ProviderMapping");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AudioLanguagePreference")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("AuthenticationProviderId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<bool>("DisplayCollectionsView")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DisplayMissingEpisodes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EasyPassword")
                        .HasColumnType("TEXT")
                        .HasMaxLength(65535);

                    b.Property<bool>("EnableAutoLogin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableLocalPassword")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableNextEpisodeAutoPlay")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("EnableUserPreferenceAccess")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HidePlayedInLatest")
                        .HasColumnType("INTEGER");

                    b.Property<long>("InternalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InvalidLoginAttemptCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastActivityDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LoginAttemptsBeforeLockout")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MaxParentalAgeRating")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MustUpdatePassword")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT")
                        .HasMaxLength(65535);

                    b.Property<string>("PasswordResetProviderId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<bool>("PlayDefaultAudioTrack")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProfileImageId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RememberAudioSelections")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RememberSubtitleSelections")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RemoteClientBitrateLimit")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("RowVersion")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubtitleLanguagePreference")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<int>("SubtitleMode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("ProfileImageId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.AccessSchedule", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithMany("AccessSchedules")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.Group", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithMany("Groups")
                        .HasForeignKey("Group_Groups_Guid");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.Permission", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.Group", null)
                        .WithMany("Permissions")
                        .HasForeignKey("Permission_GroupPermissions_Id");

                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithMany("Permissions")
                        .HasForeignKey("Permission_Permissions_Guid");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.Preference", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithMany("Preferences")
                        .HasForeignKey("Preference_Preferences_Guid");

                    b.HasOne("Jellyfin.Data.Entities.Group", null)
                        .WithMany("Preferences")
                        .HasForeignKey("Preference_Preferences_Id");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.ProviderMapping", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.Group", null)
                        .WithMany("ProviderMappings")
                        .HasForeignKey("ProviderMapping_ProviderMappings_Id");

                    b.HasOne("Jellyfin.Data.Entities.User", null)
                        .WithMany("ProviderMappings")
                        .HasForeignKey("ProviderMapping_ProviderMappings_Id");
                });

            modelBuilder.Entity("Jellyfin.Data.Entities.User", b =>
                {
                    b.HasOne("Jellyfin.Data.Entities.ImageInfo", "ProfileImage")
                        .WithMany()
                        .HasForeignKey("ProfileImageId");
                });
#pragma warning restore 612, 618
        }
    }
}
