using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.User
{
    public class UserLoginCommand
    {
        /// <summary>
        /// شماره تلفن
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// کد تایید
        /// </summary>
        public string Password { get; set; }



     //   public UserRoles userRoles { get; set; }

    }
}
