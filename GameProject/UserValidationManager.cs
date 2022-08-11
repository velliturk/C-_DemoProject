using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    internal class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1958 && gamer.FirstName == "VELİ" && gamer.LastName == "TÜRK" &&
                gamer.IdentityNumber == 2132432412)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
