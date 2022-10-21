using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoSQL
{
    internal class PersonUpdator :IPersonUpdator
    {
        private readonly PersonContext _personContext;

        public PersonUpdator(PersonContext personContext)
        {
            this._personContext = personContext;
        }

        public void Update(int id, string name)
        {
            // This query has potential for SQL Injection
            //var query = $"UPDATE PersonInfo SET first_name = '{name}' WHERE id = (@id)";
            //var param = new SqlParameter("@id", id);
            //_personContext.Database.ExecuteSqlRaw(query, param);

            // here is the way to remove string interpolatio to prevent SQL Injection

            var query = "UPDATE PersonInfo SET first_name = (@name) WHERE id = (@id)";
            var param = new[] {
                new SqlParameter("@id", id),
                new SqlParameter("name", name)
                };
            _personContext.Database.ExecuteSqlRaw(query, param);

        }
    }
}
