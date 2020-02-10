using System;
using AutoMapper;
using Infrastructure.Data.Dtos;
using Infrastructure.Data.Models;
using Infrastructure.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Data.Controllers
{
    [Route("api/problems")]
    [ApiController]
    public class ProblemsController : ControllerBase
    {
        private readonly IService<Problem> _problemService;

        private readonly IMapper _mapper;

        public ProblemsController(IMapper mapper, IService<Problem> problemService)
        {
            _mapper = mapper;
            _problemService = problemService;
        }
    
        [HttpGet]
        public IActionResult GetProblems()
        {
            var problems = _problemService.GetAll();
            return Ok(problems);
        }

        [HttpPost("add")]
        public IActionResult AddProblem(ProblemDto problemDto)
        {
            var problem = _mapper.Map<Problem>(problemDto);
            _problemService.Add(problem);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteProblem([FromRoute] int id)
        {
            _problemService.Delete(id);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateProblem(ProblemDto problemDto, [FromRoute] int id)
        {
            var problem = _mapper.Map<Problem>(problemDto);
            problem.Id = id;
            _problemService.Update(problem);
            return Ok();
        }

    }
}