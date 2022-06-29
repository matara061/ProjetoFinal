using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatilhoAnimacaoDrone1 : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Ativa a animação do drone1 ao atirar
        if (Input.GetButtonDown("Fire2"))
        {
                anim.Play("Armacao|Shoot");

        }
    }
}
