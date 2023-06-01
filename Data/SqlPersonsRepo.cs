using Hobbies.Models;
using Microsoft.EntityFrameworkCore;

namespace Hobbies.Data
{
    public class SqlPersonsRepo : IPersonsRepo
    {
        public SqlPersonsRepo(AppDbContext context)
        {
            _context = context;
        }
        private readonly AppDbContext _context;

        public Person Get(int id)
        {
            var person = _context.Persons.FirstOrDefault(p => p.PersonID == id);
            return person;
        }

        public IEnumerable<Person> GetAll()
        {
            var person = _context.Persons.ToList();
            return person;
        }

        public IEnumerable<Interest> GetAllInterestsForPerson(int id)
        {
            var interest = _context.Persons.Include(pe => pe.Interests).Where(pe => pe.PersonID == id).SelectMany(pe => pe.Interests).ToList();
            return interest;
        }

        public Person Add(Person entity)
        {
            _context.Persons.Add(entity);
            return entity;
        }

        public Person Remove(int id)
        {
            var person = Get(id);
            if (person != null)
            {
                _context.Persons.Remove(person);
            }
            return person;
        }

        public Person Update(int id, Person entity)
        {
            var person = Get(id);
            if(person != null)
            {
                person.Name = entity.Name;
                person.Phone = entity.Phone;
                person.Email = entity.Email;
            }
            return person;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}