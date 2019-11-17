using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.Model.Models
{
    public class MyBaseClass
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name ="Ad")]
        [Required(ErrorMessage ="Bu alan boş geçilemez.")]
        public string Name { get; set; }

    }
}
