using Microsoft.AspNetCore.Mvc;
using Onsite.Application;
using Onsite.Domain.Entities;
using System.Net;

namespace Onsite.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MatiereController : ControllerBase
    {
        private readonly IMatiereService MatiereService;

        public MatiereController(IMatiereService MatiereService)
        {
            this.MatiereService = MatiereService;
        }

        // GET: api/<MatiereController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MatiereEntity>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IList<MatiereEntity>>> GetAll()
        {
            var list = await this.MatiereService.GetAll();
            return Ok(list);
        }

    }
}
