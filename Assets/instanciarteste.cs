using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciarteste : MonoBehaviour
{
    public GameObject cubo;
    public Transform lugar;
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
        Instantiate(cubo, lugar.position, Quaternion.identity);
    }
}
