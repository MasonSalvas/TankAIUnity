using UnityEngine;
using System.Collections;
/// <summary>
///This will move the tanks to the waypoints
/// </summary>
public class MPmovement : MonoBehaviour
{
    public float speed = 2f;
    public Transform[] waypoints;
    
    
    private NavMeshAgent nav;
    private int waypointIndex;

    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        nav.speed = speed;
        if (nav.remainingDistance < nav.stoppingDistance)
        {
            if (waypointIndex == waypoints.Length - 1)
                waypointIndex = 0;
            else
                waypointIndex++;
        }

        else
            nav.destination = waypoints[waypointIndex].position;
    }


}