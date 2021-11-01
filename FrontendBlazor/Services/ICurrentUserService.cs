using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendBlazor
{
    public interface ICurrentUserService
    {
        string UserId { get; }
    }
}
