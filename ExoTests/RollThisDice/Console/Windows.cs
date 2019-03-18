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
            console.User.PressButton(e, console);
        }
        

        public void MainMenu()
        {
            System.Console.Clear();
            System.Console.WriteLine(
                "\n     MAIN MENU\n\n" +
                "   1  -> Main menu\n" +
                "   2  -> Settings\n"  +
                "   0  -> Exit game\n" +
                "other -> Default\n");
        }

        public void Settings()
        {
            System.Console.Clear();
            System.Console.WriteLine(
                "\n     SETTINGS\n\n"  +
                "   1  -> Main menu\n" +
                "   2  -> Settings\n"  +
                "   0  -> Exit game\n" +
                "other -> Default\n");
        }

        public void History()
        {
            System.Console.Clear();
            System.Console.WriteLine(
                "\n     DEFAULT  \n\n" +
                "   1  -> Main menu\n" +
                "   2  -> Settings\n"  +
                "   0  -> Exit game\n" +
                "other -> Default\n");
        }

        public void Gameplay()
        {
            System.Console.Clear();
            System.Console.WriteLine(
                "\n     GAMEPLAY WINDOW  \n\n" +
                "   1  -> Main menu\n" +
                "   2  -> Settings\n" +
                "   0  -> Exit game\n" +
                "other -> Default\n");
        }
    }
}
