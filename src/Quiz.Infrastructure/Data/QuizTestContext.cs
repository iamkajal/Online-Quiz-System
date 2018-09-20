using Microsoft.EntityFrameworkCore;
using Quiz.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Infrastructure.Data
{
  public  class QuizTestContext:DbContext
    {
        public QuizTestContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        public DbSet<QuestionCategory> QuestionCategory { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionOption> QuestionOption { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswer { get; set; }

    }
}
