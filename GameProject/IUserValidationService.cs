using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
