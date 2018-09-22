using Quiz.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Quiz.Core.Entities
{
    public class QuestionAnswer : Entity
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public int QuestionOptionId { get; set; }
        public QuestionOption QuestionOption { get; set; }
    }
}
