using BusinessLogicLayer.Interface;
using GlobalEntity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Problem2.Controllers
{
    [Route("api/reading/")]
    [EnableCors("s3")]
    [ApiController]
    public class ReadingController : ControllerBase
    {
        private readonly IReadingService _service;
        public ReadingController(IReadingService service)
        {
            _service = service;
        }
        [HttpPost("getall")]
        public async Task<List<ReadingModel>> GetReadings([FromBody] GetSearchReadingQuery query)
        {
            List<ReadingModel> list = await _service.GetReadings(query);
            return list;
        }
    }
}
