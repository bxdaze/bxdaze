﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_login;
using  LWHY;
using WindowsFormsUser;

namespace LWHY题库及学习系统
{
    static class Program
    {
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FLogin fl = new FLogin();
            fl.ShowDialog();
            if(fl.DialogResult==DialogResult.OK)
            {
                Application.Run(new UserFrame());
            }
            
        }
    }
}
