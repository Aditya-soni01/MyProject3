using MyProject3.Debugging;

namespace MyProject3
{
    public class MyProject3Consts
    {
        public const string LocalizationSourceName = "MyProject3";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a9f8552e63b046ecab3ad846f0e70ad6";
    }
}
