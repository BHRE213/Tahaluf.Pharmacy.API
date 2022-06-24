using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Tahaluf.Pharmace.Core.IRepository;
using Tahaluf.Pharmace.Core.IService;
using Tahaluf.Pharmacy.API.Data;

namespace Tahaluf.Pharmace.Infra.Service
{
   public class LoginService: ILoginService
    {
        private readonly ILoginRepository loginRepository;
        public LoginService(ILoginRepository _loginRepository)
        {
            loginRepository = _loginRepository;
        }
        public string userlogin(Useraccount login)
        {

            var LoginResult = loginRepository.userlogin(login);
            if (LoginResult != null)
            {
                //valid user >> gererat token

                //1- token handler

                var TokenHandler = new JwtSecurityTokenHandler();
                var TokenKey = Encoding.ASCII.GetBytes("khndtkgodr kgrmgktr mkesjrnnt xvkjhbvkjds uhuihuihu");

                var TokenDes = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
               {
               new Claim(ClaimTypes.Email , LoginResult.Email),
                new Claim(ClaimTypes.Role , LoginResult.Rolename),
               }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(TokenKey),
               SecurityAlgorithms.HmacSha256Signature)
                };
                var token = TokenHandler.CreateToken(TokenDes);
                return TokenHandler.WriteToken(token);
            }
            else
            {
                //Not valid user
                return null;
            }
        }
    }
}
