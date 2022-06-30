using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mao1movi : MonoBehaviour
{
    // Start is called before the first frame update
    NavMeshAgent agent;
    Animator anima;
    public Transform player;
    public Transform proteger;
    public Mao2movi mao2;
    public int trocar2;
    public int berserk;
    public int morrer;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anima = GetComponent<Animator>();
        trocar2 = 1;
        agent.speed = 7;
        morrer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (trocar2 == 0)
        {
            agent.SetDestination(player.position);
            anima.SetBool("Proteger", false);
            anima.SetBool("Ir", true);
        }
        if (morrer == 1)
        {
            anima.Play("Armature|ArmatureAction G3");
            Destroy(gameObject, 2.5f);
            mao2.berserk = 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anima.SetBool("Atacar", true);
            agent.speed = 0;
            StartCoroutine(wait());
        }
    }
    //private void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.CompareTag("Bomba"))
    //    {
    //        anima.Play("Armature|ArmatureAction G3");
    //        Destroy(gameObject);
    //        mao2.berserk = 1;
    //    }
    //}

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5f);
        Trocar();
    }
    public void Trocar() 
    {
        trocar2 = 1;
        anima.SetBool("Ir", false);
        anima.SetBool("Atacar", false);
        anima.SetBool("Proteger", true);
        agent.SetDestination(proteger.position);
        agent.speed = 7;
        mao2.trocar1 = 0;
    }
}
