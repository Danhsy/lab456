using Microsoft.AspNet.Identity;
using System.Collections.Generic;

namespace lab456.Controllers
{
    internal class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public bool BrowserRemembered { get; set; }
    }
}