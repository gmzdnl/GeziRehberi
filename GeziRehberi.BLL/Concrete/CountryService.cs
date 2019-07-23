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
    public class CountryService:ICountryService
    {
        ICountryDAL _countryDAL;
        public CountryService(ICountryDAL countryDAL)
        {
            _countryDAL = countryDAL;
        }

        public void Insert(Country entity)
        {
            _countryDAL.Add(entity);
        }

        public void Delete(Country entity)
        {
            _countryDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public void Update(Country entity)
        {
            _countryDAL.Update(entity);
        }

        public Country Get(int entityID)
        {
            return _countryDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Country> GetAll()
        {
            return _countryDAL.GetAll();
        }


    }
}
