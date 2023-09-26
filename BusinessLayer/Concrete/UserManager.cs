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
    public class UserManager : IUserService
    {
        IUserDal _UserDal;

        public UserManager(IUserDal userDal)
        {
            _UserDal = userDal;
        }

        public void TAdd(User t)
        {
            _UserDal.Insert(t);
        }

        public void TDelete(User t)
        {
            _UserDal.Delete(t);
        }

        public List<User> TGetAll()
        {
            return _UserDal.GetAll();
        }

        public User TGetByID(int id)
        {
            return _UserDal.GetByID(id);
        }

        public void TUpdate(User t)
        {
            _UserDal.Update(t);
        }
    }
}
