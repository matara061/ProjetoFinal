using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KaduIA : MonoBehaviour
{

    public NavMeshAgent agent;
    public Animator anim;

    //Pontos no qual a IA vai ficar andando de um lado para outro
    //public GameObject PontoA;
   // public GameObject PontoB;

    //Detectar e virar para o player
    GameObject Target;
    public float lookRadius = 30f;
    void Start()
    {
        Target = GameObject.FindWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        
        //agent.isStopped = false;

    }

    void Update()
    {


        float distance = Vector3.Distance(Target.transform.position, transform.position);
        
        //Caso detecte o player, vai virar para ele e engatilhar a animação juntamente com o som. 
        if (distance <= lookRadius)
        {
            
            agent.isStopped = true;
            FaceTarget();
            //anim.SetBool("Acao",true);
            //anim.SetBool("Idle",false);

            //anim.Play("Armature|Acao");
            StartCoroutine(acao());
            
        }

        if (distance >= lookRadius)
        {
            
           // agent.isStopped = false;
            anim.Play("Armature|Idle");

            FindObjectOfType<AudioManager>().Play("KaduInteracao");
        }

        //FindObjectOfType<AudioManager>().Stop("KaduInteracao");

        // Loop para a IA ficar andando de uma lado para outro
        StartCoroutine(Loop());

    }

    void FaceTarget()
    {

        Vector3 direction = (Target.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    IEnumerator Loop()
    {
        //anim.Play("Armature|Andar");
        //agent.SetDestination(PontoA.transform.position);

    // para a IA ficar parada em um ponto por 10 segundos e dps vai para outro.
        yield return new WaitForSeconds(10f);

        //agent.isStopped = false;
        //agent.SetDestination(PontoB.transform.position);

        yield return new WaitForSeconds(20f);

        //agent.SetDestination(PontoA.transform.position);
    }

    IEnumerator acao()
    {
        anim.Play("Armature|Acao");

        yield return new WaitForSeconds(5f);

        anim.Play("Armature|Idle");

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
        
        anim.SetBool("Idle",true);
        anim.SetBool("Acao",false);
        }
        
    }


    private void OnDrawGizmosSelected() 
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
       
    }
    
}
