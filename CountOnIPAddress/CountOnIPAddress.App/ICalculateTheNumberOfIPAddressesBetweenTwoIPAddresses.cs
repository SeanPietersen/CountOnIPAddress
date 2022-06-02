using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOnIPAddress.App
{
    public interface ICalculateTheNumberOfIPAddressesBetweenTwoIPAddresses
    {
        ulong IpsBetween(string start, string end);
    }
}
