using System.ComponentModel.DataAnnotations;

namespace FakeData.Model.Models
{
    public class Product:MyBaseClass
    {
        [Display(Name="Fiyat")]
        public decimal Price { get; set; }
        [Display(Name="Stok")]
        public int Stock { get; set; }


        public Category Category { get; set; }
    }
}