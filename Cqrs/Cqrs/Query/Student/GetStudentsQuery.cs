using MediatR;
using Cqrs.Cqrs.Result.Student;
using System.Linq;

namespace Cqrs.Cqrs.Query.Student
{
    public class GetStudentsQuery:IRequest<IQueryable<GetStudentsQueryResult>>
    {
    }
}
