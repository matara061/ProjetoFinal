using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoArma : MonoBehaviour
{
    [SerializeField]
    private PlayerDano dano;
    [SerializeField]
    private BossManager boss;
    public Behaviour rotacionar;
    // Start is called before the first frame update
    void Start()
    {
        dano = FindObjectOfType<PlayerDano>();
        boss = FindObjectOfType<BossManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("chao"))//caso n acerte a o player e so desaparece
        {
            Destroy(gameObject, 3f);
            boss.DanoAoBoss();
        }
        if (other.CompareTag("Player")) // caso acerte da dano e chama a funcao
        {
            boss.DanoAoPlayer();
            dano.dam = true;
            Destroy(gameObject);
        }
    }
}
