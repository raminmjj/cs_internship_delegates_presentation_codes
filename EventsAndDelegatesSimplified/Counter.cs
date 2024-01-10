using System;

namespace EventsAndDelegatesSimplified
{
    public delegate void NumberReachedEventHandler(object sender, NumberReachedEventArgs e);

    public class Counter
    {
        public event NumberReachedEventHandler NumberReached;

        public void CountTo(int countTo, int reachableNum)
        {
            if (countTo < reachableNum)
                throw new ArgumentException("reachableNum should be less than countTo");
            for (int ctr = 0; ctr <= countTo; ctr++)
            {
                if (ctr == reachableNum)
                {
                    NumberReachedEventArgs e = new NumberReachedEventArgs(reachableNum);
                    OnNumberReached(e);
                    return;
                }
            }
        }

        protected virtual void OnNumberReached(NumberReachedEventArgs e)
        {
            if (NumberReached != null)
            {
                NumberReached(this, e);
            }
        }
    }

    public class NumberReachedEventArgs : EventArgs
    {
        private int _reached;
        public NumberReachedEventArgs(int num)
        {
            this._reached = num;
        }
        public int ReachedNumber
        {
            get
            {
                return _reached;
            }
        }
    }
}
