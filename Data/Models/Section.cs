using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Section
    {
        public string SectionId { get; set; }
        public string SectionTitle { get; set; }
        public string SectionSubTitle { get; set; }
        public string SectionPreDesc { get; set; }
        public string SectionPostDesc { get; set; }
        public string SectionImage { get; set; }
        public List<Question> Questions { get; set; }
    }
}
