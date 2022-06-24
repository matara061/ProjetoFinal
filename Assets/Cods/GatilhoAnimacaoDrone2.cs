using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatilhoAnimacaoDrone2 : MonoBehaviour
{
    public Animator anim;

    void Start()
    {

    }

    void Update()
    {
        // Ativa a animação do drone2 ao atirar
        if (Input.GetButtonDown("Fire1"))
        {
            anim.Play("Armação|Shoot");

        }
    }
}
