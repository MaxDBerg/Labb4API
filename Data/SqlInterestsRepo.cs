using Hobbies.Models;

namespace Hobbies.Data
{
    public class SqlInterestsRepo : IRepository<Interest>
    {
        public SqlInterestsRepo(AppDbContext context)
        {
            _context = context;
        }
        private readonly AppDbContext _context;

        public Interest Get(int id)
        {
            var interest = _context.Interests.FirstOrDefault(p => p.InterestID == id);
            return interest;
        }

        public IEnumerable<Interest> GetAll()
        {
            var interest = _context.Interests.ToList();
            return interest;
        }

        public Interest Add(Interest entity)
        {
            _context.Interests.Add(entity);
            return entity;
        }

        public Interest Remove(int id)
        {
            var interest = Get(id);
            if (interest != null)
            {
                _context.Interests.Remove(interest);
            }
            return interest;
        }

        public Interest Update(int id, Interest entity)
        {
            var interest = Get(id);
            if(interest != null)
            {
                interest.Description = entity.Description;
            }
            return interest;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}