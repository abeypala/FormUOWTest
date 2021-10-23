using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IFormRepository
    {
        Task<IEnumerable<Template>> GetTemplateById(string templateId);
        Task<IEnumerable<Section>> GetSectionByTemplateId(string templateId);
        IEnumerable<Question> GetQuestionBySectionId(string sectionId);
        IEnumerable<OptionList> GetOptionByQuestionId(string questionId);
    }
}
