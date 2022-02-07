using Cqrs.Cqrs.Query.Student;
using Cqrs.Cqrs.Result.Student;
using Cqrs.Data;
using System.Linq;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace Cqrs.Cqrs.Handler.Student.Query
{
    public class GetStudentsQueryHandler:BaseHandler,IRequestHandler<GetStudentsQuery,IQueryable<GetStudentsQueryResult>>
    {
        public GetStudentsQueryHandler(StudentContext studentContext) : base(studentContext)
        {

        }

        public async Task<IQueryable<GetStudentsQueryResult>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
           return _studentContext.Students.Select(x => new GetStudentsQueryResult
           {
               Name = x.Name,
               SurName = x.SurName,
               Id = x.Id,
               Age = x.Age,
           });
        }
    }
}
