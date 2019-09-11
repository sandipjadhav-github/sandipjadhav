using ContactInformationManagement.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInfoManagement.InterfaceBusiness
{
    public interface IPersonContactBusiness
    {
        List<PersonDto> GetAllContacts();

        bool AddContact(PersonDto personDto);

        bool UpdateContact(PersonDto personDto);
    }
}
