using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataAccess.Data;
using ToDoList.DataAccess.Repositories.IRepository;

namespace ToDoList.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _Db;
        public IToDoTaskRepository ToDoTask { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _Db = db;
            ToDoTask = new ToDoTaskRepository(_Db);
        }

        public void Save()
        {
            _Db.SaveChanges();
        }
    }
}
