using BusinessLogicLayer.Interface;
using GlobalEntity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Problem2.Controllers
{
    [Route("api/object/")]
    [EnableCors("s3")]
    [ApiController]
    public class ObjectController : ControllerBase
    {
        private readonly IObjectService _service;
        public ObjectController(IObjectService service)
        {
            _service = service;
        }
        [HttpGet("getall")]
        public async Task<List<ObjectModel>> GetObjects()
        {
            List<ObjectModel> list = await _service.GetObjects();
            return list;
        }
    }
}
