using System.Collections.Generic;

namespace Northwind.Model
{
    public class ViewProducts
    {
        public Category category { get; set; }
        public IEnumerable<Product> products { get; set; }
    }
}