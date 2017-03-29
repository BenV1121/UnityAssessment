using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;
    Rigidbody enemyRigidbody;
    MeshRenderer enemyMesh;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        enemyRigidbody = GetComponent<Rigidbody>();
        enemyMesh = GetComponent<MeshRenderer>();
    }


    void Update()
    {
        if (enemyHealth.healthValue > 0 && playerHealth.healthValue > 0)
        {
            nav.SetDestination(new Vector3(player.position.x - .5f, player.position.y, player.position.z - .5f));
        }
        else
        {
            nav.enabled = false;
        }
    }
}