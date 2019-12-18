using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.Model.Models
{
    public class Category:MyBaseClass
    {
        
        public List<Product> Products { get; set; }
    }
}
