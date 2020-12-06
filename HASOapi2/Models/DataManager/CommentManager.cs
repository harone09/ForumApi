using HASOapi2.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HASOapi2.Models.DataManager
{
    public class CommentManager : IDataRepository<Comment>
    {
        readonly HASODBContext _HASODBContext;

        public CommentManager(HASODBContext context)
        {
            _HASODBContext = context;
        }

        public void Add(Comment entity)
        {
            _HASODBContext.Comment.Add(new Comment
            {
                Contenus=entity.Contenus,
                Date= entity.Date,
                IdPublication= entity.IdPublication,
                IdUser= entity.IdUser
            });
            _HASODBContext.SaveChanges();
        }

        public void Delete(Comment entity)
        {
            _HASODBContext.Comment.Remove(entity);
            _HASODBContext.SaveChanges();
        }

        public Comment Get(long id)
        {
            return _HASODBContext.Comment.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Comment> GetAll()
        {
            return _HASODBContext.Comment.ToList();
        }

        public void Update(Comment dbEntity, Comment entity)
        {
            dbEntity.Contenus = entity.Contenus;

            _HASODBContext.SaveChanges();
        }
    }
}
