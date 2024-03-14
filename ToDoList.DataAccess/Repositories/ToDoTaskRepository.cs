using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.DataAccess.Data;
using ToDoList.DataAccess.Repositories.IRepository;
using ToDoList.Models;

namespace ToDoList.DataAccess.Repositories
{
    public class ToDoTaskRepository : Repository<ToDoTask>, IToDoTaskRepository
    {
        private ApplicationDbContext _Db;

        public ToDoTaskRepository(ApplicationDbContext db) : base(db)
        {
            _Db = db;

        }

        public void Update(ToDoTask obj)
        {
            _Db.Update(obj);
        }
    }
}
