using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoSQL
{
    internal class GetPerson : IGetPerson
    {
        private readonly PersonContext _personContext;
        public GetPerson(PersonContext personContext)
        {
            this._personContext = personContext;    
        }
        public Person GetPersonInfo(int id)
        {
            return _personContext.Persons.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
