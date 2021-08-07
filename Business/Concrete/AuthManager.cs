using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using Entities.DTOs;


namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private ICustomerService _customerService;
        private ITokenHelper _tokenHelper;

        public AuthManager(ICustomerService customerService, ITokenHelper tokenHelper)
        {
            _customerService = customerService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<Customer> Register(CustomerForRegisterDto customerForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var customer = new Customer
            {
                Email = customerForRegisterDto.Email,
                FirstName = customerForRegisterDto.FirstName,
                LastName = customerForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _customerService.Add(customer);

            return new SuccessDataResult<Customer>(customer, Messages.CustomerRegistered);
        }

        public IDataResult<Customer> Login(CustomerForLoginDto customerForLoginDto)
        {
            var customerToCheck = _customerService.GetByMail(customerForLoginDto.Email);
            if (customerToCheck == null)
            {
                return new ErrorDataResult<Customer>(Messages.CustomerNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(customerForLoginDto.Password, customerToCheck.Data.PasswordHash, customerToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<Customer>(Messages.PasswordError);
            }

            return new SuccessDataResult<Customer> (customerToCheck.Data, Messages.SuccessfulLogin);
        }

        public IResult CustomerExists(string email)
        {
            var result = _customerService.GetByMail(email);
            if ( result.Data != null)
            {
                return new ErrorResult(Messages.CustomerAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(Customer customer)
        {
            var claims = _customerService.GetClaims(customer);
            var accessToken = _tokenHelper.CreateToken(customer, claims.Data);

            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}
