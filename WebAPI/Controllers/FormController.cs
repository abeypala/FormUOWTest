using Data.Models;
using WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    //[Produces("application/json")]
 //   [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class FormController : ControllerBase
    {
        private IService _svc;

        public FormController(IService svc)
        {
            _svc = svc;
        }
        [Route("GetTemplateById")]
        [HttpPost]
        public async Task<IEnumerable<Template>> GetTemplateById(string templateId)
        {
            return await _svc.GetTemplateById(templateId);
        }
        [Route("GetSectionByTemplateId")]
        [HttpPost]
        public async Task<IEnumerable<Section>> GetSectionByTemplateId(string templateId)
        {
            return await _svc.GetSectionByTemplateId(templateId);
        }
    }
}
