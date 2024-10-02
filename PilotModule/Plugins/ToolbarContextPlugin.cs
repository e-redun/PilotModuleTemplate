using System.ComponentModel.Composition;
using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.Toolbar;
using PilotModule.MenuBuilders;

namespace XPStoPDF
{
    [Export(typeof(IToolbar<ObjectsViewContext>))]
    public class ToolbarContextPlugin : IToolbar<ObjectsViewContext>
    {
        private ICommonMenuBuilder _commonMenuBuilder;

        [ImportingConstructor]
        public ToolbarContextPlugin()
        {
            _commonMenuBuilder = new CommonMenuBuilder();
        }

        void IToolbar<ObjectsViewContext>.Build(IToolbarBuilder builder, ObjectsViewContext context)
        {
            _commonMenuBuilder.Build(builder, context);
        }

        void IToolbar<ObjectsViewContext>.OnToolbarItemClick(string name, ObjectsViewContext context)
        {
            _commonMenuBuilder.OnItemClick(name, context);
        }
    }
}