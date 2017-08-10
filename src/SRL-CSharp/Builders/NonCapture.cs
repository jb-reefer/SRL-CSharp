using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRL.Builders
{
    public class NonCapture : Builder
    {
		/// <summary>
		/// Desired non-capture group
		/// </summary>
		protected string Group = "(?:{0})";
    }
}
