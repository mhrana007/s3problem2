using BusinessLogicLayer.Interface;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Problem2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService _service;
        public BuildingController(IBuildingService service)
        {
            _service = service;
        }
        public async Task<List<Building>> GetBuildings()
        {
            List<Building> list = await _service.GetBuildings();
            return list;
        }
    }
}
