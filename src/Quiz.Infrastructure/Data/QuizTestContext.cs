using Microsoft.EntityFrameworkCore;
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

    }
}
