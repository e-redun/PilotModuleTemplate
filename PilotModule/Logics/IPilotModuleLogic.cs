using Ascon.Pilot.SDK;
using System.Collections.Generic;

namespace PilotModule.Logiсs
{
    public interface IPilotModuleLogic
    {
        void ProcessObjects(IEnumerable<IDataObject> selectedObjects);
    }
}