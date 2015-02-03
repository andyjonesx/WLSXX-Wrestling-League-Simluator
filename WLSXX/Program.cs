using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLSXX.DataAccess;
using WLSXX.Model;
using WLSXX.Model.Enumerations;
using WLSXX.View;

namespace WLSXX
{
    class Program
    {
        static void Main(string[] args)
        {
            DataManager.LoadData();
            View.Menu.MainMenu.ShowMainMenu();
        }

        

        

        
    }
}
