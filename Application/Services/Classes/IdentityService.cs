using Application.Commands.User;
using Application.Services.Interfaces;
using Domain.Helper;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Application.Mappers;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using Domain.Enums;
using Domain.Interfaces;

namespace Application.Services.Classes
{
    public class IdentityService : IIdentityService
    {
        private readonly IGenericRepository<User> _repository;
        private readonly JwtToken _jwtToken;
        private readonly UserManager<User> _userManager;
        private static readonly HttpClient client = new HttpClient();
        public IdentityService(UserManager<User> manager, IOptions<JwtToken> jwtToken, IGenericRepository<User> repository)
        {
            _userManager = manager;
            _jwtToken = jwtToken.Value;
            _repository = repository;
        }
        public async Task<string> LoginAsync(UserLoginCommand command)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(f => f.UserName == command.UserName);
            


            if (user == null)
                throw new Exception("نام وارد شده صحیح نمی باشد");

            if (user.Password!=command.Password)
                throw new Exception("رمز ورود اشتباه است");

            var token = await GenerateToken(user.Id, user.userRoles,command);
            return token;

        }

        private async Task<string> GenerateToken(string id,UserRoles roles, UserLoginCommand command)
        {
            var secretkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtToken.Key));
            var credentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);
            var tokenOption = new JwtSecurityToken(
                issuer: _jwtToken.Issuer,
                claims: new List<Claim>
                {
                    new Claim(ClaimTypes.Role,roles.ToString()),
                    new Claim("id",id)
                },
                expires: DateTime.Now.AddDays(15),
                signingCredentials: credentials
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOption);
            return tokenString;
        }

        public async Task RegisterAsync(RegisterUserCommand command)
        {
            var userrr= await _repository.GetAll();
            var match= userrr.ToList().Where(u => u.UserName == command.UserName).ToList();
            if (match.Any())
                throw new Exception("match name Found");

            await _repository.AddAsync(new User(command.FundName, UserRoles.Admin, command.UserName, command.Password));
            await _repository.Complete();
            
            //var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == command.UserName);
            //if (user == null)
            //{
            //    user = new User( command.FundName,UserRoles.Admin,command.UserName,command.Password);
            //    var result = await _userManager.CreateAsync(user, user.Password);
            //}


        }
        private async Task SendSms(string phoneNumber, string code)
        {
            try
            {

                var values = new Dictionary<string, string> { { "PhoneNumber", phoneNumber }, { "Message", code } };

                var response = await client.PostAsync("http://194.36.174.133:5002/api/Notification/add", values, new JsonMediaTypeFormatter());

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }



        private async Task SendSmsAsync(string phoneNumber, string code)
        {

            try
            {

                var values = new Dictionary<string, string> { { "PhoneNumber", phoneNumber }, { "Message", code } };

                var response = await client.PostAsync("http://194.36.174.133:5002/api/Notification/add", values, new JsonMediaTypeFormatter());

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }


    }
}
