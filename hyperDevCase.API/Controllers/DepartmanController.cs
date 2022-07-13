using hyperDevCase.Business.Abstract;
using hyperDevCase.Business.Concrete;
using hyperdevCase.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hyperDevCase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmanController : ControllerBase
    {
        private IDepartmanService _departmanService;

        public DepartmanController()
        {
            _departmanService = new DepartmanManager();
        }

        [HttpGet]
        public List<Departman> Get()
        {
            return _departmanService.GetAllDepartman();
        }

        [HttpGet("{id}")]
        public Departman Get(int id)
        {
            return _departmanService.GetDepartmanById(id);
        }

        [HttpPost]
        public Departman Post([FromBody] Departman departman)
        {
            return _departmanService.CreateDepartman(departman);
        }

        [HttpPut]
        public Departman Put([FromBody] Departman departman)
        {
            return _departmanService.UpdateDepartman(departman);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _departmanService.DeleteDepartmanById(id);
        }
    }
}
