using GeziRehberi.DAL.Abstract;
using GeziRehberi.DAL.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeziRehberi.BLL.Ninject
{
    //Dependency Injection uygulamak için Ninject kütüphanesini kullandık.
    //Amacımız instance almak yerine enjekte ederek uygulamak.Bunun içinde Ninject module içinde override ettiğimiz load metodunun içindeki Bind metodunu kullandık.
    public class CustomDALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserDAL>().To<UserRepository>();
            Bind<ICityDAL>().To<CityRepository>();
            Bind<ICommentsDAL>().To<CommentsRepository>();
            Bind<ICountryDAL>().To<CountryRepository>();
            Bind<IContinentDAL>().To<ContinentRepository>();
            Bind<IVisitingPlacesDAL>().To<VisitingPlacesRepository>();
            Bind<IOtelDAL>().To<OtelRepository>();
            Bind<IRestaurantDAL>().To<RestaurantReposiitory>();
        }
    }
}
