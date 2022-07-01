using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NascerPilar2 : MonoBehaviour
{
    public Collider Collider;
    public GameObject pilar;
    public Transform nascerPilar;
    public Behaviour rotacionar;
    // Start is called before the first frame update
    void Start()
    {
        Collider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           Collider.enabled = false;
            Debug.Log("encostou");
            Instantiate(pilar, nascerPilar.position, nascerPilar.rotation);
            rotacionar.enabled = false;
        }
    }
}
