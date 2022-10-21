using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoSQL
{
    internal class PersonCreator : IPersonCreator
    {
        private readonly PersonContext _personContext;

        public PersonCreator(PersonContext personContext)
        {
            this._personContext = personContext;
        }
        public void Create(Person person)
        {
            var query = "INSERT PersonInfo(Id,first_name,last_name) values (@Id,@first_name,@last_name)";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Id",person.Id),
                new SqlParameter("@first_name",person.FirstName),
                new SqlParameter("@last_name",person.LastName)

            };

            _personContext.Database.ExecuteSqlRaw(query, parameters);
        }
    }
}
