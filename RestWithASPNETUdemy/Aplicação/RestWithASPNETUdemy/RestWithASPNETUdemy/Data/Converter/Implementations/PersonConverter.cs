using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Data.VO.Converter.Contract;
using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null) return null;

            return new Person
            {
                id = origin.id,
                firstName = origin.firstName,
                lastName = origin.LastName,
                address = origin.address,
                gender = origin.gender
            };
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return null;

            return new PersonVO
            {
                id = origin.id,
                firstName = origin.firstName,
                LastName = origin.lastName,
                address = origin.address,
                gender = origin.gender
            };
        }

        public List<Person> Parse(List<PersonVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PersonVO> Parse(List<Person> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

    }
}
