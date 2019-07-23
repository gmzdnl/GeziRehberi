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
    public class VisitingPlacesService : IVisitingPlacesService
    {
        IVisitingPlacesDAL _visitingplacesDAL;
        public VisitingPlacesService(IVisitingPlacesDAL visitingPlacesDAL)
        {
            _visitingplacesDAL = visitingPlacesDAL;
        }

        public void Delete(VisitingPlaces entity)
        {
            _visitingplacesDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));

        }

        public VisitingPlaces Get(int entityID)
        {
            return _visitingplacesDAL.Get(a => a.ID == entityID);
        }

        public ICollection<VisitingPlaces> GetAll()
        {
            return _visitingplacesDAL.GetAll();
        }

        public void Insert(VisitingPlaces entity)
        {
            _visitingplacesDAL.Add(entity);
        }

        public void Update(VisitingPlaces entity)
        {
            _visitingplacesDAL.Update(entity);
        }
    }
}
