using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplentationPizzaProject.Model
{
   public class PizzaCatalog
   {
       private List<Pizza> PizzaList;

       public PizzaCatalog()
       {
            PizzaList=new List<Pizza>();
       }

       public Pizza CreatePizza(string type, int quantity, string size)
       {
           Pizza pizza1= new Pizza();
           PizzaList.Add(pizza1);
           return pizza1;
       }
   }
}
