using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoSQL
{
    internal class GetPersonInlineQuery 
    {
        private readonly PersonContext _personContext;

        public GetPersonInlineQuery(PersonContext personContext)
        {
            this._personContext = personContext;
        }
        public Person GetPersonWithQueru(int id)
        {
            // You can make SQL Injection. Here is string interpolation
            //return _personContext.Persons.FromSqlRaw
            //     ($"SELECT Id,first_name,last_name FROM PersonInfo WHERE Id ={id}")
            //     .FirstOrDefaultAsync().Result;

            // By changing the above query removing string interpolation you can prevent SQL INjection
            return _personContext.Persons.FromSqlRaw
                ("SELECT Id,first_name,last_name FROM PersonInfo WHERE Id =({0})",id)
                .FirstOrDefaultAsync().Result;
        }
    }
    
}
