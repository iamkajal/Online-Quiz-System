using Quiz.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Core.Entities
{
    public class QuestionAnswer:Entity
    {
        public int QuestionsId { get; set; }
        public Question Questions { get; set; }
        public int QuestionOptionId { get; set; }
    }
}
