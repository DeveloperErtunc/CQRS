using Cqrs.Cqrs.Query.Student;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using Cqrs.Cqrs.Command.Student;
using System.ComponentModel.DataAnnotations;

namespace Cqrs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById([Required]int id) {
         return Ok(await _mediator.Send(new GetStudentByIdQuery(id)));
        }
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            return Ok(await _mediator.Send(new GetStudentsQuery()));
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateStudentCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateStudentCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove([Required]int id)
        {
            return Ok(await _mediator.Send(new RemoveStudentCommand(id)));
        }
    }
}
