using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Models
{
    public class Basket
    {
        Int64 _id;
        public Int64 ID
        {
            get => _id;

            set => _id = value;           
        }
    
        /*public Int64 ID { get {
                return ID - 2;
            }
            set {
                this.ID = 12;
            }
        }*/
        public List<string> Items { get; set; }
        public string Order { get; set; }
        public string BasketName {get; set;}
    }


}
