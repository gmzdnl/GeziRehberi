using GeziRehberi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeziRehberi.BLL.Abstract
{
    public interface ICityService:IBaseService<City>
    {
        List<City> GetTopFiveCity();
        List<City> SearchCity(string searchtext);

    }
}
