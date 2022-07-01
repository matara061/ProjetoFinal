using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumir : MonoBehaviour
{
    // Start is called before the first frame update
     void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("mao1") || other.gameObject.CompareTag("mao2")) 
        {
            Debug.Log("encostou");
            Destroy(gameObject);
        }
    }
}
