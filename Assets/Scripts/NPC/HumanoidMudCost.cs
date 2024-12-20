using UnityEngine;
using UnityEngine.AI;

public class HumanoidMudCost : MonoBehaviour
{
    const int MegaMudIndex = 4;

    [SerializeField] GameObject humanoidNpc;

    void Start()
    {
        NavMeshAgent navMeshAgent = humanoidNpc.GetComponent<NavMeshAgent>();
        navMeshAgent.SetAreaCost(MegaMudIndex, 6.0f); 
    }
}
