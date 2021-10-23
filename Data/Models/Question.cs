using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Question
    {
        public string QuestionId { get; set; }
        public string QuestionTypeId { get; set; }
        public string QuestionNo { get; set; }
        public string QuestionText { get; set; }
        public string PreDesc { get; set; }
        public string PostDesc { get; set; }
        public string ErrMsgPrimary { get; set; }
        public string ErrMsgSecondary { get; set; }
        public bool Visible { get; set; }
        public List<OptionList> Options { get; set; }
    }
}
