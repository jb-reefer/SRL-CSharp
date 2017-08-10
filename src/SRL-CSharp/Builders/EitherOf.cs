using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Builders
{
    public class EitherOf : Builder
    {
		/// <summary>
		/// Desired match group
		/// </summary>
		protected string Group = "(?:{0})";

		/// <summary>
		/// String to implode with
		/// </summary>
		protected string ImplodeString = "|";
    }
}
