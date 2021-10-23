using WebAPI.AppSettings;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Repository;

namespace WebAPI.Services
{
    public class Service : IService
    {
        IUnitOfWork svcProvider;
        private readonly Settings _appSettings;

        public Service(IOptions<Settings> appSettings)
        {
            _appSettings = appSettings.Value;
            svcProvider = new UnitOfWork(_appSettings.GEBusinessConnectionString);
        }

        public async Task<dynamic> GetTemplateById(string templateId)
        {
            return await svcProvider.FormRepository.GetTemplateById(templateId);
        }

        public async Task<dynamic> GetSectionByTemplateId(string templateId)
        {
            return await svcProvider.FormRepository.GetSectionByTemplateId(templateId);
        }

        public Task<dynamic> GetQuestionBySectionId(string sectionId)
        {
            throw new NotImplementedException();
        }

        public Task<dynamic> GetOptionByQuestionId(string questionId)
        {
            throw new NotImplementedException();
        }
    }
}
