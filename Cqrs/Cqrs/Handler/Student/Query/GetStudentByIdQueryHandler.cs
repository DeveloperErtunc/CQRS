   using Cqrs.Cqrs.Query.Student;
using Cqrs.Cqrs.Result.Student;
using Cqrs.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Cqrs.Cqrs.Handler.Student.Query
{
    public class GetStudentByIdQueryHandler:BaseHandler,IRequestHandler<GetStudentByIdQuery,GetStudentByIdQueryResult>
    {

        public GetStudentByIdQueryHandler(StudentContext studentContext) : base(studentContext)
        {
        }
        public async Task<GetStudentByIdQueryResult> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
           var student = await _studentContext.Students.FindAsync(request.Id);
            return new GetStudentByIdQueryResult
            {
                Id = student.Id,
                Name = student.Name,
                SurName = student.SurName,
                Age = student.Age,
            };
        }
    }
}
