using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    [SerializeField] int enemyHealth = 3;

    [Header("EnemyFollow")]
    GameObject Player;
    NavMeshAgent navMeshAgent;

    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        navMeshAgent.destination = Player.transform.position;
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public void EnemyDamage(int DamageAmount)
    {
        if (DamageAmount < enemyHealth)
        { 
            enemyHealth -= DamageAmount;
        }
        else
        { 
            Die();
        }
    }


}
