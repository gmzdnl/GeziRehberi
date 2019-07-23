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
    public class CityService : ICityService
    {
        ICityDAL _cityDAL;
        public CityService(ICityDAL cityDAL)
        {
            _cityDAL = cityDAL;
        }
        public void Delete(City entity)
        {
            _cityDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public City Get(int entityID)
        {
            return _cityDAL.Get(a => a.ID == entityID);
        }

        public ICollection<City> GetAll()
        {
            return _cityDAL.GetAll();
        }

        public List<City> GetTopFiveCity()
        {
            throw new NotImplementedException();
        }

        public void Insert(City entity)
        {
            _cityDAL.Add(entity);
        }

        public List<City> SearchCity(string searchtext)
        {
           return _cityDAL.GetAll().Where(a => a.Name.Contains(searchtext)).ToList();

        }

        public void Update(City entity)
        {
            _cityDAL.Update(entity);
        }
    }
}
