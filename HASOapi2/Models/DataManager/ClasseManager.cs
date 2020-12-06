using HASOapi2.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HASOapi2.Models.DataManager
{
    public class ClasseManager : IDataRepository<Classe>
    {
        readonly HASODBContext _HASODBContext;

        public ClasseManager(HASODBContext context)
        {
            _HASODBContext = context;
        }
        public void Add(Classe entity)
        {
            _HASODBContext.Classe.Add(entity);
            _HASODBContext.SaveChanges();
        }

        public void Delete(Classe entity)
        {
            _HASODBContext.Classe.Remove(entity);
            _HASODBContext.SaveChanges();
        }

        public Classe Get(long id)
        {
            return _HASODBContext.Classe.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Classe> GetAll()
        {
            return _HASODBContext.Classe.ToList();
        }

        public void Update(Classe dbEntity, Classe entity)
        {
            dbEntity.Members += 1;
        

            _HASODBContext.SaveChanges();
        }
    }
}
