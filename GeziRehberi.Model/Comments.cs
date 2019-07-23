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
    public class Comments:BaseEntity
    {
        [Required, DisplayName("Yorum")]
        public string Comment { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [DisplayName("Şehir")]
        public int CityID { get; set; }

        public int UserID { get; set; }

        public virtual City City { get; set; }
        public virtual User User { get; set; }
    }
}
