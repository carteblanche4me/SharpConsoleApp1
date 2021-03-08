using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SharpConsoleApp1
{
    class Transaction
    {
        public double Sum { get; set; }
        public bool Income { get { return this.Sum > 0; } }
        private char Currency { get; set; }
        private Category Category { get; set; }
        private string About { get; set; }
        public DateTime Date { get; set; }
        private FileInfo File { get; set; }
    }
}
