using EcomProj.Model;
using EcomProj.Repository.Common.Repository.Interface;
using EcomProj.Repository.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcomProj.Repository.Common.Repository.Implementation
{
    public class ProductRepository : EFRepositoryBase<EcommerceContext, Product, int>, IProductRepository
    {
    }
}
