using FakeData.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.GridMvc
{
    public class Foo
    {

     
        public int ID { get; set; }
      
        public string Name { get; set; }
       
        public decimal Price { get; set; }
       
        public int Stock { get; set; }


        public virtual Category Category { get; set; }
        //public string Title { get; set; }
        //public string Description { get; set; }
    }
}
