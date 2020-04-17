using System;
using System.Collections.Generic;
using System.Text;

namespace RPG.Actions
{
    class Action
    {
        protected bool _executed;

        public void IsAlreadyExecuted()
        {
            if (_executed)
            {
                throw new ActionAlreadyExecutedException("There was an attempt to execute an action that has already been executed.");
            }
        }
    }
}
