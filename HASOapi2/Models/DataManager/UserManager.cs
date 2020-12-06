using HASOapi2.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HASOapi2.Models.DataManager
{
    public class UserManager : IDataRepository<User>
    {
        readonly HASODBContext _HASODBContext;

        public UserManager(HASODBContext context)
        {
            _HASODBContext = context;
        }

        public void Add(User entity)
        {
            _HASODBContext.User.Add(entity);
            _HASODBContext.SaveChanges();
        }

        public void Delete(User entity)
        {
            _HASODBContext.User.Remove(entity);
            _HASODBContext.SaveChanges();
        }

        public User Get(long id)
        {
            return _HASODBContext.User.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _HASODBContext.User.ToList();
        }

        public void Update(User dbEntity, User entity)
        {
            dbEntity.Login = entity.Login;
            dbEntity.Phone = entity.Phone;
            dbEntity.Name = entity.Name;
            dbEntity.Email = entity.Email;

            _HASODBContext.SaveChanges();
        }
    }
}
