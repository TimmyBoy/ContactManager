using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client.Indexes;
using Raven.Abstractions.Indexing;

namespace Logic.BusinessLogic
{
    class Person_ByTelephonnumber: AbstractIndexCreationTask<Person>
    {
        public Person_ByTelephonnumber()
        {
            Map = Person => from person in Person
                            select new { person.TelephoneNumber };
        }
    }
}
