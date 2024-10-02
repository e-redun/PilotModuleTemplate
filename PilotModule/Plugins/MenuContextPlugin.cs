using System.ComponentModel.Composition;
using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.Menu;
using PilotModule.MenuBuilders;

namespace XPStoPDF
{
    [Export(typeof(IMenu<ObjectsViewContext>))]
    public class MenuContextPlugin : IMenu<ObjectsViewContext>
    {
        private ICommonMenuBuilder _commonMenuBuilder;

        [ImportingConstructor]
        public MenuContextPlugin()
        {
            _commonMenuBuilder = new CommonMenuBuilder();
        }


        void IMenu<ObjectsViewContext>.Build(IMenuBuilder builder, ObjectsViewContext context)
        {
            _commonMenuBuilder.Build(builder, context);
        }

        void IMenu<ObjectsViewContext>.OnMenuItemClick(string name, ObjectsViewContext context)
        {
            _commonMenuBuilder.OnItemClick(name, context);
        }
    }
}