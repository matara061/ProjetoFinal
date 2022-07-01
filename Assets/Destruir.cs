using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour
{
    [SerializeField]
    private PlayerDano dano;
    public Mao2movi mao2;
    public Mao1movi mao1;
    // Start is called before the first frame update
    void Start()
    {
        dano = FindObjectOfType<PlayerDano>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bomba"))
        {
            mao2.morrer = 1;
            mao1.morrer = 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bomba"))
        {
            mao2.morrer = 1;
            mao1.morrer = 1;
        }
        if (other.CompareTag("Player")) 
        {
            dano.dam = true;
            Debug.Log("deu dano");
        }
    }
}
