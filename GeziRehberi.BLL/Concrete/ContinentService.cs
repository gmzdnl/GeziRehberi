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
    public class ContinentService : IContinentService
    {
        IContinentDAL _continentDAL;
        public ContinentService(IContinentDAL continentDAL)
        {
            _continentDAL = continentDAL;
        }
        public void Delete(Continent entity)
        {
            _continentDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Continent Get(int entityID)
        {
            return _continentDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Continent> GetAll()
        {
            return _continentDAL.GetAll();
        }

        public void Insert(Continent entity)
        {
             _continentDAL.Add(entity);
        }

        public void Update(Continent entity)
        {
            _continentDAL.Update(entity);
        }
    }
}
