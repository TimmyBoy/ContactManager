using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client.Indexes;

namespace Logic.BusinessLogic
{
   public class Person_ByTelephonnumber:AbstractIndexCreationTask<Person>
    {
        public Person_ByTelephonnumber()
        {
            Map = Person => from person in Person
                            select new { person.TelephoneNumber };
        }
    }
}
