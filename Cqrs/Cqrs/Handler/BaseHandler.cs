using Cqrs.Data;

namespace Cqrs.Cqrs.Handler
{
    public class BaseHandler
    {
        public readonly StudentContext _studentContext;

        public BaseHandler(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }
    }
}
