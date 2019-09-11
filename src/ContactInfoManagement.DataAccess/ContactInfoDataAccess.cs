using ContactInformation.InterfaceDataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInfoManagement.DataAccess
{
    public class ContactInfoDataAccess<T> : IContactInformationDataAccess<T>
        where T:class
    {
        //private DbContext dbContext = null;

        public ContactInfoDataAccess()
        {
            //dbContext = new ContactInformationEntities();
        }

        public void Add(T obj)
        {
            using (DbContext dbContext = new ContactInformationEntities())
            {
                dbContext.Set<T>().Add(obj);               
                dbContext.SaveChanges();
            }
        }

        public void Update(T obj)
        {
            using (var dbContext = new ContactInformationEntities())
            {
                dbContext.Entry(obj).State = EntityState.Modified;
                //dbContext.Set<T>();
                dbContext.SaveChanges();
            }
        }



        public List<T> GetAll()
        {
            using (DbContext dbContext = new ContactInformationEntities())
            {

                return dbContext.Set<T>().
                     AsQueryable<T>().ToList();
            }
        }

        public List<Person> GetAllPerson()
        {
            using (var dbContext = new ContactInformationEntities())
            {

                return dbContext.People.Include(x => x.PersonContacts.Select(y=>y.ContactType)).ToList();
            }
        }
    }
}
