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
    public class RestaurantService : IRestaurantService
    {
        IRestaurantDAL _restaurantDAL;
        public RestaurantService(IRestaurantDAL restaurantDAL)
        {
            _restaurantDAL = restaurantDAL;
        }
        public void Delete(Restaurant entity)
        {
            _restaurantDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Restaurant Get(int entityID)
        {
            return _restaurantDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Restaurant> GetAll()
        {
           return _restaurantDAL.GetAll();
        }

        public void Insert(Restaurant entity)
        {
            _restaurantDAL.Add(entity);
        }

        public void Update(Restaurant entity)
        {
            _restaurantDAL.Update(entity);
        }
    }
}
