using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mao2movi : MonoBehaviour
{
    NavMeshAgent agent;
    Animator anima;
    public Transform player;
    public Transform proteger;
    public Mao1movi mao1;
    public int trocar1;
    public int morrer;
    [SerializeField]
    private PlayerDano dano;

    GameObject Objetivos;
    // Start is called before the first frame update
    void Start()
    {
        dano = FindObjectOfType<PlayerDano>();
        agent = GetComponent<NavMeshAgent>();
        anima = GetComponent<Animator>();
        trocar1 = 0;
        agent.speed = 7;
        morrer = 0;
         Objetivos = GameObject.Find("Objetivos");

    }

    // Update is called once per frame
    void Update()
    {
        if (trocar1 == 0)
        {
            agent.SetDestination(player.position);
            anima.SetBool("Proteger", false);
            anima.SetBool("Ir", true);
        }
        if (morrer == 1)
        {
            anima.Play("Armature|ArmatureAction 4");
            Destroy(gameObject,2.5f);

            // COMPLETA OBJETIVO
            Objetivos.GetComponent<Objetivos>().Objetivo3.SetActive(false);
            Objetivos.GetComponent<Objetivos>().concluido.SetActive(false);
            Objetivos.GetComponent<Objetivos>().Objetivo4.SetActive(true);

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
    //        anima.Play("Armature|ArmatureAction G4");
    //        Destroy(gameObject);
    //        mao1.berserk = 1;
    //    }
    //}
    IEnumerator wait() 
    {
        yield return new WaitForSeconds(5f);
        Trocar();
    }
    public void Trocar()
    {
        trocar1 = 1;
        anima.SetBool("Ir", false);
        anima.SetBool("Atacar", false);
        anima.SetBool("Proteger", true);
        agent.SetDestination(proteger.position);
        agent.speed = 7;
        mao1.trocar2 = 0;
        dano.dam = false;
        Debug.Log("nda dano");
    }
}
