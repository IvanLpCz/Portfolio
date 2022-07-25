using UnityEngine;
using npc;

public class NpcWaitingDrinkState0 : NpcBasicState0
{
    private float timeRemaining;
    public override void EnterState(NpcManagerState npc)
    {
        Pedidos = GameObject.Find("Thomas Miller").GetComponent<pedidos>();
        timeRemaining = Pedidos.tiempoDeEsperaAtendido;
        Pedidos.esperaPedido();
    }

    public override void UpdateState(NpcManagerState npc)
    {
        if (Pedidos.goAway)
        {
            npc.SwitchState(npc.goingAway);
        }
        timeRemaining -= Time.deltaTime;
        if (timeRemaining <= 0)
        {
            Pedidos.seVaDisgustado();
        }
    }
}
