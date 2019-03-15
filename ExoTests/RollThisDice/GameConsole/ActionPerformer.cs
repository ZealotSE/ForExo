using System;
using RollThisDice.Interfaces;

namespace RollThisDice
{
    internal class ActionPerformer : IActionPerformer
    {
        void IActionPerformer.SelectAction(object sender, EventArgs e)
        {
            Console.WriteLine("Odebrano zgloszenie od "+sender.ToString());
        }
    }
}