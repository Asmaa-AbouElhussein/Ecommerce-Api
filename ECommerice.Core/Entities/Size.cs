using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerice.Core.Entities
{
    public class Size : BaseEntity
    {
        public string value { get; set; }
       
        public virtual Product Product { get; set; }
      

        public int ProductId { get; set; }
    }
}
