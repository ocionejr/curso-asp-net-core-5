using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(PostgresqlContext context) : base(context) { }

        public Person Disable(long id)
        {
            if (!_context.People.Any(p => p.id.Equals(id))) return null;

            var user = _context.People.SingleOrDefault(p => p.id.Equals(id));

            if(user!= null)
            {
                user.enabled = false;
                try
                {
                    _context.Entry(user).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return user;
        }

        public List<Person> FindByName(string firstName, string lastName)
        {
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                return _context.People.Where(
                    p => p.firstName.Contains(firstName)
                    && p.lastName.Contains(lastName)).ToList();
            }
            else if (string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                return _context.People.Where(
                    p => p.lastName.Contains(lastName)).ToList();
            }
            else if (!string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                return _context.People.Where(
                    p => p.firstName.Contains(firstName)).ToList();
            }

            return null;
        }
    }
}
