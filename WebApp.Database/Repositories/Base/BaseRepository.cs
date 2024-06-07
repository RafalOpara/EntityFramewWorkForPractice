using Microsoft.EntityFrameworkCore;

namespace WebApp.Database.Repositories.Base
{
    public abstract class BaseRepository<Entity> where Entity : class
    {
        protected WebAppDbContext _context;


        protected BaseRepository(WebAppDbContext dbContext)
        {
            _context = dbContext;
        }


        protected abstract DbSet<Entity> DbSet { get; }


        public List<Entity> GetAll()
        {
            var list = new List<Entity>();

            var entities = DbSet;

            foreach (var entity in entities)
            {
                list.Add(entity);
            }

            return list;
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }

}
