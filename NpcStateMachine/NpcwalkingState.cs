using UnityEngine;
using npc;

public class NpcwalkingState0 : NpcBasicState0
{
    public override void EnterState(NpcManagerState npc)
    {      
        client = GameObject.Find("Manager NPCs").GetComponent<Client>();
        Pedidos = GameObject.Find("Thomas Miller").GetComponent<pedidos>();
        NPCplace = GameObject.Find("Thomas Miller").GetComponent<status>();
    }

    public override void UpdateState(NpcManagerState npc)
    {
        Pedidos.walking();
        if (NPCplace.arrive)
        {
            npc.SwitchState(npc.waitingOrderState);
        }
        if (Pedidos.goAway)
        {
            npc.SwitchState(npc.goingAway);
        }
    }
}