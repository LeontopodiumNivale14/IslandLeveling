using Dalamud.Game.ClientState.Conditions;
using ECommons.Throttlers;
using FFXIVClientStructs.FFXIV.Client.Game;
using FFXIVClientStructs.FFXIV.Client.Game.Control;
using FFXIVClientStructs.FFXIV.Client.Game.Object;
using FFXIVClientStructs.FFXIV.Client.UI.Agent;

namespace IslandLeveling.Scheduler.Handers;

internal static unsafe class PlayerHandlers
{
    // this needs to be refined... maybe?
    internal static bool? InteractObject(uint dataID)
    {
        uint npc_ID = dataID;
        if (Service.ObjectTable.TryGetFirst(e => e.DataId == dataID, out var obj))
        {
            if (TargetSystem.Instance()->Target == (GameObject*)obj.Address)
            {
                TargetSystem.Instance()->InteractWithObject((GameObject*)obj.Address);
                return true;
            }
            if (EzThrottler.Throttle($"Interact + {npc_ID}", 100))
            {
                TargetSystem.Instance()->Target = (GameObject*)obj.Address;
                return false;
            }
        }
        return false;
    }

    public static float Distance(this Vector3 v, Vector3 v2)
    {
        return new Vector2(v.X - v2.X, v.Z - v2.Z).Length();
    }
    public static unsafe bool IsMoving()
    {
        return AgentMap.Instance()->IsPlayerMoving == 1;
    }
}
