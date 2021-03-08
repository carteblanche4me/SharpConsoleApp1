using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace SharpConsoleApp1
{
    class Category
    {
        private string Name { get; set; }
        private string About { get; set; }
        private Color Color { get; set; }
        private FileInfo Icon { get; set; }
    }
}
