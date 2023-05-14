using System.Collections;
using UnityEngine;

// Declare an enum to represent the enemy's different states
public enum ENEMY_STATE { IDLE, PATROL, CHASE }

public class BasicEnemyAI : MonoBehaviour
{
    // Declare a variable to store the current state of the enemy
    public ENEMY_STATE currentState;
    public Transform target;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        // Set the enemy's initial state to Idle
        currentState = ENEMY_STATE.CHASE;
        
    }


    // Update is called once per frame
    void Update()
    {
        // Use a switch statement to perform different actions based on the current state
        switch (currentState)
        {
            case ENEMY_STATE.IDLE:
                // TODO: Implement behavior for the Idle state
                break;
            case ENEMY_STATE.PATROL:
                // TODO: Implement behavior for the Patrol state
                break;
            case ENEMY_STATE.CHASE:
                ChaseState();
                // TODO: Implement behavior for the Chase state
                break;
            default:
                break;
        }
    }

    // TODO: Implement behavior for the Idle state
    void IdleState()
    {
        // In the Idle state, the enemy does nothing
    }

    // TODO: Implement behavior for the Patrol state
    void PatrolState()
    {
        // In the Patrol state, the enemy moves between specified waypoints

    }

    // TODO: Implement behavior for the Chase state
    void ChaseState()
    {
        // In the Chase state, the enemy pursues a target
        // Calculate direction from current position to target position
        Vector3 direction = (target.position - transform.position).normalized;

        // Move towards target
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }   
       
}