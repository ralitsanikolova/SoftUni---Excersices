using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Telephony
{
    class SmartPhone : ISmartphone
    {
        private string[] call;
        private string[] browse;

        public SmartPhone(string[] call, string[] browse)
        {
            this.call = call;
            this.browse = browse;
        }

        public string Calling(string call)
        {
            if (Regex.IsMatch(call, @"^\d+$"))
            {
                return $"Calling... {call}";    
            }
           
            else
            {
                return "Invalid number";
            }
        }
        public string Browsing(string address)
        {
            if (Regex.IsMatch(address, @"^\D+$"))
            {
                return $"Browsing: {address}!";
               
            }
            else
            {
                return "Invalid URL!";
            }   
        }
    }
}


