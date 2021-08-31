using DatingAppApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppApi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);

    }
}
