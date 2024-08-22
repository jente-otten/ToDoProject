﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoProject.Application.Features
{
    public class GetTodoTaskQuery : IRequest<TodoTaskDetailDTO>
    {
        public Guid Id { get; set; }
    }
}