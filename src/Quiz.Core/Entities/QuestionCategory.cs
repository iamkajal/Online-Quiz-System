using Quiz.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Core.Entities
{
   public class QuestionCategory:Entity
    {
        public string QuestionCategoryName { get; set; }
        public ICollection<Question> Question { get; set; }
    }
}
