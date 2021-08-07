using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        //db den müşterinin claimlerini çekmek için kullanacağımız metodu tanımladık
        List<OperationClaim> GetClaims(Customer customer);
    }
}
