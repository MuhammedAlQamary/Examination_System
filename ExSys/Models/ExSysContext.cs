﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Data.Models;

public partial class ExSysContext : DbContext
{
    public ExSysContext()
    {
    }

    public ExSysContext(DbContextOptions<ExSysContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Choice> Choices { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentCourse> StudentCourses { get; set; }

    public virtual DbSet<StudentExamQuestion> StudentExamQuestions { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    public virtual DbSet<Track> Tracks { get; set; }


    #region functions for stored procedures for course
    //  make function for this stored procedure

    public void AddCourse(string courseName)
    {
        // Call the stored procedure using raw SQL query
        Database.ExecuteSqlRaw("EXEC dbo.AddCourse @Course_Name",
                           new SqlParameter("@Course_Name", courseName));
    }
    public void UpdateCourse(int courseId, string courseName)
    {
        // Call the stored procedure using Entity Framework
        Database.ExecuteSqlRaw("EXEC dbo.UpdateCourse @Course_ID, @Course_Name",
                           new SqlParameter("@Course_ID", courseId),
                           new SqlParameter("@Course_Name", courseName));
    }
    public void DeleteCourse(int courseId)
    {
        // Call the stored procedure using Entity Framework
        Database.ExecuteSqlRaw("EXEC dbo.DeleteCourse @Course_ID",
                              new SqlParameter("@Course_ID", courseId));
    }

    #endregion

    #region functions for stored procedures for student course

    // Method to execute stored procedure ShowStudentCourses













    #endregion

    #region functions for stored procedures for instructor
    public void AddInstructor(string instructorFname, string instructorLname, string instructorEmail, string instructorPassword)
    {
        // Call the stored procedure using raw SQL query
        Database.ExecuteSqlRaw("EXEC dbo.AddInstructor @Instructor_Fname, @Instructor_Lname, @Instructor_Email, @Instructor_Password",
                                      new SqlParameter("@Instructor_Fname", instructorFname),
                                      new SqlParameter("@Instructor_Lname", instructorLname),
                                      new SqlParameter("@Instructor_Email", instructorEmail),
                                      new SqlParameter("@Instructor_Password", instructorPassword));
    }

    public void UpdateInstructor(int instructorId, string instructorFname, string instructorLname, string instructorEmail, string instructorPassword)
    {
        // Call the stored procedure using Entity Framework
        Database.ExecuteSqlRaw("EXEC dbo.UpdateInstructor @Instructor_ID, @Instructor_Fname, @Instructor_Lname, @Instructor_Email, @Instructor_Password",
                                     new SqlParameter("@Instructor_ID", instructorId),
                                     new SqlParameter("@Instructor_Fname", instructorFname),
                                     new SqlParameter("@Instructor_Lname", instructorLname),
                                                                                                                                                                                                                                                                                                                            new SqlParameter("@Instructor_Email", instructorEmail),
                                                                                                                                                                                                                                                                                                                                                                                                                                                         new SqlParameter("@Instructor_Password", instructorPassword));
    }

    public void DeleteInstructor(int instructorId)
    {
        // Call the stored procedure using Entity Framework
        Database.ExecuteSqlRaw("EXEC dbo.DeleteInstructor @Instructor_ID",
                                     new SqlParameter("@Instructor_ID", instructorId));
    }
    #endregion

    #region functions for stored procedures for student
    public void AddStudent(string studentFname, string studentLname, string studentEmail, string studentPassword, int trackId)
    {
        // Call the stored procedure using raw SQL query
        Database.ExecuteSqlRaw("EXEC dbo.AddStudent @Student_FName, @Student_LName, @Student_Email, @Student_Password, @Track_ID",
                                                 new SqlParameter("@Student_FName", studentFname),
                                                                                      new SqlParameter("@Student_LName", studentLname),
                                                                                                                           new SqlParameter("@Student_Email", studentEmail),
                                                                                                                                                                new SqlParameter("@Student_Password", studentPassword),
                                                                                                                                                                                                     new SqlParameter("@Track_ID", trackId));
    }

    public void UpdateStudent(int studentId, string studentFname, string studentLname, string studentEmail, string studentPassword, int trackId)
    {
        // Call the stored procedure using Entity Framework
        Database.ExecuteSqlRaw("EXEC dbo.UpdateStudent @Student_ID, @Student_FName, @Student_LName, @Student_Email, @Student_Password, @Track_ID",
                                                            new SqlParameter("@Student_ID", studentId),
                                                                                                                                                 new SqlParameter("@Student_FName", studentFname),
                                                                                                                                                                                                                                                                           new SqlParameter("@Student_LName", studentLname),
                                                                                                                                                                                                                                                                                                                                                                                                                          new SqlParameter("@Student_Email", studentEmail),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              new SqlParameter("@Student_Password", studentPassword),
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       new SqlParameter("@Track_ID", trackId));
    }

    public void DeleteStudent(int studentId)
    {
        // Call the stored procedure using Entity Framework
        Database.ExecuteSqlRaw("EXEC dbo.DeleteStudent @Student_ID",
                                                                       new SqlParameter("@Student_ID", studentId));
    }
    #endregion
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=esiti.database.windows.net;Initial Catalog=Exam_System_Generate_Database;Persist Security Info=True;User ID=emad;Password=Lah27052");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.Property(e => e.BranchId)
                .ValueGeneratedNever()
                .HasColumnName("Branch_ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Branch_Name");

            entity.HasMany(d => d.Tracks).WithMany(p => p.Branches)
                .UsingEntity<Dictionary<string, object>>(
                    "BranchTrack",
                    r => r.HasOne<Track>().WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Branch_Tracks_Tracks"),
                    l => l.HasOne<Branch>().WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Branch_Tracks_Branches"),
                    j =>
                    {
                        j.HasKey("BranchId", "TrackId");
                        j.ToTable("Branch_Tracks");
                        j.IndexerProperty<int>("BranchId").HasColumnName("Branch_ID");
                        j.IndexerProperty<int>("TrackId").HasColumnName("Track_ID");
                    });
        });

        modelBuilder.Entity<Choice>(entity =>
        {
            entity.Property(e => e.ChoiceId).HasColumnName("Choice_ID");
            entity.Property(e => e.ChoiceText)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Choice_Text");
            entity.Property(e => e.QuestionId).HasColumnName("Question_ID");

            entity.HasOne(d => d.Question).WithMany(p => p.Choices)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK_Choices_Questions");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Courses__F5C807D38E645DDE");

            entity.HasIndex(e => e.CourseName, "UC_Name").IsUnique();

            entity.Property(e => e.CourseId).HasColumnName("Course_ID");
            entity.Property(e => e.CourseName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Course_Name");

            entity.HasMany(d => d.Topics).WithMany(p => p.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "CourseTopic",
                    r => r.HasOne<Topic>().WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Course_Topics_Topics"),
                    l => l.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Course_Topics_Courses"),
                    j =>
                    {
                        j.HasKey("CourseId", "TopicId");
                        j.ToTable("Course_Topics");
                        j.IndexerProperty<int>("CourseId").HasColumnName("Course_ID");
                        j.IndexerProperty<int>("TopicId").HasColumnName("Topic_ID");
                    });
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("PK__Exams__C782CA79C8552B80");

            entity.Property(e => e.ExamId).HasColumnName("Exam_ID");
            entity.Property(e => e.CourseId).HasColumnName("Course_ID");
            entity.Property(e => e.ExamDate).HasColumnName("Exam_Date");
            entity.Property(e => e.ExamDuration).HasColumnName("Exam_Duration");

            entity.HasOne(d => d.Course).WithMany(p => p.Exams)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Exams_Courses");

            entity.HasMany(d => d.Questions).WithMany(p => p.Exams)
                .UsingEntity<Dictionary<string, object>>(
                    "ExamQuestion",
                    r => r.HasOne<Question>().WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Questions_Questions"),
                    l => l.HasOne<Exam>().WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Questions_Exams"),
                    j =>
                    {
                        j.HasKey("ExamId", "QuestionId");
                        j.ToTable("Exam_Questions");
                        j.IndexerProperty<int>("ExamId").HasColumnName("Exam_ID");
                        j.IndexerProperty<int>("QuestionId").HasColumnName("Question_ID");
                    });
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasIndex(e => e.InstructorEmail, "UC_Email").IsUnique();

            entity.Property(e => e.InstructorId).HasColumnName("Instructor_ID");
            entity.Property(e => e.InstructorEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Instructor_Email");
            entity.Property(e => e.InstructorFname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Instructor_Fname");
            entity.Property(e => e.InstructorLname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Instructor_Lname");
            entity.Property(e => e.InstructorPassword)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Instructor_Password");

            entity.HasMany(d => d.Courses).WithMany(p => p.Instructors)
                .UsingEntity<Dictionary<string, object>>(
                    "InstructorCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Instructor_Courses_Courses"),
                    l => l.HasOne<Instructor>().WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Instructor_Courses_Instructors"),
                    j =>
                    {
                        j.HasKey("InstructorId", "CourseId");
                        j.ToTable("Instructor_Courses");
                        j.IndexerProperty<int>("InstructorId").HasColumnName("Instructor_ID");
                        j.IndexerProperty<int>("CourseId").HasColumnName("Course_ID");
                    });
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__Question__5C22EDA88A4571DD");

            entity.HasIndex(e => e.QuestionText, "UC_QText").IsUnique();

            entity.Property(e => e.QuestionId).HasColumnName("Question_ID");
            entity.Property(e => e.CourseId).HasColumnName("Course_ID");
            entity.Property(e => e.QuestionModelAnswer)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Question_ModelAnswer");
            entity.Property(e => e.QuestionText)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Question_Text");
            entity.Property(e => e.QuestionType)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Question_Type");

            entity.HasOne(d => d.Course).WithMany(p => p.Questions)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Questions_Courses");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasIndex(e => e.StudentEmail, "UC_stdEmail").IsUnique();

            entity.Property(e => e.StudentId)
                .HasDefaultValueSql("(NEXT VALUE FOR [StudentIDSequence])")
                .HasColumnName("Student_ID");
            entity.Property(e => e.StudentEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Student_Email");
            entity.Property(e => e.StudentFname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Student_FName");
            entity.Property(e => e.StudentLname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Student_LName");
            entity.Property(e => e.StudentPassword)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Student_Password");
            entity.Property(e => e.TrackId).HasColumnName("Track_ID");

            entity.HasOne(d => d.Track).WithMany(p => p.Students)
                .HasForeignKey(d => d.TrackId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_Tracks");
        });

        modelBuilder.Entity<StudentCourse>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.CourseId });

            entity.ToTable("Student_Courses");

            entity.Property(e => e.StudentId).HasColumnName("Student_ID");
            entity.Property(e => e.CourseId).HasColumnName("Course_ID");
            entity.Property(e => e.StudentGrade)
                .HasDefaultValue(0)
                .HasColumnName("Student_Grade");

            entity.HasOne(d => d.Course).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Courses_Courses");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentCourses)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Courses_Students");
        });

        modelBuilder.Entity<StudentExamQuestion>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.ExamId, e.QuestionId });

            entity.ToTable("Student_Exam_Questions");

            entity.Property(e => e.StudentId).HasColumnName("Student_ID");
            entity.Property(e => e.ExamId).HasColumnName("Exam_ID");
            entity.Property(e => e.QuestionId).HasColumnName("Question_ID");
            entity.Property(e => e.StudentQanswers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Student_QAnswers");
            entity.Property(e => e.StudentQcorrection)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Student_QCorrection");

            entity.HasOne(d => d.Exam).WithMany(p => p.StudentExamQuestions)
                .HasForeignKey(d => d.ExamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Exam_Questions_Exams");

            entity.HasOne(d => d.Question).WithMany(p => p.StudentExamQuestions)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Exam_Questions_Questions");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentExamQuestions)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Exam_Questions_Students");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => e.TopicId).HasName("PK__Topics__0F4523B5AAE1402B");

            entity.Property(e => e.TopicId).HasColumnName("Topic_ID");
            entity.Property(e => e.ToName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("To_Name");
        });

        modelBuilder.Entity<Track>(entity =>
        {
            entity.HasIndex(e => e.SupervisorId, "UIX_Supervisor_ID").IsUnique();

            entity.HasIndex(e => e.TrackName, "UniqueTrackName").IsUnique();

            entity.Property(e => e.TrackId).HasColumnName("Track_ID");
            entity.Property(e => e.SupervisorId).HasColumnName("Supervisor_ID");
            entity.Property(e => e.TrackName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Track_Name");

            entity.HasOne(d => d.Supervisor).WithOne(p => p.Track)
                .HasForeignKey<Track>(d => d.SupervisorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tracks_Instructors");

            entity.HasMany(d => d.Courses).WithMany(p => p.Tracks)
                .UsingEntity<Dictionary<string, object>>(
                    "TrackCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Track_Courses_Courses"),
                    l => l.HasOne<Track>().WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Track_Courses_Tracks"),
                    j =>
                    {
                        j.HasKey("TrackId", "CourseId").HasName("PK_Departments");
                        j.ToTable("Track_Courses");
                        j.IndexerProperty<int>("TrackId").HasColumnName("Track_ID");
                        j.IndexerProperty<int>("CourseId").HasColumnName("Course_ID");
                    });
        });
        modelBuilder.HasSequence<int>("StudentIDSequence").StartsAt(31L);

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}