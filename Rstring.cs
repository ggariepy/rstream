// <copyright file="Rstring.cs">
// Released under the terms of the Unlicense.  Visit http://unlicense.org/
// </copyright>

using System.Linq;

namespace System.Text.Rstring
{
    /// <summary>
    /// The bane of C# programmers everywhere, the boys at Microsoft
    /// forgot to include a simple string.Reverse() method.  Somehow,
    /// the Pythonistas of the world have beaten us to it!  Well, not anymore.
    /// </summary>
    public class Rstring
    {
        private string reversible;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rstring"/> class.
        /// </summary>
        /// <param name="strval">string that you want to reverse without spending 10 minutes Googling for arcane Linq queries.</param>
        public Rstring(string strval)
        {
            this.reversible = strval;
        }

        /// <summary>
        /// Reverses the original string.
        /// </summary>
        /// <returns>A reversed string (duh).</returns>
        public override string ToString()
        {
            // How much time in your life have you wasted on search engines just to come up with this
            // simple line of code?
            // Have you failed a job interview because you didn't know this simple trick?
            return new string(this.reversible.ToCharArray().Reverse<char>().ToArray());
        }
    }
}