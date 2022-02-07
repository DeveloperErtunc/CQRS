using Cqrs.Cqrs.Command.Student;
using Cqrs.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Cqrs.Cqrs.Handler.Student.Command
{
    public class CreateStudentCommandHandlerService:BaseHandler,IRequestHandler<CreateStudentCommand>
    {
        public CreateStudentCommandHandlerService(StudentContext studentContext):base(studentContext)
        {
        }

        public  async Task<Unit> Handle(CreateStudentCommand request,CancellationToken cancellationToken)
        {
            Data.Student student =  new Data.Student { Name = request.Name, SurName = request.SurName, Age = request.Age };
            _studentContext.Students.Add(student);
            await _studentContext.SaveChangesAsync();
            return Unit.Value;    
        }
    }
}
