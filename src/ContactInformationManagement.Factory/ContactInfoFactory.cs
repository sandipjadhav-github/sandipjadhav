using ContactInfoManagement.DataAccess;
using ContactInfoManagement.InterfaceBusiness;
using ContactInformation.InterfaceDataAccess;
using ContactInformationManagement.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ContactInformationManagement.Factory
{
    // Design pattern :- Simple factory pattern
    public static class ContactInfoFactory<T>
    {
        private static IUnityContainer objectContainer = null;

        public static T CreateObject(string type)
        {
            if (objectContainer == null)
            {
                objectContainer = new UnityContainer();

                objectContainer.RegisterType<IPersonContactBusiness, PersonContactBusiness>
                    ("PersonContactBusiness");

                objectContainer.RegisterType<IContactInformationDataAccess<PersonContact>, ContactInfoDataAccess<PersonContact>>
                    ("PersonContactDataAccess");
            }

            return objectContainer.Resolve<T>(type);
        }
    }
}
