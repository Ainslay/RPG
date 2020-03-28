using System;
using System.Collections.Generic;
using System.Text;

using RPG.Character.Stats;

namespace RPG.Character
{
    class Proffesion
    {
        private string _name;
        private Resource _resource;
        private Attributes _baseAttributes;

        public Proffesion(string name, Resource resource)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if(resource == null)
            {
                throw new ArgumentNullException(nameof(resource));
            }

            _name = name;
            _resource = resource;
        }

    }
}
