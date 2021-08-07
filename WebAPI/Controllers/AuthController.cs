using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(CustomerForLoginDto customerForLoginDto)
        {
            var customerToLogin = _authService.Login(customerForLoginDto);
            if (!customerToLogin.Success)
            {
                return BadRequest(customerToLogin.Message);
            }

            var result = _authService.CreateAccessToken(customerToLogin.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
      
        [HttpPost("register")]
        public ActionResult Register(CustomerForRegisterDto customerForRegisterDto)
        {
            var customerExists = _authService.CustomerExists(customerForRegisterDto.Email);
            if (!customerExists.Success)
            {
                return BadRequest(customerExists.Message);
            }

            var registerResult = _authService.Register(customerForRegisterDto, customerForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
