using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Builders
{
    public class NegativeLookbehind : Builder
    {
		/// <summary>
		/// Desired lookbehind group
		/// </summary>
		protected string Group = "(?<!{0})";
    }
}
