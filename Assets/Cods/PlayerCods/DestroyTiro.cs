using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTiro : MonoBehaviour
{
    public GameObject Efeito;
    void Start()
    {

    }

    void Update()
    {
        // A bala se auto destroi depois de 3 segundos, caso não encontre algum collisor.
        Destroy(gameObject, 3f);
    }

    //A bala vai se destruir sempre que encostar em algum collider. Umn efeito instancia no ponto onde houve a colisão.
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "IA")
        // {
        Instantiate(Efeito, transform.position, transform.rotation);
        Destroy(gameObject);
        // }
    }
}
