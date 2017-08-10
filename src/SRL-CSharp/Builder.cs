using SRL.Interfaces;
using System;
using System.Collections.Generic;

namespace SRL
{
    public class Builder : TestMethodProvider
    {
        protected const string NON_LITERAL_CHARACTERS = "[\\^$.|?*+()";

        protected const MethodType METHOD_TYPES_ALLOWED_FOR_CHARACTERS = MethodType.Begin | MethodType.Anchor | MethodType.Group | MethodType.Quantifier | MethodType.Character;

		/// <summary>
		/// RegEx being built
		/// </summary>
		protected List<string> regEx = new List<string>();

		/// <summary>
		/// Raw modifiers to apply on get()
		/// </summary>
		protected string modifiers = "";

		/// <summary>
		/// Type of last method, to avoid invalid builds.
		/// </summary>
		protected MethodType lastMethodType = MethodType.Begin;

        protected Dictionary<string, string> modifierMapper = new Dictionary<string, string>
        {
            { "all", "g" },
            { "multiLine", "m" },
            { "singleLine", "s" },
            { "caseInsensitive", "i" },
            { "unicode", "u" },
            { "allLazy", "U" }
        };

        [Flags]
        protected enum MethodType
        {
            // Replace with binary literals if we use C# 7.0 in the future
            Begin = 1,       //0b00001
            Character = 2,   //0b00010
            Group = 4,       //0b00100
            Quantifier = 8,  //0b01000
            Anchor = 16,     //0b10000
            Unknown = 31     //0b11111
        }

        public override string Get(string delimiter = "/", bool ignoreInvalid = false)
        {
            throw new NotImplementedException();
        }
    }
}
