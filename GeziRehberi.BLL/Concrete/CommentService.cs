using GeziRehberi.BLL.Abstract;
using GeziRehberi.DAL.Abstract;
using GeziRehberi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeziRehberi.BLL.Concrete
{
    public class CommentService : ICommentService
    {
        ICommentsDAL _commentsDAL;
        public CommentService(ICommentsDAL commentDAL)
        {
            _commentsDAL = commentDAL;
        }
        public void Delete(Comments entity)
        {
            _commentsDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Comments Get(int entityID)
        {
            return _commentsDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Comments> GetAll()
        {
            return _commentsDAL.GetAll();
        }

        public void Insert(Comments entity)
        {
            _commentsDAL.Add(entity);
        }

        public void Update(Comments entity)
        {
            _commentsDAL.Update(entity);
        }
    }
}
