using Microsoft.AspNetCore.Mvc;
using Onsite.Application;
using Onsite.Domain.Entities;
using System.Net;

namespace Onsite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtudiantController : ControllerBase
    {
        private readonly IEtudiantService etudiantService;

        public EtudiantController(IEtudiantService etudiantService)
        {
            this.etudiantService = etudiantService;
        }

        // GET: api/<EtudiantController>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<EtudiantEntity>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IList<EtudiantEntity>>> GetAll()
        {
            var list = await this.etudiantService.GetAll();
            return Ok(list);
        }
    }
}
