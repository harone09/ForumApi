using HASOapi2.Models;
using HASOapi2.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HASOapi2.Models.DataManager
{
    public class ListefinalManager : IDataRepository<Listefinal>
    {
        readonly HASODBContext _HASODBContext;

        public ListefinalManager(HASODBContext context)
        {
            _HASODBContext = context;
        }
        public void Add(Listefinal entity)
        {
            _HASODBContext.Listefinal.Add(entity);
            _HASODBContext.SaveChanges();
        }

        public void Delete(Listefinal entity)
        {
            _HASODBContext.Listefinal.Remove(entity);
            _HASODBContext.SaveChanges();
        }

        public Listefinal Get(long id)
        {
            return _HASODBContext.Listefinal.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Listefinal> GetAll()
        {
            return _HASODBContext.Listefinal.ToList();
        }

        public void Update(Listefinal dbEntity, Listefinal entity)
        {

            dbEntity.idc = entity.idc;
            dbEntity.name = entity.name;
            dbEntity.ide = entity.ide;

            _HASODBContext.SaveChanges();
        }
    }
}

