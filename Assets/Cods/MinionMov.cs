using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinionMov : MonoBehaviour
{
    [Header("Referencias")]
    public NavMeshAgent agent;
    public Animator anim;
    [SerializeField]
    GameObject target;

    [Header("Areas")]
    public float AttackRadius = 10f;
    public float lookRadius = 30f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

       // agent.stoppingDistance = AttackRadius;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.transform.position, transform.position);// distancia entre IA e o player

        if (distance <= lookRadius) // distancia de perseguir 
        {
            FaceTarget();
            agent.SetDestination(target.transform.position);
            
        }
        else
            if (distance <= AttackRadius) // distancia de attack
        {
            anim.Play("Attack'1"); // anima��o attack, ativar box collider para dano
            FindObjectOfType<AudioManager>().Play("AttackMinion"); // Ativa o gatilho de som do audio manager.
            Debug.Log("Attack");
        }
    }

    void FaceTarget() // rotacionar para ficar de frente com o player
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    private void OnDrawGizmosSelected() // circulos ao redor da IA (apenas visual)
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, AttackRadius);

    }
}
