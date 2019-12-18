using FakeData.Model.Models;
using GridMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.GridMvc
{
    public class FooGrid<T>:Grid<Product>
    {
        public FooGrid(IQueryable<Product> items):base(items)
        {
            Columns.Add(i=>i.Category.Name).Sortable(true);
            Columns.Add(i=>i.Name).Sortable(true);
            Columns.Add(i => i.Price).Sortable(true);
            Columns.Add(i => i.Stock).Sortable(true);


            EnablePaging = true;
            Pager.PageSize = 10;

            
        }
            
    } 
    
    
}
