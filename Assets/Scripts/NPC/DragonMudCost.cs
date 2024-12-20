using UnityEngine;
using UnityEngine.AI;

public class DragonMudCost : MonoBehaviour
{
    const int MegaMudIndex = 4;

    [SerializeField] GameObject dragonNpc;

    void Start()
    {
        NavMeshAgent navMeshAgent = dragonNpc.GetComponent<NavMeshAgent>();
        navMeshAgent.SetAreaCost(MegaMudIndex, 3.0f);
    }
}
