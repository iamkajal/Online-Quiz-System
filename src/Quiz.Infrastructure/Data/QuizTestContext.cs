using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Quiz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Infrastructure.Data
{
  public  class QuizTestContext:DbContext
    {
        public QuizTestContext(DbContextOptions<QuizTestContext> options) : base(options)
        {

        }

        public DbSet<QuestionCategory> QuestionCategory { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionOption> QuestionOption { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswer { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>()
                .HasOne<QuestionCategory>(qc => qc.QuestionCategory)
                .WithMany(q => q.Question)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<QuestionOption>()
                .HasOne<Question>(q => q.Question)
                .WithMany(qo => qo.QuestionOptions)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<QuestionAnswer>()
                .HasOne<Question>(q => q.Question)
                .WithOne(qo => qo.QuestionAnswer)
                .IsRequired()
                .HasForeignKey<QuestionAnswer>(q => q.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<QuestionAnswer>()
                .HasOne<QuestionOption>(qo => qo.QuestionOption)
                .WithOne(qo => qo.QuestionAnswer)
                .HasForeignKey<QuestionAnswer>(q => q.QuestionOptionId)
                .OnDelete(DeleteBehavior.Restrict);
            
        }
    }

}
