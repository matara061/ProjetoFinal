using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PontoCaixa : MonoBehaviour
{
    public bool entrou;
    // Start is called before the first frame update
    void Start()
    {
        entrou = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) // ao entrar no collider
    {
        if (collision.gameObject.CompareTag("Caixa") && !entrou)
        {
            Debug.Log("caixa");
            entrou = true;
            // fazer algo

        }
    }
}
