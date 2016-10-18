using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Entities;

namespace BusinessLayer
{
    public class PosSystemBusiness
    {
        Product _product = new Product();
       string connection = "Data Source=JARVIS;Initial Catalog=POS_System;User ID=sa;Password=Deathstrok";
        public List<Product> GetItemValue(string firstValue, string secondValue)
        {

            using (Inventory_dbDataContext db =new Inventory_dbDataContext(connection))
            {
                _product = db.Rices.SingleOrDefault(x => x.id == secondValue);
                return _product;
            }

             
        }
    }
}
