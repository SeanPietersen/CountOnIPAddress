using System;
using System.Net;

namespace CountOnIPAddress.App
{
    public class CalculateTheNumberOfIPAddressesBetweenTwoIPAddresses : ICalculateTheNumberOfIPAddressesBetweenTwoIPAddresses
    {
        public ulong IpsBetween(string start, string end)
        {
            //    ulong addressStart = (ulong)IPAddress.NetworkToHostOrder((int)BitConverter.ToUInt32(IPAddress.Parse(start).GetAddressBytes(), 0));
            //    ulong addressEnd = (ulong)IPAddress.NetworkToHostOrder((int)BitConverter.ToUInt32(IPAddress.Parse(end).GetAddressBytes(), 0));

            //    return addressEnd - addressStart;

            var stringArrayStart = start.Split(".");
            var stringArrayEnd = end.Split(".");
            ulong count = 0;
            int power = 24;

            for (int i = 0; i < 4; i++)
            {

                if (i == 3)
                {
                    count += (ulong.Parse(stringArrayEnd[i]) - ulong.Parse(stringArrayStart[i]));
                }
                else
                {
                    var difference = (ulong.Parse(stringArrayEnd[i]) - ulong.Parse(stringArrayStart[i]));
                    count += (difference * (ulong)Math.Pow(2, power) );
                }
                power = power-8;
            }

            return count;
        }
    }
}
