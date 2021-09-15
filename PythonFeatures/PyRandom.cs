using System;
using System.Linq;
// ReSharper disable MemberCanBePrivate.Global

namespace LyraMakes.PythonFeatures
{
    /// <summary>
    /// Class <code>PyRandom</code> provides methods
    /// to retrieve random numbers, strings, etc..
    /// </summary>
    public class PyRandom
    {
        private readonly Random _random;
        
        public PyRandom()
        {
            _random = new Random();
        }

        public PyRandom(Random random)
        {
            _random = random;
        }
        
        /// <summary>Returns a non-negative random integer.</summary>
        /// <returns>
        /// A 32-bit signed integer that is greater than
        /// or equal to 0 and less than <see cref="int.MaxValue">int.MaxValue</see>.
        /// </returns>
        public int RandInt() => _random.Next();
        
        /// <summary>
        /// Returns a randomly generated string of the given length.
        /// </summary>
        /// <param name="len">The length of the string to be generated.</param>
        /// <returns>A string of length <paramref name="len"/>.</returns>
        public string RandString(int len) => RandString(len, PyString.Printable);
        
        /// <summary>
        /// Returns a randomly generated string of the
        /// given length from the provided <paramref name="charlist"/>.
        /// </summary>
        /// <param name="len">The length of the string to be generated.</param>
        /// <param name="charlist">The allowed characters in the string..</param>
        /// <returns>A string of length <paramref name="len"/>.</returns>
        public string RandString(int len, string charlist)
        {
            return new string(Enumerable.Repeat(charlist, len)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}