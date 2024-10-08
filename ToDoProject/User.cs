﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoProject.Domain
{
    public record User(string Name)
    {
        public Guid Id { get; init; } = Guid.NewGuid();
    }
}
