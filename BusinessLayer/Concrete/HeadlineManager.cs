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
    public class HeadlineManager : IHeadlineService
    {
        IHeadlineDal _HeadlineDal;

        public HeadlineManager(IHeadlineDal headlineDal)
        {
            _HeadlineDal = headlineDal;
        }

        public void TAdd(Headline t)
        {
            _HeadlineDal.Insert(t);  
        }

        public void TDelete(Headline t)
        {
            _HeadlineDal.Delete(t);
        }

        public List<Headline> TGetAll()
        {
            return _HeadlineDal.GetAll();
        }

        public Headline TGetByID(int id)
        {
            return _HeadlineDal.GetByID(id);
        }

        public void TUpdate(Headline t)
        {
            _HeadlineDal.Update(t);
        }
    }
}