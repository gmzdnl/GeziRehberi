using GeziRehberi.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeziRehberi.Model
{
    public class Restaurant:BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public string ImageUrl { get; set; }
        public int CityID { get; set; }
        
        public virtual City City { get; set; }
        
    }
}
