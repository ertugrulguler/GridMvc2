using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.Model.Models
{
    public class Customer:MyBaseClass
    {
        [Display(Name ="Soyad")]
        [Required(ErrorMessage ="Bu alan boş geçilemez.")]
        public string Surname { get; set; }
        [Display(Name = "Adres")]
        public string Adress { get; set; }
        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Bu alan girilmesi zorunludur.")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Yaş")]
        public byte Age { get; set; }
        [Display(Name ="Cinsiyet")]
        public string Gender { get; set; }

    }
}
