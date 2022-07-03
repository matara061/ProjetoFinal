using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
    // Start is called before the first frame update
{
    public int hp = 2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Tiro")

        {
            hp--;
            if (hp == 1)
            {
                FindObjectOfType<AudioManager>().Play("Explosao");
                Destroy(gameObject);
            }
        }
    }
}