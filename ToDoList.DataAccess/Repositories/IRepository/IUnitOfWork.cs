using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DataAccess.Repositories.IRepository
{
    public interface IUnitOfWork
    {
        IToDoTaskRepository ToDoTask { get; }
        void Save();
    }
}
