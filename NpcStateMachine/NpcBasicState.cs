using UnityEngine;
using npc;

public abstract class NpcBasicState0
{
    public status NPCplace;
    public Client client;
    public pedidos Pedidos;
    public Pathfinding.AIDestinationSetter Ai;
    public Animator anim;

    public abstract void EnterState(NpcManagerState npc);

    public abstract void UpdateState(NpcManagerState npc);

    public abstract void OnCollisionEnter(NpcManagerState npc);

}

