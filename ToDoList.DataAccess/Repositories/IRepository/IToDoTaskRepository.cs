using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.DataAccess.Repositories.IRepository
{
    public interface IToDoTaskRepository : IRepository<ToDoTask>
    {
        void Update(ToDoTask obj);
    }
}
