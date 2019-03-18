using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollThisDice
{
    public class Windows
    {
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

        public void Default()
        {
            System.Console.Clear();
            System.Console.WriteLine(
                "\n     DEFAULT  \n\n" +
                "   1  -> Main menu\n" +
                "   2  -> Settings\n"  +
                "   0  -> Exit game\n" +
                "other -> Default\n");
        }
    }
}
