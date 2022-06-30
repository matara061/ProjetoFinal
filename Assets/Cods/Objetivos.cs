using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivos : MonoBehaviour
{
    public GameObject Objetivo1;
    public GameObject Objetivo2;
    public GameObject Objetivo3;
    public GameObject Objetivo4;
    public GameObject Objetivo5;
    public GameObject Objetivo6;
    public GameObject Objetivo7;

    public GameObject concluido;
    
    void Start()
    {
        concluido.SetActive(false);
        Objetivo1.SetActive(true);
        Objetivo2.SetActive(false);
        Objetivo3.SetActive(false);
        Objetivo4.SetActive(false);
        Objetivo5.SetActive(false);
        Objetivo6.SetActive(false);
        Objetivo7.SetActive(false);
        

    }

    void Update()
    {
        
    }
}
