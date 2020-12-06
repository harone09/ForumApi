using HASOapi2.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HASOapi2.Models.DataManager
{
    public class UploadedfileManager : IDataRepository<Uploadedfile>
    {
        readonly HASODBContext _UploadedfileContext;

        public UploadedfileManager(HASODBContext context)
        {
            _UploadedfileContext = context;
        }

        public IEnumerable<Uploadedfile> GetAll()
        {
            return _UploadedfileContext.Uploadedfile.ToList();
        }

        public Uploadedfile Get(long id)
        {
            return _UploadedfileContext.Uploadedfile
                  .FirstOrDefault(e => e.Id == id);
        }

        public void Add(Uploadedfile entity)
        {
            _UploadedfileContext.Uploadedfile.Add(entity);
            _UploadedfileContext.SaveChanges();
        }

        public void Update(Uploadedfile Uploadedfile, Uploadedfile entity)
        {
            Uploadedfile.Date = entity.Date;
            Uploadedfile.path = entity.path;
            Uploadedfile.IdPublication = entity.IdPublication;
            Uploadedfile.IdUser = entity.IdUser;



            _UploadedfileContext.SaveChanges();
        }

        public void Delete(Uploadedfile Uploadedfile)
        {
            _UploadedfileContext.Uploadedfile.Remove(Uploadedfile);
            _UploadedfileContext.SaveChanges();
        }
    }
}