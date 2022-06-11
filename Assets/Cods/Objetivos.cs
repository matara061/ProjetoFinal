using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivos : MonoBehaviour
{
    public GameObject Objetivo1;
    public GameObject concluido;
    
    void Start()
    {
        concluido.SetActive(false);
        Objetivo1.SetActive(true);
    }

    void Update()
    {
        
    }
}
