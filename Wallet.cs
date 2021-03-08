using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpConsoleApp1
{
    class Wallet
    {
        private static int Id { get; set; }
        private List<User> Masters { get; set; }
        private bool Valid { get { return this.Masters.Count > 0; } }
        private string Name { get; set; }
        private double OriginBalance { get; set; }
        private string About { get; set; }
        private char Currency { get; set; }
        private List<Transaction> Transactions { get; set; }
        private List<Category> Categories { get; set; }
        private double LastMonthIncome { get {
                double sum = 0;
                foreach (var t in Transactions)
                {
                    if ((DateTime.Now - t.Date).Days < 30 && t.Income)
                    {
                        sum += t.Sum;
                    }
                }
                return sum;
            }
        }
        private double LastMonthOutcome
        {
            get
            {
                double sum = 0;
                foreach (var t in Transactions)
                {
                    if ((DateTime.Now - t.Date).Days < 30 && !t.Income)
                    {
                        sum += t.Sum;
                    }
                }
                return sum;
            }
        }
        private List<Transaction> TenTrans(int n) // ♂️ B 0 $ $ ♂️
        {
            List<Transaction> List = this.Transactions.Skip(Math.Max(0, n)).Take(10).ToList();
            return List;
        }
    }
}
