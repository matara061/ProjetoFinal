using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMorrer : MonoBehaviour
{
    public Animator anima;
    // Start is called before the first frame update
    public void Morrer()
    {
        Destroy(gameObject, 3f);
        anima.Play("Cube|CubeAction");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
