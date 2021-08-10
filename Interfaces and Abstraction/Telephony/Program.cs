using System;
using System.Collections.Generic;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] call = Console.ReadLine().Split(' ');

            string[] browse = Console.ReadLine().Split(' ');

            SmartPhone smartPhone = new SmartPhone(call, browse);
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var phoneNumber in call)
            {
                if (phoneNumber.Length == 10)
                {
                    Console.WriteLine(smartPhone.Calling(phoneNumber));
                }
                if (phoneNumber.Length == 7)
                {
                    Console.WriteLine(stationaryPhone.Calling(phoneNumber));
                }
            }

            foreach (var address in browse)
            {
                Console.WriteLine(smartPhone.Browsing(address));
            }
        }
    }
}


