using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NascerPilar : MonoBehaviour
{
    public GameObject pilar;
    public Transform nascerPilar;
    public Behaviour rotacionar;
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
            Debug.Log("encostou");
            Instantiate(pilar, nascerPilar.position, Quaternion.identity);
            rotacionar.enabled = false;
        }
    }
}
