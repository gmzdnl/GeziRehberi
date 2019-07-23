using GeziRehberi.Core.DAL.EntityFramework;
using GeziRehberi.DAL.Abstract;
using GeziRehberi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeziRehberi.DAL.Concrete.EntityFramework
{
   public class OtelRepository:EFRepositoryBase<Otel, GeziDbContext>,IOtelDAL
    {
    }
}
