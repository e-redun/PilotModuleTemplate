using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.Menu;
using Ascon.Pilot.SDK.Toolbar;
using PilotModule.Logiсs;

namespace PilotModule.MenuBuilders
{
    public class CommonMenuBuilder : ICommonMenuBuilder
    {
        private IPilotModuleLogic _moduleLogic;
        public CommonMenuBuilder()
        {
            _moduleLogic = new PilotModuleLogic();
        }

        public void Build(IToolbarBuilder builder, ObjectsViewContext context)
        {
            builder.AddSeparator(builder.Count);

            builder.AddButtonItem(GlobalConfig.TEST_MENU_ITEM_NAME, builder.Count)
                    .WithHeader(GlobalConfig.TEST_MENU_ITEM_CAPTION)
                    ;
        }

        public void Build(IMenuBuilder builder, ObjectsViewContext context)
        {
            builder.AddSeparator(builder.Count);

            builder.AddItem(GlobalConfig.TEST_MENU_ITEM_NAME, builder.Count)
                    .WithHeader(GlobalConfig.TEST_MENU_ITEM_CAPTION)
                    ;
        }

        public void OnItemClick(string name, ObjectsViewContext context = null)
        {
            if (name == GlobalConfig.TEST_MENU_ITEM_NAME)
            {
                _moduleLogic.ProcessObjects(context.SelectedObjects);
            }
        }
    }
}