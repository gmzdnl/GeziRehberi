using GeziRehberi.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeziRehberi.Model
{
    public class VisitingPlaces:BaseEntity
    {
        [Required, DisplayName("Adı")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }

        
        public int CityID { get; set; }

        
        public virtual City City { get; set; }

    }
}
