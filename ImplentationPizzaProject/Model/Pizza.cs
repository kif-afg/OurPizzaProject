using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplentationPizzaProject.Model
{
   public class Pizza
   {
       private string _type;
       private int _quantity;
       private string _size;

       public string Type
       {
           set { this._type = value; }
           get { return _type; }
       }

       public int Quantity
       {
           set { this._quantity = value; }
           get { return _quantity; }
       }

       public string Size
       {
           set { this._size = value; }
           get { return _size; }
       }


       public Pizza()
       {
       }
   }
}
