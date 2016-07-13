//========================== MAIN ===================================
//Author:                   Thomas Tran
//Author's email:           trangiadat86@gmail.com
//Course:                   CPSC223N
//Assignment number:        Assignment 3
//Due date:                 Mar 16, 2015
//========================== MAIN ===================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace tictactoe
{
     static class Program
     {
          [STAThread]
          static void Main()
          {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new Form1());
          }
     }
}
