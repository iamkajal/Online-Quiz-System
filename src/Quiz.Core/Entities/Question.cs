using Quiz.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Core.Entities
{
   public class Question:Entity
    {
        public string QuestionTitle { get; set; }

        public ICollection<QuestionOption> QuestionOptions { get; set; }
        public ICollection<QuestionAnswer> QuestionAnswers { get; set; }
    }
}
