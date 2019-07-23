using GeziRehberi.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeziRehberi.Model
{
    public class User:BaseEntity
    {

        //[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int ID { get; set; }

        //[StringLength(25, ErrorMessage = "{0} max. {1} karakter olmalı."), DisplayName("Ad")]

        public string Name { get; set; }

        //[StringLength(25, ErrorMessage = "{0} max. {1} karakter olmalı."), DisplayName("Soyad")]
      
        public string Surname { get; set; }

        /*        [StringLength(60, ErrorMessage = "{0} max. {1} karakter olmalı."), Required(ErrorMessage = "{0} boş geçilemez."), DisplayName("E-Posta")]*/
    
        public string Email { get; set; }

        //[StringLength(25, ErrorMessage = "{0} max. {1} karakter olmalı."), Required(ErrorMessage = "{0} boş geçilemez."), DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        
        public string RoleName { get; set; }

        //[StringLength(25, ErrorMessage = "{0} max. {1} karakter olmalı."), Required(ErrorMessage = "{0} boş geçilemez."), DisplayName("Şifre")]
        public string Password { get; set; }


        public virtual List<Comments> Comments { get; set; }

    }
}
