using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetivoConcluido : MonoBehaviour
{
    GameObject Objetivos;

    void Start()
    {
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
            StartCoroutine(Desativar());
        }
    }

    IEnumerator Desativar()
    {
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(true);

        yield return new WaitForSeconds(3f);

        Debug.Log("Proximo objetivo");
        Objetivos.GetComponent<Objetivos>().concluido.SetActive(false);
        Objetivos.GetComponent<Objetivos>().Objetivo1.SetActive(false);
    }
}
