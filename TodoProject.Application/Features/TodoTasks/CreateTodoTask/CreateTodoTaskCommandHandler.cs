using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoProject.Application.Features.TodoTasks.CreateTodoTask
{
    public class CreateTodoTaskCommandHandler : IRequestHandler<CreateTodoTaskCommand, Guid>
    {
        public Task<Guid> Handle(CreateTodoTaskCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
