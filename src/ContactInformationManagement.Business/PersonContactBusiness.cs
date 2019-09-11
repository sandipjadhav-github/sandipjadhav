using ContactInfoManagement.DataAccess;
using ContactInfoManagement.InterfaceBusiness;
using ContactInformation.InterfaceDataAccess;
using ContactInformationManagement.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInformationManagement.Business
{
    public class PersonContactBusiness : IPersonContactBusiness
    {
        public List<PersonDto> GetAllContacts()
        {           
            List<PersonDto> personDtos = new List<PersonDto>();

          var contactInformationDataAccess
                = new ContactInfoDataAccess<Person>();

            var personList = contactInformationDataAccess.GetAllPerson();

            foreach (var item in personList)
            {
                var person = new PersonDto();

                person.Id = item.Id;
                person.FirstName = item.FirstName;
                person.LastName = item.LastName;

                person.personContactDtos = new List<PersonContactDto>();

                foreach(var contact in item.PersonContacts)
                {
                    PersonContactDto personContactDto = new PersonContactDto
                    {
                        ContactTypeId = contact.ContactTypeId,
                        ContactTypeName = contact.ContactType.TypeName,
                        ContactTypeValue = contact.ContactTypeValue
                    };

                    person.personContactDtos.Add(personContactDto);
                }

                personDtos.Add(person);
            }

            return personDtos;
        }

        public bool AddContact(PersonDto personDto)
        {
            IContactInformationDataAccess<Person> contactInformationDataAccess
               = new ContactInfoDataAccess<Person>();

            Person person = new Person();

            person.FirstName = personDto.FirstName;
            person.LastName = personDto.LastName;
            person.PersonContacts = new List<PersonContact>();

            foreach(var item in personDto.personContactDtos)
            {
                PersonContact personContact = new PersonContact();

                personContact.ContactTypeId = item.ContactTypeId;
                personContact.ContactTypeValue = item.ContactTypeValue;
                personContact.PersonId = personDto.Id;

                person.PersonContacts.Add(personContact);
            }

            contactInformationDataAccess.Add(person);

            return true;
        }

        public bool UpdateContact(PersonDto personDto)
        {
            var contactInformationDataAccess
                = new ContactInfoDataAccess<Person>();

            //using()
            var person = contactInformationDataAccess.GetAllPerson().FirstOrDefault(x => x.Id == personDto.Id);

            if (person == null)
            {
                return false;
            }

            person.FirstName = personDto.FirstName;
            person.LastName = personDto.LastName;

            contactInformationDataAccess.Update(person);

            foreach (var item in personDto.personContactDtos)
            {
                var personContact = person.PersonContacts?.FirstOrDefault(x => x.ContactTypeId == item.ContactTypeId);

                if (personContact != null)
                {
                    personContact.ContactTypeValue = item.ContactTypeValue;

                    var contactInformationDataAccess2
                = new ContactInfoDataAccess<PersonContact>();
                    contactInformationDataAccess2.Update(personContact);
                }
            }

            

            return true;
        }
    }
}
