using Cqrs.Cqrs.Command.Student;
using Cqrs.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Cqrs.Cqrs.Handler.Student.Command
{
    public class UpdateStudentCommandHandlerService : BaseHandler,IRequestHandler<UpdateStudentCommand>
    {
        public UpdateStudentCommandHandlerService(StudentContext studentContext) : base(studentContext)
        {
        }

        public async Task<Unit> Handle(UpdateStudentCommand request,CancellationToken cancellationToken)
        {
            var student =  _studentContext.Students.Find(request.Id);
            student.Name = request.Name;
            student.SurName = request.SurName;
            student.Age = request.Age;
            await _studentContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
