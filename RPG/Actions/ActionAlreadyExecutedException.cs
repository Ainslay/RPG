using System;

namespace RPG.Actions
{
    class ActionAlreadyExecutedException : Exception
    {
        public ActionAlreadyExecutedException()
        {
        }

        public ActionAlreadyExecutedException(string message) : base(message)
        {
        }

        public ActionAlreadyExecutedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
