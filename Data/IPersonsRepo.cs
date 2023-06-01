using Hobbies.Models;

namespace Hobbies.Data
{
    public interface IPersonsRepo : IRepository<Person>
    {
        IEnumerable<Interest> GetAllInterestsForPerson(int id);
    }
}