﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Core.Models;

#nullable disable

namespace Dal
{
    public partial class TyottrContext : DbContext
    {
        public TyottrContext()
        {
        }

        public TyottrContext(DbContextOptions<TyottrContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcceptedExam> AcceptedExam { get; set; }
        public virtual DbSet<AcceptedExamUniversityMap> AcceptedExamUniversityMap { get; set; }
        public virtual DbSet<AcceptedUniversityExam> AcceptedUniversityExam { get; set; }
        public virtual DbSet<Artical> Artical { get; set; }
        public virtual DbSet<ArticalTagMap> ArticalTagMap { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Certifica> Certifica { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<College> College { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Cv> Cv { get; set; }
        public virtual DbSet<CvCertificaMap> CvCertificaMap { get; set; }
        public virtual DbSet<CvExperienceMap> CvExperienceMap { get; set; }
        public virtual DbSet<CvLanguageMap> CvLanguageMap { get; set; }
        public virtual DbSet<CvProjectMap> CvProjectMap { get; set; }
        public virtual DbSet<CvReferenceMap> CvReferenceMap { get; set; }
        public virtual DbSet<CvTalentMap> CvTalentMap { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<ExamLanguageMap> ExamLanguageMap { get; set; }
        public virtual DbSet<ExamUniversity> ExamUniversity { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Following> Following { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LanguageCollegeMap> LanguageCollegeMap { get; set; }
        public virtual DbSet<LnaguageUniversityMap> LnaguageUniversityMap { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsTagMap> NewsTagMap { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Reference> Reference { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleTaskMap> RoleTaskMap { get; set; }
        public virtual DbSet<RoomMessages> RoomMessages { get; set; }
        public virtual DbSet<Social> Social { get; set; }
        public virtual DbSet<StudingDegree> StudingDegree { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Talent> Talent { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TeamMemberMap> TeamMemberMap { get; set; }
        public virtual DbSet<TeamRoom> TeamRoom { get; set; }
        public virtual DbSet<University> University { get; set; }
        public virtual DbSet<UniversityComment> UniversityComment { get; set; }
        public virtual DbSet<UniversityGalery> UniversityGalery { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRoleMap> UserRoleMap { get; set; }
        public virtual DbSet<UserSetting> UserSetting { get; set; }
        public virtual DbSet<UserSocialMap> UserSocialMap { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<AcceptedExamUniversityMap>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.YearAccepte).IsFixedLength(true);

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.AcceptedExamUniversityMap)
                    .HasForeignKey(d => d.ExamId)
                    .HasConstraintName("FK_AcceptedExamUniversityMap_AcceptedExam");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.AcceptedExamUniversityMap)
                    .HasForeignKey(d => d.UniversityId)
                    .HasConstraintName("FK_AcceptedExamUniversityMap_University");
            });

            modelBuilder.Entity<AcceptedUniversityExam>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AcceptedExamUniversity)
                    .WithMany(p => p.AcceptedUniversityExamAcceptedExamUniversity)
                    .HasForeignKey(d => d.AcceptedExamUniversityId)
                    .HasConstraintName("FK_AcceptedUniversityExam_University1");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.AcceptedUniversityExamUniversity)
                    .HasForeignKey(d => d.UniversityId)
                    .HasConstraintName("FK_AcceptedUniversityExam_University");
            });

            modelBuilder.Entity<Artical>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Artical)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Artical_Category");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Artical)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_Artical_Language");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Artical)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Artical_User");
            });

            modelBuilder.Entity<ArticalTagMap>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Artical)
                    .WithMany(p => p.ArticalTagMap)
                    .HasForeignKey(d => d.ArticalId)
                    .HasConstraintName("FK_ArticalTagMap_Artical");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ArticalTagMap)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_ArticalTagMap_Tag");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Certifica>(entity =>
            {
                entity.Property(e => e.EndYear).IsFixedLength(true);

                entity.Property(e => e.GraduateGrade).IsFixedLength(true);

                entity.Property(e => e.StartYear).IsFixedLength(true);
            });

            modelBuilder.Entity<College>(entity =>
            {
                entity.Property(e => e.isActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone).IsFixedLength(true);

                entity.HasOne(d => d.Degree)
                    .WithMany(p => p.College)
                    .HasForeignKey(d => d.DegreeId)
                    .HasConstraintName("FK_College_StudingDegree");

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.College)
                    .HasForeignKey(d => d.FacultyId)
                    .HasConstraintName("FK_College_Faculty");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_Comment_Artical");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Comment_User");
            });

            modelBuilder.Entity<Cv>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Cv)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CV_User");
            });

            modelBuilder.Entity<CvCertificaMap>(entity =>
            {
                entity.HasOne(d => d.Certifica)
                    .WithMany(p => p.CvCertificaMap)
                    .HasForeignKey(d => d.CertificaId)
                    .HasConstraintName("FK_CvCertificaMap_Certifica");

                entity.HasOne(d => d.Cv)
                    .WithMany(p => p.CvCertificaMap)
                    .HasForeignKey(d => d.CvId)
                    .HasConstraintName("FK_CvCertificaMap_CV");
            });

            modelBuilder.Entity<CvExperienceMap>(entity =>
            {
                entity.HasOne(d => d.Cv)
                    .WithMany(p => p.CvExperienceMap)
                    .HasForeignKey(d => d.CvId)
                    .HasConstraintName("FK_CvExperienceMap_CV");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.CvExperienceMap)
                    .HasForeignKey(d => d.ExperienceId)
                    .HasConstraintName("FK_CvExperienceMap_Experience");
            });

            modelBuilder.Entity<CvLanguageMap>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Rate).IsFixedLength(true);

                entity.HasOne(d => d.Cv)
                    .WithMany(p => p.CvLanguageMap)
                    .HasForeignKey(d => d.CvId)
                    .HasConstraintName("FK_CvLanguageMap_CV");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.CvLanguageMap)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_CvLanguageMap_Language");
            });

            modelBuilder.Entity<CvProjectMap>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CvProjectMap)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_CvProjectMap_CV");

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.CvProjectMap)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_CvProjectMap_Project");
            });

            modelBuilder.Entity<CvReferenceMap>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Cv)
                    .WithMany(p => p.CvReferenceMap)
                    .HasForeignKey(d => d.CvId)
                    .HasConstraintName("FK_CvReferenceMap_CV");

                entity.HasOne(d => d.Reference)
                    .WithMany(p => p.CvReferenceMap)
                    .HasForeignKey(d => d.ReferenceId)
                    .HasConstraintName("FK_CvReferenceMap_Reference");
            });

            modelBuilder.Entity<CvTalentMap>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Cv)
                    .WithMany(p => p.CvTalentMap)
                    .HasForeignKey(d => d.CvId)
                    .HasConstraintName("FK_CvTalentMap_CV");

                entity.HasOne(d => d.Talent)
                    .WithMany(p => p.CvTalentMap)
                    .HasForeignKey(d => d.TalentId)
                    .HasConstraintName("FK_CvTalentMap_Talent");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ExamLanguageMap>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ExamLanguageMap)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_ExamLanguageMap_ExamYos");

                entity.HasOne(d => d.LanguageNavigation)
                    .WithMany(p => p.ExamLanguageMap)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_ExamLanguageMap_Language");
            });

            modelBuilder.Entity<ExamUniversity>(entity =>
            {
                entity.Property(e => e.AgeOfExam).IsFixedLength(true);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.ExamUniversity)
                    .HasForeignKey(d => d.UniversityId)
                    .HasConstraintName("FK_ExamYos_University");
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone).IsFixedLength(true);

                entity.HasOne(d => d.University)
                    .WithMany(p => p.Faculty)
                    .HasForeignKey(d => d.UniversityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Faculty_University");
            });

            modelBuilder.Entity<Following>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.FollowerUserNavigation)
                    .WithMany(p => p.FollowingFollowerUserNavigation)
                    .HasForeignKey(d => d.FollowerUser)
                    .HasConstraintName("FK_Following_User");

                entity.HasOne(d => d.FollowingUserNavigation)
                    .WithMany(p => p.FollowingFollowingUserNavigation)
                    .HasForeignKey(d => d.FollowingUser)
                    .HasConstraintName("FK_Following_User1");
            });

            modelBuilder.Entity<LanguageCollegeMap>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Rate).IsFixedLength(true);

                entity.HasOne(d => d.College)
                    .WithMany(p => p.LanguageCollegeMap)
                    .HasForeignKey(d => d.CollegeId)
                    .HasConstraintName("FK_LanguageCollegeMap_College");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LanguageCollegeMap)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_LanguageCollegeMap_Language");
            });

            modelBuilder.Entity<LnaguageUniversityMap>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LnaguageUniversityMap)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_LnaguageUniversityMap_Language");

                entity.HasOne(d => d.Univ)
                    .WithMany(p => p.LnaguageUniversityMap)
                    .HasForeignKey(d => d.UnivId)
                    .HasConstraintName("FK_LnaguageUniversityMap_University");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSeeing).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.SendToUserNavigation)
                    .WithMany(p => p.MessageSendToUserNavigation)
                    .HasForeignKey(d => d.SendToUser)
                    .HasConstraintName("FK_Message_User1");

                entity.HasOne(d => d.SenderUserNavigation)
                    .WithMany(p => p.MessageSenderUserNavigation)
                    .HasForeignKey(d => d.SenderUser)
                    .HasConstraintName("FK_Message_User");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_News_Category");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_News_Language");
            });

            modelBuilder.Entity<NewsTagMap>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.NewsTagMap)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK_NewsTagMap_News");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.NewsTagMap)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_NewsTagMap_Tag");
            });

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.Property(e => e.Number).IsFixedLength(true);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RoleTaskMap>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleTaskMap)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleTaskMap_Role");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.RoleTaskMap)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_RoleTaskMap_Task");
            });

            modelBuilder.Entity<RoomMessages>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.RoomMessages)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_RoomMessages_TeamMemberMap");

                entity.HasOne(d => d.TeamRoom)
                    .WithMany(p => p.RoomMessages)
                    .HasForeignKey(d => d.TeamRoomId)
                    .HasConstraintName("FK_RoomMessages_TeamRoom");
            });

            modelBuilder.Entity<Social>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<StudingDegree>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Talent>(entity =>
            {
                entity.Property(e => e.Rate).IsFixedLength(true);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Leader)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.LeaderId)
                    .HasConstraintName("FK_Team_TeamMemberMap");
            });

            modelBuilder.Entity<TeamMemberMap>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.TeamNavigation)
                    .WithMany(p => p.TeamMemberMap)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_TeamMemberMap_Team");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TeamMemberMap)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TeamMemberMap_User");
            });

            modelBuilder.Entity<TeamRoom>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamRoom)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_TeamRoom_Team");
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone).IsFixedLength(true);

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.University)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_University_City");
            });

            modelBuilder.Entity<UniversityComment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.University)
                    .WithMany(p => p.UniversityComment)
                    .HasForeignKey(d => d.UniversityId)
                    .HasConstraintName("FK_UniversityComment_University");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UniversityComment)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UniversityComment_User");
            });

            modelBuilder.Entity<UniversityGalery>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVideo).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Uinversity)
                    .WithMany(p => p.UniversityGalery)
                    .HasForeignKey(d => d.UinversityId)
                    .HasConstraintName("FK_UniversityGalery_University");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Phone).IsFixedLength(true);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_User_City");
            });

            modelBuilder.Entity<UserRoleMap>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoleMap)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRoleMap_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoleMap)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRoleMap_User");
            });

            modelBuilder.Entity<UserSetting>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSetting)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserSetting_User");
            });

            modelBuilder.Entity<UserSocialMap>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Social)
                    .WithMany(p => p.UserSocialMap)
                    .HasForeignKey(d => d.SocialId)
                    .HasConstraintName("FK_UserSocialMap_Social");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSocialMap)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserSocialMap_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}