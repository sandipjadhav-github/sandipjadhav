using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInformation.InterfaceDataAccess
{
    // Design pattern :- Generic Repository pattern
    public interface IContactInformationDataAccess<T>
    {
        void Add(T obj);   
        List<T> GetAll();

        //List<Person> GetAllPerson();

        void Update(T obj);
    }
}
