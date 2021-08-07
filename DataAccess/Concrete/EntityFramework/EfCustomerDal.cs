using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer,ProjectDbContext>, ICustomerDal
    {
        public List<OperationClaim> GetClaims(Customer customer)
        {
            using (var context = new ProjectDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join customerOperationClaim in context.CustomerOperationClaims
                                 on operationClaim.Id equals customerOperationClaim.OperationClaimId
                             where customerOperationClaim.CustomerId == customer.CustomerId
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
