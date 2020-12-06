using HASOapi2.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HASOapi2.Models.DataManager
{
    public class PublicationManager : IDataRepository<Publication>
    {
        readonly HASODBContext _HASODBContext;

        public PublicationManager(HASODBContext context)
        {
            _HASODBContext = context;
        }

        public void Add(Publication entity)
        {
            _HASODBContext.Publication.Add(entity);
            _HASODBContext.SaveChanges();
        }

        public void Delete(Publication entity)
        {

            _HASODBContext.Publication.Remove(entity);

            foreach (Comment c in  _HASODBContext.Comment.Where(n=>n.IdPublication==entity.Id).ToList())
            {
                _HASODBContext.Comment.Remove(c);

            }

            foreach (Uploadedfile c in _HASODBContext.Uploadedfile.Where(n => n.IdPublication == entity.Id).ToList())
            {
                _HASODBContext.Uploadedfile.Remove(c);

            }

            _HASODBContext.SaveChanges();
        }

        public Publication Get(long id)
        {
            return _HASODBContext.Publication.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Publication> GetAll()
        {
            return _HASODBContext.Publication.ToList();
        }

        public void Update(Publication dbEntity, Publication entity)
        {
            dbEntity.Contenus = entity.Contenus;
        
            _HASODBContext.SaveChanges();
        }
    }
}
