using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.EmailHub
{
    public static class OtpManager
    {
        public static string currentOtp;
        
        public static string GenerateOtp()
        {
            currentOtp = new Random().Next(100000, 999999).ToString();
            return currentOtp;
        }
        public static bool VerifyOtp(string input)
        {
            return currentOtp.Equals(input);
        }
        public static string ClearOtp()
        {
            return null;
        }
    }
}
