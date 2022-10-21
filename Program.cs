using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new PersonContext("Server = (localdb)\\MSSQLLocalDB;Database = Person;Trusted_Connection = True");
            //var person = new GetPerson(context);
            //var personInfo = person.GetPersonInfo(1);
            //Console.WriteLine($"Hej {personInfo.FirstName} {personInfo.LastName}");
            //Console.ReadLine();
            //var repo = new PersonRepo(context);
            //repo.Create(4, "Mirha", "Munir");
            //var updator = new PersonUpdator(context);
            //updator.Update(5, "Mossa");
            //var deletor = new PersonDeletor(context);
            //deletor.Delete(5);
            //var creator = new PersonCreator(context);
            //creator.Create(new Person { Id = 5, FirstName = "Janat", LastName = "Ali" });

            // open for SQL Injection
            //var person = new GetPersonInlineQuery(context);
            //var showPerson = person.GetPersonWithQueru(2);
            //Console.WriteLine($"Hej {showPerson.FirstName} {showPerson.LastName}");
            //Console.ReadLine();

            // Here is prevention of SQL Injection

            //var person = new GetPersonInlineQuery(context);
            //var showPerson = person.GetPersonWithQueru(2);
            //Console.WriteLine(JsonConvert.SerializeObject(showPerson));
            //Console.ReadLine();

            // Here is prevention of SQL Injection
            //var updator = new PersonUpdator(context);
            //updator.Update(5, "Janat");
            //Console.ReadLine();

            // Test of SQL Injection by changing the SQL query

            var updator = new PersonUpdator(context);
            updator.Update(5, "Ch Janat'; truncate table PersonInfo;");
            Console.ReadLine();




        }
    }
}
