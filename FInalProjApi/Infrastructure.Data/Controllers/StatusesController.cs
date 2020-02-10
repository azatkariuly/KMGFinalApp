using AutoMapper;
using Infrastructure.Data.Dtos;
using Infrastructure.Data.Models;
using Infrastructure.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Data.Controllers
{
    [Route("api/status")]
    [ApiController]
    public class StatusesController : ControllerBase
    {
        private readonly IService<Status> _statusService;

        private readonly IMapper _mapper;

        public StatusesController(IMapper mapper, IService<Status> statusService)
        {
            _mapper = mapper;
            _statusService = statusService;
        }

        [HttpGet]
        public IActionResult GetStatuses()
        {
            var statuses = _statusService.GetAll();
            return Ok(statuses);
        }

        [HttpPost("add")]
        public IActionResult AddStatuses(StatusDto statusDto)
        {
            var status = _mapper.Map<Status>(statusDto);
            _statusService.Add(status);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteStatus([FromRoute] int id)
        {
            _statusService.Delete(id);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateStatus(StatusDto statusDto, [FromRoute] int id)
        {
            var status = _mapper.Map<Status>(statusDto);
            status.Id = id;
            _statusService.Update(status);
            return Ok();
        }
    }
}