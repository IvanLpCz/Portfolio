using UnityEngine;
using npc;


public class NpcGoAwayState0 : NpcBasicState0
{
    public override void EnterState(NpcManagerState npc)
    {
        Pedidos = GameObject.Find("Thomas Miller").GetComponentInChildren<pedidos>();
        Pedidos.seVaDisgustado();
    }
}