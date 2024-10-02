using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.Menu;
using Ascon.Pilot.SDK.Toolbar;

namespace PilotModule.MenuBuilders
{
    public interface ICommonMenuBuilder
    {
        void Build(IToolbarBuilder builder, ObjectsViewContext context);
        void Build(IMenuBuilder builder, ObjectsViewContext context);
        void OnItemClick(string name, ObjectsViewContext context);
    }
}