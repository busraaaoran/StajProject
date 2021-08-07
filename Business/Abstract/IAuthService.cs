using Core.Utilities.Results;
using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Customer> Register(CustomerForRegisterDto customerForRegisterDto, string password);
        IDataResult<Customer> Login(CustomerForLoginDto customerForLoginDto);
        IResult CustomerExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Customer customer);
    }
}
