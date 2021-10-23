using Dapper;
using Data.Interfaces;
using Data.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Data
{
    public class FormRepository : RepositoryBase, IFormRepository
    {
        public FormRepository(IDbTransaction transaction) : base(transaction)
        {

        }
        public async Task<IEnumerable<Template>> GetTemplateById(string templateId)
        {
            return await Connection.QueryAsync<Template>("[gia].[spSELECTTemplate]",
             param: new DynamicParameters(new { TemplateId = templateId, }),
             transaction: Transaction,
             commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<Section>> GetSectionByTemplateId(string templateId)
        {
            return await Connection.QueryAsync<Section>("[gia].[spSELECTSections]",
             param: new DynamicParameters(new { TemplateId = templateId, }),
             transaction: Transaction,
             commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<Question> GetQuestionBySectionId(string sectionId)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<OptionList> GetOptionByQuestionId(string questionId)
        {
            throw new System.NotImplementedException();
        }
    }
}
