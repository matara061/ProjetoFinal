using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionDam : MonoBehaviour
{
    public MinionMov minion;
    public int life = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            life--;
            Debug.Log("Dano");
        }
    }
}
