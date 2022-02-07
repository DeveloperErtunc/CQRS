using MediatR;
using Cqrs.Cqrs.Result.Student;
namespace Cqrs.Cqrs.Query.Student
{
    public class GetStudentByIdQuery:IRequest<GetStudentByIdQueryResult>
    {
        public GetStudentByIdQuery(int ıd)
        {
            Id = ıd;
        }
        public int Id { get; set; }
    }
}
