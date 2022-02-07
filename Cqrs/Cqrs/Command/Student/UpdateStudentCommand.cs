using System.ComponentModel.DataAnnotations;
using MediatR;
namespace Cqrs.Cqrs.Command.Student
{
    public class UpdateStudentCommand:IRequest
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Range(1, int.MaxValue)]
        public int Age { get; set; }
    }
}
