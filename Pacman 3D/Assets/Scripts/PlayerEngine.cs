using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PlayerEngine : MonoBehaviour
{
    NavMeshAgent agent;
    public float playerSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        MouseMovement();
        KeyboardMovement();
    }

    void MouseMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.destination = hit.point;
            }
        }
    }

    void KeyboardMovement()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            agent.SetDestination(transform.position + Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            agent.SetDestination(transform.position - Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            agent.SetDestination(transform.position - Vector3.right);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            agent.SetDestination(transform.position + Vector3.right);
        }
    }

}
