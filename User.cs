using System;
using System.Collections.Generic;
using System.Text;

namespace SharpConsoleApp1
{
    class User
    {
        private string FName { get; set; }
        private string SName { get; set; }
        private string Email { get; set; }
        private List<Wallet> Wallets { get; set; }
        private List<Category> Categories{ get; set; }
    }
}
