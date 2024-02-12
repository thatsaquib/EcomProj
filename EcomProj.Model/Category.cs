using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomProj.Model
{
    public class Category: IEntity<int>
    {
        public int Id { get; set; }
    }
}
