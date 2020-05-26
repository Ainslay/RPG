using System;
using System.Collections.Generic;

namespace RPG.Utilities
{
    public static class ParamCheck
    {
        /// <summary>Checks given object for null reference.</summary> 
        public static void IsNull(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>Checks given string for null reference or if the string is only whitespace.</summary>  
        public static void IsNullOrWhitespace(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException();
            }
        }

        /// <summary>Checks if given collection is null or empty.</summary>  
        public static void IsNullOrEmpty<T>(ICollection<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }

            if (collection.Count == 0)
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Checks if given numeric value is below zero.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        public static void IsBelowZero<T>(T value) where T : struct, IComparable<T>
        {
            if (value.CompareTo(default) < 0)
            {
                throw new ArgumentException("Value was below zero.");
            }
        }

        public static void IsDefinedIn(Type enumType, object value)
        {
            IsNull(enumType);
            IsNull(value);

            if (!enumType.IsEnum)
            {
                throw new ArgumentException("T must be an enumerable type");
            }

            if (!Enum.IsDefined(enumType, (int)value))
            {
                throw new ArgumentException($"{enumType.GetType()} does not define {value}");
            }
        }
    }
}
