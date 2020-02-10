using AutoMapper;
using Infrastructure.Data.Dtos;
using Infrastructure.Data.Models;
using Infrastructure.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Data.Controllers
{
    [Route("api/histories")]
    [ApiController]
    public class HistoriesController : ControllerBase
    {
        private readonly IService<History> _historyService;

        private readonly IMapper _mapper;

        public HistoriesController(IMapper mapper, IService<History> historyService)
        {
            _mapper = mapper;
            _historyService = historyService;
        }
        
        [HttpGet]
        public IActionResult GetHistories()
        {
            var histories = _historyService.GetAll();
            return Ok(histories);
        }
        
        [HttpPost("add")]
        public IActionResult AddHistory(HistoryDto historyDto)
        {
            var history = _mapper.Map<History>(historyDto);
            _historyService.Add(history);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteHistory([FromRoute] int id)
        {
            _historyService.Delete(id);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateHistory(HistoryDto historyDto, [FromRoute] int id)
        {
            var history = _mapper.Map<History>(historyDto);
            history.Id = id;
            _historyService.Update(history);
            return Ok();
        }
    }
}