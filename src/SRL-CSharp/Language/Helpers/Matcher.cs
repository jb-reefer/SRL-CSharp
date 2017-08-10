using SRL.Interfaces;

namespace SRL.Language.Helpers
{
    public class Matcher
    {
        static Matcher instance;

        Matcher() { }

        /// <summary>
        /// Get matcher instance. Since this matcher contains static functionality, we'll use a singleton.
        /// </summary>
        public static Matcher GetInstance => instance ?? (instance = new Matcher());

        public Method Match(string part)
        {
            return null;
        }
    }
}