using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativar : MonoBehaviour
{
    public Behaviour mao1;
    public Behaviour mao2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            mao1.enabled = true;
            mao2.enabled = true;
        }
    }
}
