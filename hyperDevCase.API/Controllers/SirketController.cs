using hyperDevCase.Business.Abstract;
using hyperDevCase.Business.Concrete;
using hyperdevCase.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hyperDevCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SirketController : ControllerBase
    {
        private ISirketService _sirketService;

        public SirketController()
        {
            _sirketService = new SirketManager();
        }
        [HttpGet]
        public List<Sirket> Get()
        {
            return _sirketService.GetAllSirket();
        }
        [HttpGet("{id}")]
        public Sirket Get(int id)
        {
            return _sirketService.GetSirketById(id);
        }

        [HttpPost]
        public Sirket Post([FromBody] Sirket sirket)
        {
            return _sirketService.CreateSirket(sirket);
        }

        [HttpPut]
        public Sirket Put([FromBody] Sirket sirket)
        {
            return _sirketService.UpdateSirket(sirket);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _sirketService.DeleteSirketById(id);

        }
    }
}
