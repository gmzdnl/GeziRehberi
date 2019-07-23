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
    public class Country:BaseEntity
    {
        [Required, DisplayName("Adı")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

      
    }
}
