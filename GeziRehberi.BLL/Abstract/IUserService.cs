using GeziRehberi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeziRehberi.BLL.Abstract
{
    public interface IUserService:IBaseService<User>
    {
        User GetUserByLogin(string userName, string password);
    }
}
