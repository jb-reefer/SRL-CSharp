using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Builders
{
    public class Capture : Builder
    {
		/// <summary>
		/// Desired match group
		/// </summary>
		protected string Group = "({0})";

        /// <summary>
        /// Set name for capture group.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>The group name set</returns>
        public string SetName(string name)
        {
            return string.Format(Group, name);
        }
    }
}
