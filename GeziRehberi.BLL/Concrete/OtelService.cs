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
    public class OtelService : IOtelService
    {
        IOtelDAL _otelDAL;
        public OtelService(IOtelDAL otelDAL)
        {
            _otelDAL = otelDAL;
        }
        public void Delete(Otel entity)
        {
            _otelDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Otel Get(int entityID)
        {
            return _otelDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Otel> GetAll()
        {
            return _otelDAL.GetAll();
        }

        public void Insert(Otel entity)
        {
            _otelDAL.Add(entity);
        }

        public void Update(Otel entity)
        {
            _otelDAL.Update(entity);
        }
    }
}
