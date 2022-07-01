using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBomba : MonoBehaviour
{
    public Transform TBoss;
    public Transform Lufraqueza;
    public GameObject fraqueza;
    public sumir sumirBomba;
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
        if (other.gameObject.CompareTag("Bomba")) 
        {
            //sumirBomba.Destruir();
            TBoss.Rotate(0f, 0f, 25f);
            Instantiate(fraqueza, Lufraqueza.position, Lufraqueza.rotation);
        }
    }
}
