using Klyte.VehicleColorExpander;
using Klyte.VehicleColorExpander.Utils;

namespace Klyte.Commons
{
    public static class CommonProperties
    {
        public static bool DebugMode => VehicleColorExpanderMod.DebugMode;
        public static string Version => VehicleColorExpanderMod.Version;
        public static string ModName => VehicleColorExpanderMod.Instance.SimpleName;
        public static string Acronym => "VCE";
        public static string ResourceBasePath => VCEResourceLoader.instance.Prefix;
    }
}