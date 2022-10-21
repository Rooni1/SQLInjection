using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoSQL
{
    internal class PersonDeletor : IPersonDeletor
    {
        private readonly PersonContext _personContext;

        public PersonDeletor(PersonContext personContext)
        {
            this._personContext = personContext;
        }

        public void Delete(int id)
        {
            var query = $"DELETE FROM PersonInfo WHERE id = (@id)";
            var param = new SqlParameter("@id", id);
            _personContext.Database.ExecuteSqlRaw(query, param);    
        }
    }
}
