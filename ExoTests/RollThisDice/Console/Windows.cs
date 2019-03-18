using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    class Windows
    {
        public void Display(EventArgs e, GameConsole console)
        {
            switch (console.ActualWindow)
            {
                case AvaibleWindows.Mainmenu:
                    MainMenu();
                    break;
                case AvaibleWindows.Settings:
                    Settings();
                    break;
                case AvaibleWindows.History:
                    History();
                    break;
                case AvaibleWindows.Gameplay:
                    Gameplay();
                    break;
            }
            console.User.NextAction(e, console);
        }


        public void MainMenu()
        {
            System.Console.Clear();
            System.Console.WriteLine(
                "\n     MAIN MENU\n\n" +
                "   1  -> Main menu\n" +
                "   2  -> Settings\n" +
                "   3  -> History\n" +
                "   0  -> Exit game\n");
        }

        public void Settings()
        {
            System.Console.Clear();
            System.Console.WriteLine(
                "\n     SETTINGS\n\n" +
                "   0  -> Return\n");
        }

        public void History()
        {
            System.Console.Clear();
            System.Console.WriteLine(
                "\n     HISTORY  \n\n" +
                "   0  -> Return\n");
        }

        public void Gameplay()
        {
            System.Console.Clear();
            System.Console.WriteLine(
                "\n     GAMEPLAY WINDOW  \n\n" +
                "   0  -> Return\n");
        }
    }
}
