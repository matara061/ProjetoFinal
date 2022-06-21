using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporte : MonoBehaviour
{
    public GameObject ponto;
    [SerializeField]
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) // ao entrar no collider
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("teleport");
            player.transform.position = ponto.transform.position;
           
        }
    }
}
