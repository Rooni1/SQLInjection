using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoSQL
{
    internal class PersonRepo : IPersonRepo
    {
        private readonly PersonContext _personContext;

        public PersonRepo(PersonContext personContext)
        {
            this._personContext = personContext;
        }
        public Person Create(int id , string firstname, string lastName)
        {
            var response = _personContext.Add(new Person { Id= id, FirstName = firstname, LastName = lastName });
            _personContext.SaveChanges();
            return response.Entity;
        }

        public void Delete(Person person)
        {
            _personContext.Remove(person);
            _personContext.SaveChanges();
        }

        public Person Update(Person person)
        {
            var response = _personContext.Update(person);
            _personContext.SaveChanges();
            return response.Entity;
        }
    }
}
