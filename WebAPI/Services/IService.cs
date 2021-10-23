using System.Threading.Tasks;

namespace WebAPI.Services
{
    public interface IService
    {
        Task<dynamic> GetTemplateById(string templateId);
        Task<dynamic> GetSectionByTemplateId(string templateId);
        Task<dynamic> GetQuestionBySectionId(string sectionId);
        Task<dynamic> GetOptionByQuestionId(string questionId);
    }
}
