using BusinessLogicLayer.Interface;
using GlobalEntity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Problem2.Controllers
{
    [Route("api/building/")]
    [EnableCors("s3")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService _service;
        public BuildingController(IBuildingService service)
        {
            _service = service;
        }
        [HttpGet("getall")]
        public async Task<List<BuildingModel>> GetBuildings()
        {
            List<BuildingModel> list = await _service.GetBuildings();
            return list;
        }
    }
}
