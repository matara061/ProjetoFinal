using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontoCaixa : MonoBehaviour
{
    //public GameObject Efeito; // Instanciar efeito ao ser destruido
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) 
    {
        if (collision.gameObject.CompareTag("Caixa")) //  ponto de pressão vai ser destruido ao entrar em contato com a caixa
                                                    // Dessa forma, o bloqueio existente na hierarquia tbm é destruido
        {
            Debug.Log("Destruido");
            Destroy(gameObject);
            //FindObjectOfType<AudioManager>().Play("MinionDead"); //Vou inserir som de explosão
            //Instantiate(Efeito, tranform.position, transform.rotantion); // instanciar efeito
        }
    }
}
