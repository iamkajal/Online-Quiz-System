using Quiz.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Core.Entities
{
    public class QuestionOption:Entity
    {
        public string QuestionOptionDetail { get; set; }
        public int QuestionsId { get; set; }
        public Question Question { get; set; }
        public QuestionAnswer QuestionAnswer { get; set; }
    }
}
