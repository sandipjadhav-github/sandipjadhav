using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInformationManagement.Dto
{
    using System;

    public class PersonContactDto
    {
        public PersonContactDto()
        {

        }

        public int ContactTypeId { get; set; }

        public string ContactTypeName { get; set; }

        public string ContactTypeValue { get; set; }
    }

    public class PersonDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<PersonContactDto> personContactDtos { get; set; }
    }

}
