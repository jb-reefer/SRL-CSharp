using SRL.Extensions;

namespace SRL.Language.Helpers
{
    public class Literally
    {
		/// <summary>
		/// The literal string
		/// </summary>
		protected string @string;

        public Literally(string _string)
        {
            this.@string = _string.StripSlashes();
        }

        /// <summary>
        /// Get the string
        /// </summary>
        /// <returns>Literally string</returns>
        public string GetString()
        {
            return this.@string;
        }
    }
}
