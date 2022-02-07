using MediatR;
using System.ComponentModel.DataAnnotations;
namespace Cqrs.Cqrs.Command.Student
{
    public class CreateStudentCommand:IRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        [Range(minimum:1,int.MaxValue)]
        public int Age { get; set; }
    }
}
