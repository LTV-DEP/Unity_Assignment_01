using UnityEngine;
using UnityEngine.AI;

public class AreaMask : MonoBehaviour
{
    public NavMeshAgent agent1;
    public NavMeshAgent agent2;
    void Start()
    {
        int green = NavMesh.GetAreaFromName("Green");
        int red = NavMesh.GetAreaFromName("Red");
        
        agent1.SetAreaCost(green, 1);
        agent1.SetAreaCost(red, 10);
        agent2.SetAreaCost(green, 10);
        agent2.SetAreaCost(red, 1);
    }
    
}
