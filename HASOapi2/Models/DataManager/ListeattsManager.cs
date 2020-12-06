using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HASOapi2.Models.Repository;


namespace HASOapi2.Models.DataManager
{
    public class ListeattsManager : IDataRepository<Listeatt>
    {

        readonly HASODBContext _HASODBContext;

        public ListeattsManager(HASODBContext context)
        {
            _HASODBContext = context;
        }

        public void Add(Listeatt entity)
        {
            _HASODBContext.Listeatt.Add(entity);
            _HASODBContext.SaveChanges();
        }

        public void Delete(Listeatt entity)
        {
            _HASODBContext.Listeatt.Remove(entity);
            _HASODBContext.SaveChanges();
        }

        public Listeatt Get(long id)
        {
            return _HASODBContext.Listeatt.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Listeatt> GetAll()
        {
            return _HASODBContext.Listeatt.ToList();
        }

        public void Update(Listeatt dbEntity, Listeatt entity)
        {
            dbEntity.name = entity.name;

            _HASODBContext.SaveChanges();
        }
    }
}
