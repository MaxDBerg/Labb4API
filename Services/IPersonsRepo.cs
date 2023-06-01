using Hobbies.Models;

namespace Hobbies.Services
{
    public interface IPersonsRepo : IRepository<Person>
    {
        IEnumerable<Interest> GetAllInterestsForPerson(int id);
        IEnumerable<Link> GetAllLinksForPerson(int id);
        Interest AddInterestToPerson(int id, int interestID);
    }
}