using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadlineService:IGenericService<Headline>
    {
        List<Headline> GetHeadLinesWithComments();
        Headline GetHeadlineComments(int id);
    }
}
