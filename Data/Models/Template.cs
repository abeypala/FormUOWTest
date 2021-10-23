using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Template
    {
        public string TemplateId { get; set; }
        public string TemplateTitle { get; set; }
        public string TemplateSubTitle { get; set; }
        public string TemplateDesc { get; set; }
        public string TemplateImage { get; set; }
        public List<Section> Sections { get; set; }
    }
}
