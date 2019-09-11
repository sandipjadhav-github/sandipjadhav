using ContactInfoManagement.InterfaceBusiness;
using ContactInformationManagement.Dto;
using ContactInformationManagement.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactInformationManagement.Controllers
{
    public class PersonContactController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var personBusiness = ContactInfoFactory<IPersonContactBusiness>.CreateObject("PersonContactBusiness");

            var contacts = personBusiness.GetAllContacts();

            return Request.CreateResponse(contacts);
        }

        [HttpPost]
        public HttpResponseMessage Add(PersonDto personDto)
        {
            var personBusiness = ContactInfoFactory<IPersonContactBusiness>.CreateObject("PersonContactBusiness");

            var response = personBusiness.AddContact(personDto);

            return Request.CreateResponse(response);
        }

        [HttpPut]
        public HttpResponseMessage Update(PersonDto personDto)
        {
            var personBusiness = ContactInfoFactory<IPersonContactBusiness>.CreateObject("PersonContactBusiness");

            var response = personBusiness.UpdateContact(personDto);

            return Request.CreateResponse(response);
        }
    }
}
