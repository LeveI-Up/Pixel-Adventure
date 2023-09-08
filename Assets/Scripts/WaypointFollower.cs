using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWayPointsIndex = 0;

    [SerializeField] float speed = 2f;

    void Update()
    {
        if (Vector2.Distance(waypoints[currentWayPointsIndex].transform.position, transform.position) < .1f)
        {
            currentWayPointsIndex++;
            if(currentWayPointsIndex >= waypoints.Length) { currentWayPointsIndex = 0; }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWayPointsIndex].transform.position,Time.deltaTime*speed);
    }
}
