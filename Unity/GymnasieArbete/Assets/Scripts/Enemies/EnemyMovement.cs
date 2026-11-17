using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float MovementSpeed = 1f;
    [SerializeField] private EnemyPath movepath;
    [SerializeField] private EnemyHealth health;
    private Vector3 target;
    private int waypoint;

    private void Awake()
    {
        health = GetComponent<EnemyHealth>();
        movepath = GameObject.Find("Path").GetComponent<EnemyPath>(); //finds the path in the scene
    }
    private void OnEnable()
    {
        waypoint = 0;
        target = movepath.Getposition(waypoint); //finds position of the next waypoint
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, MovementSpeed * Time.deltaTime); //move toward the target at normalized speed
        float distance = (transform.position - target).magnitude;
        if (distance < 0.05f) //if the enemy is close enough to this waypoint, move the target to the next waypoint
        {
            if (waypoint < movepath.Waypoints.Length - 1) //if this is any other waypoint than the last, change it to the next one in the list
            {
                waypoint += 1;
                target = movepath.Getposition(waypoint);
            }
            else //if it is the last waypoint, destroy this gameobject and deal damage to the players healthpoints
            {
                Destroy(gameObject);
                //damage taken here
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Projectile"))
        {
            health.takedamage(1);
        }
    }
}
