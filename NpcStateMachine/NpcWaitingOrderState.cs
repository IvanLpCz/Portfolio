using UnityEngine;
using npc;

public class NpcWaitingOrderState0 : NpcBasicState0
{
    private float timeRemaining;
    public override void EnterState(NpcManagerState npc)
    {
        NPCplace = GameObject.Find("Thomas Miller").GetComponent<status>();
        Pedidos = GameObject.Find("Thomas Miller").GetComponent<pedidos>();
        client = GameObject.Find("Manager NPCs").GetComponent<Client>();
        anim = GameObject.Find("Thomas Miller").GetComponentInChildren<Animator>();

        timeRemaining = Pedidos.tiempoDeEsperaSinAtender;
        Pedidos.esperaSerAtendido();
        anim.SetTrigger("sit");
        NPCplace.npcBC.enabled = true;
    }

    public override void UpdateState(NpcManagerState npc)
    {
        if (Pedidos.yaMeHanAtendido)
        {
            npc.SwitchState(npc.waitingDrinkState);
        }
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