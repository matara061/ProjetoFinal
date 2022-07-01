using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fraqueazHit : MonoBehaviour
{
    [SerializeField]
    private BossManager boss;
    // Start is called before the first frame update
    void Start()
    {
        boss = FindObjectOfType<BossManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        boss.Fraqueza();
        boss.BossVolta();
        Destroy(gameObject);
        Debug.Log("destruiu");

    }
}
