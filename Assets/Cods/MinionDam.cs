using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionDam : MonoBehaviour
{
    [Header("Referencias")]
    public GameObject LifeBar;
    public MinionMov minion;

    [Header("Condi�oes")]
    public int life = 10;
    public int currentLife = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LifeBar.transform.localScale = new Vector3(currentLife, 1, 1);// barra de vida

        if(currentLife <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            currentLife--;
            Debug.Log("Dano");
        }
    }
}
