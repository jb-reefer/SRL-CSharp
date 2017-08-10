using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Builders
{
    public class NegativeLookahead : Builder
    {
		/// <summary>
		/// Desired lookahead group
		/// </summary>
		protected string Group = "(?!{0})";
    }
}
