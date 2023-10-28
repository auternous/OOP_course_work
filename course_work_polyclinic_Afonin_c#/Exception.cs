using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace course_work_polyclinic_Afonin_c_
{
    public class Exception
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text,
        String caption, uint type);
    }
}
