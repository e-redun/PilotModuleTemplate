using Ascon.Pilot.SDK.Toolbar;

namespace PilotModule.MenuBuilders
{
    internal class SubmenuBuilder : IToolbarItemSubmenuHandler
    {
        public void OnSubmenuRequested(IToolbarBuilder builder)
        {
            builder.AddSeparator(builder.Count);
            builder.AddButtonItem(GlobalConfig.TEST_MENU_ITEM_NAME, builder.Count).WithHeader(GlobalConfig.TEST_MENU_ITEM_CAPTION);
        }
    }
}