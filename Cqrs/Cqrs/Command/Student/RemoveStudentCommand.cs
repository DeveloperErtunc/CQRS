using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace Cqrs.Cqrs.Command.Student
{
    public class RemoveStudentCommand:IRequest
    {
        [Required]
        [Range(1,int.MaxValue)]
        public int Id { get; set; }
        public RemoveStudentCommand(int ıd)
        {
            Id = ıd;
        }
    }
}
