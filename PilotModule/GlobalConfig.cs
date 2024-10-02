using Ascon.Pilot.SDK;
using System;

namespace PilotModule
{
    public class GlobalConfig
    {
        public const string TEST_MENU_ITEM_NAME = "testMenuItemName";
        public const string TEST_MENU_ITEM_CAPTION = "TEST_MENU_ITEM";

        

        public static bool IsSdkVersionEqualOrGreater(string strver)
        {
            Version sdkCurrentVersion = typeof(IObjectsRepository).Assembly.GetName().Version;

            var ver = Version.Parse(strver);

            var res = sdkCurrentVersion.CompareTo(ver);

            if (res < 0)
            {
                return false;
            }

            return true;
        }
    }
}