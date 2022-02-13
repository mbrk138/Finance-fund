using Application.Commands.User;
using Application.Services.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Classes
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _manager;
        private static readonly HttpClient client = new HttpClient();
        public IdentityService(UserManager<User> manager)
        {
            _manager = manager; 
        }
        public Task<string> LoginAsync()
        {
            throw new NotImplementedException();
        }

        public async Task RegisterAsync(RegisterUserCommand command)
        {
            var user = await _manager.Users.FirstOrDefaultAsync(x => x.PhoneNumber == command.PhoneNumber);
            if (user == null)
            {
                user = new User(command.PhoneNumber);
                var result = _manager.CreateAsync(user, user.PhoneNumber);

            }

            var code = await _manager.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);

            await SendSmsAsync(user.PhoneNumber, code);
            
        }
        private  async Task SendSmsAsync (string phoneNumber, string code)
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
