using Cqrs.Cqrs.Command.Student;
using Cqrs.Data;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Cqrs.Cqrs.Handler.Student.Command
{
    public class RemoveStudentCommandHandlerService : BaseHandler,IRequestHandler<RemoveStudentCommand>
    {
        public RemoveStudentCommandHandlerService(StudentContext studentContext) : base(studentContext)
        {
        }

        public void Handle(RemoveStudentCommand removeStudentCommand)
        {
           
        }

        public async Task<Unit> Handle(RemoveStudentCommand request, CancellationToken cancellationToken)
        {
            Data.Student student = _studentContext.Students.Find(request.Id);
            _studentContext.Students.Remove(student);
            await _studentContext.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
