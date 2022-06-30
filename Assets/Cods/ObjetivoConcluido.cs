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

        if(other.gameObject.tag == "Caixa")
        {
            Debug.Log("Concluido");
            FindObjectOfType<AudioManager>().Play("Estalo");
            
            Instantiate(Efeito,transform.position,transform.rotation);
            StartCoroutine(Desativar());
            Objetivos.GetComponent<Objetivos>().Objetivo2.SetActive(false);
            Objetivos.GetComponent<Objetivos>().concluido.SetActive(false);
            Objetivos.GetComponent<Objetivos>().Objetivo3.SetActive(true);

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
        Objetivos.GetComponent<Objetivos>().Objetivo2.SetActive(true);
    }
    IEnumerator Desativar2()
    {
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(true);

        yield return new WaitForSeconds(1f);

        Debug.Log("Proximo objetivo");
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo2.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo3.SetActive(true);
    }
        IEnumerator Desativar3()
    {
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(true);

        yield return new WaitForSeconds(3f);

        Debug.Log("Proximo objetivo");
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo3.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo4.SetActive(true);
    }
            IEnumerator Desativar4()
    {
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(true);

        yield return new WaitForSeconds(3f);

        Debug.Log("Proximo objetivo");
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo4.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo5.SetActive(true);
    }
                IEnumerator Desativar5()
    {
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(true);

        yield return new WaitForSeconds(3f);

        Debug.Log("Proximo objetivo");
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo5.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo6.SetActive(true);
    }
              IEnumerator Desativar6()
    {
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(true);

        yield return new WaitForSeconds(3f);

        Debug.Log("Proximo objetivo");
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo6.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo7.SetActive(true);
    }
             IEnumerator Desativar7()
    {
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(true);

        yield return new WaitForSeconds(3f);

        Debug.Log("Proximo objetivo");
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo7.SetActive(false);
        
    }
    
    
}
