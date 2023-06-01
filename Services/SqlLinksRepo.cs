using Hobbies.Models;
using Hobbies.Data;

namespace Hobbies.Services
{
    public class SqlLinksRepo : IRepository<Link>
    {
        public SqlLinksRepo(AppDbContext context)
        {
            _context = context;
        }
        private readonly AppDbContext _context;

        public Link Get(int id)
        {
            var link = _context.Links.FirstOrDefault(p => p.LinkID == id);
            return link;
        }

        public IEnumerable<Link> GetAll()
        {
            var link = _context.Links.ToList();
            return link;
        }

        public Link Add(Link entity)
        {
            _context.Links.Add(entity);
            return entity;
        }

        public Link Remove(int id)
        {
            var link = Get(id);
            if (link != null)
            {
                _context.Links.Remove(link);
            }
            return link;
        }

        public Link Update(int id, Link entity)
        {
            var link = Get(id);
            if(link != null)
            {
                link.LinkURL = entity.LinkURL;
            }
            return link;
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}