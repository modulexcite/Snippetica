﻿using System;

namespace Pihrtsoft.Snippets
{
    public static class StringExtensions
    {
        public static string Enclose(this string value, string enclosingValue)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (enclosingValue == null)
                throw new ArgumentNullException(nameof(enclosingValue));

            return $"{enclosingValue}{value}{enclosingValue}";
        }

        public static string FirstCharToLowerInvariant(this string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (value.Length == 0)
                return value;

            return char.ToLowerInvariant(value[0]) + value.Substring(1);
        }

        public static string FirstCharToUpperInvariant(this string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (value.Length == 0)
                return value;

            return char.ToUpperInvariant(value[0]) + value.Substring(1);
        }
    }
}