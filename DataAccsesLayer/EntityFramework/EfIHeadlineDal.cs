using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfIHeadlineDal : GenericRepository<Headline>, IHeadlineDal
    {
        public Headline GetHeadlineComments(int id)
        {
            using (var context = new Context())
            {
                return context.Headline.Include(x => x.Comments).Where(x=>x.HeadlineId==id).FirstOrDefault();
            }
        }

        public List<Headline> GetHeadLinesWithComments()
        {
            using(var context=new Context())
            {
               return context.Headline.Include(x=>x.Comments).ToList();
            }
        }
    }
}
