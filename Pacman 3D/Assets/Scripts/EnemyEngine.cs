using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyEngine : MonoBehaviour
{
    public Transform player;
    NavMeshAgent enemyAgent;
    public float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
        enemyAgent.speed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        enemyAgent.destination = player.position;
    }
}
