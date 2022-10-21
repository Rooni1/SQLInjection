using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoSQL
{
    internal interface IPersonRepo
    {
        Person Create(int Id, string firstname, string lastName);
         void Delete(Person person);
        Person Update(Person person);
    }
}
