using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{
    public GameObject[] Waypoints;
    public Vector3 Getposition(int index)
    {
        return Waypoints[index].transform.position;
    }
    void Start()
    {

    }
    private void OnDrawGizmos()
    {
        if (Waypoints.Length > 0)
        {
            for (int i = 0; i < Waypoints.Length; i++)
            {
                if (i < Waypoints.Length - 1)
                {
                    Gizmos.color = Color.white;
                    Gizmos.DrawLine(Waypoints[i].transform.position, Waypoints[i + 1].transform.position);
                    //This all draws a line between the waypoints so the path is more visible
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
