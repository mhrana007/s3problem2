using BusinessLogicLayer.Interface;
using GlobalEntity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Problem2.Controllers
{
    [Route("api/datafield/")]
    [EnableCors("s3")]
    [ApiController]
    public class DataFieldController : ControllerBase
    {
        private readonly IDataFieldService _service;
        public DataFieldController(IDataFieldService service)
        {
            _service = service;
        }
        [HttpGet("getall")]
        public async Task<List<DataFieldModel>> GetBuildings()
        {
            List<DataFieldModel> list = await _service.GetDataFields();
            return list;
        }
    }
}
