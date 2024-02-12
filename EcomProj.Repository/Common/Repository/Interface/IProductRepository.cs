using EcomProj.Repository.Common.Repository;
using EcomProj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomProj.Repository.Common.Repository.Interface
{
    public interface IProductRepository: IRepository<Product, int>
    {
    }
}
