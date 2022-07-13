using hyperDevCase.Business.Abstract;
using hyperDevCase.Business.Concrete;
using hyperdevCase.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hyperDevCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AltDepartmanController : ControllerBase
    {
        private IAltDepartmanService _altDepartmanService;

        public AltDepartmanController()
        {
            _altDepartmanService = new AltDepartmanManager();
        }

        [HttpGet]
        public List<AltDepartman> Get()
        {
            return _altDepartmanService.GetAllAltDepartman();
        }

        [HttpGet("{id}")]
        public AltDepartman Get(int id)
        {
            return _altDepartmanService.GetAltDepartmanById(id);
        }

        [HttpPost]
        public AltDepartman Post([FromBody] AltDepartman altDepartman)
        {
            return _altDepartmanService.CreateAltDepartman(altDepartman);
        }

        [HttpPut]
        public AltDepartman Put([FromBody] AltDepartman altDepartman)
        {
            return _altDepartmanService.UpdateAltDepartman(altDepartman);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _altDepartmanService.DeleteAltDepartmanById(id);
        }
    }
}
