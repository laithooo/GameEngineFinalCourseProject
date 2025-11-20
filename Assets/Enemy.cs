using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
   
    [SerializeField] private Animator animator;
    public Transform Target;
    private NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if (agent != null && Target != null)
        {
            animator.SetBool("isMoving", true);

            agent.destination = Target.transform.position;
           
 
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            animator.SetBool("isAttacking", true);

            
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }
}
