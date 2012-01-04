using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client.Document;
using Raven.Client;
using Raven.Abstractions.Indexing;
using System.Text.RegularExpressions;


namespace Logic.BusinessLogic
{
    public class PersonManager
    {
        //IDocumentSession session;
        
        
        public bool Create(Person person)
        {
            try
            {
                var ds = new DocumentStore() { Url = "http://localhost:8081" };
                ds.Initialize();
                using (var session = ds.OpenSession())
                {
                    session.Store(person);
                    session.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public List<Person> GetAll()
        {
            var ds = new DocumentStore() { Url = "http://localhost:8080" };
            ds.Initialize();
            List<Person> list;
            using (var session = ds.OpenSession())
            {
                list = session.Query<Person>().ToList();
                //var list = session.Load<Person>();
            }
            return list;
        }

        public bool Delete(int id)
        {
            try
            {
                var ds = new DocumentStore() { Url = "http://localhost:8080" };
                ds.Initialize();
                using (var session = ds.OpenSession())
                {
                    var p = session.Load<Person>(id);
                    session.Delete<Person>(p);
                    session.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Person PersonById(int id)
        {
            try
            {
                var ds = new DocumentStore() { Url = "http://localhost:8080" };
                ds.Initialize();
                using (var session = ds.OpenSession())
                {
                    return session.Load<Person>(id);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdatePerson(Person person)
        {
            try
            {
                var ds = new DocumentStore() { Url = "http://localhost:8080" };
                ds.Initialize();
                using (var session = ds.OpenSession())
                {
                    session.Store(person);
                    session.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string CastTelephonenumber(string number)
        {
            string newnumber = "";

            for (int i = 0; i < number.Length; i++)
            {
                Regex regex = new Regex("^[0-9]+$"); 
                if (!Char.IsDigit(number[i]))
                {

                }
                else
                {
                    newnumber += number[i];
                }
                if (number[i].Equals('/') || number[i].Equals(' ') || number[i].Equals('-'))
                {
                }
                else
                {

                }

            }
            return "";
        }
        public Person getPersonbyTelephonnumber()
        {
            Person result = new Person();
            var ds = new DocumentStore() { Url = "http://localhost:8081" };
           ds.Initialize();
           using (var session = ds.OpenSession())
           {
               session.Query<Person>("Person_ByTelephonnumber");
               result = session.Advanced.LuceneQuery<Person>("Person/ByTelephonnumber").WhereEquals("TelephoneNumber", "06642200920").SingleOrDefault();
           }
           return result;
            
        }
    }
}
