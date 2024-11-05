using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoProject.Application.Contracts.Persistence
{
    public interface ITodoItemRepository
    {
        Task<bool> IsTodoItemTitleAndDueDateUnique(string title, DateOnly date);
    }
}
