using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LWHY;

namespace RecordQuestion
{
   public static class CommonCheck
    {
        public static bool CheckText(TextBox test)
        {
            if (test.Text.Trim() == String.Empty) return false;
            return true;
        }
    }
}
