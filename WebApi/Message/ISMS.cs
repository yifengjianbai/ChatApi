using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public interface ISMS
    {
        string execute(PhoneMessage message, int sendType, string IpAndPort, int authenticationMode, bool bKeepAlive);
    }
}
