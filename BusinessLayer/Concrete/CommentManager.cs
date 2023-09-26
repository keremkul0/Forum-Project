using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _CommentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _CommentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
            _CommentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _CommentDal.Delete(t);
        }

        public List<Comment> TGetAll()
        {
            return _CommentDal.GetAll();
        }

        public Comment TGetByID(int id)
        {
            return _CommentDal.GetByID(id);
        }

        public void TUpdate(Comment t)
        {
            _CommentDal.Update(t);
        }
    }
}
