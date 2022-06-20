using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetivoConcluido : MonoBehaviour
{
    GameObject Objetivos;
    public GameObject Efeito;

    void Start()
    {
        //Busca no inspector o objeto informado dentro das aspas
        Objetivos = GameObject.Find("Objetivos");
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Concluido");
            FindObjectOfType<AudioManager>().Play("Estalo");
            
            Instantiate(Efeito,transform.position,transform.rotation);
            StartCoroutine(Desativar());

        }
        
    }

    //Pausa o sistema por 3 segundos, e em seguida realiza a declaração abaixo dele.
    IEnumerator Desativar()
    {
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(true);

        yield return new WaitForSeconds(3f);

        Debug.Log("Proximo objetivo");
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo1.SetActive(false);
    }
}
