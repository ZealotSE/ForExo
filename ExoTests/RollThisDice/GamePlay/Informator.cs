using System;

namespace RollThisDice
{
    public class SampleEventArgs : EventArgs
    {
        public SampleEventArgs(string s) { Text = s; }
        public String Text { get; } // readonly
    }
    public class Informator : Interfaces.IBroadcast
    {
        public Informator()
        {
            
        }
        public void callme()
        {
            OnActionPerformed.Invoke(this, new SampleEventArgs("Here's Johny"));
        }

        public event EventHandler OnStateChanged;
        public event EventHandler OnActionPerformed;
         
    }
}