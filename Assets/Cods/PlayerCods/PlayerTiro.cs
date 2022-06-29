using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTiro : MonoBehaviour
{
    //Para instanciar um pequeno efeito quando a condi��o de tiro � efetuada.
    public GameObject Efeito;

    //O tiro se encontra na personagem, mas o objeto que instancia o projetil, est� junto da cam�ra. Essa � a refer�ncia dele 
    public Transform ShootPointDrone1;
    public Transform Drone1;
    public Transform ShootPointDrone2;
    public Transform Drone2;

    Rigidbody rb;

    //Balas e Velocidade das balas.
    [SerializeField]
    public GameObject bala1;
    public GameObject bala2;
    public float speed = 30;

    //Tiro e CD do Tiro
    public float FireRate = 1;
    float nextTimeToFire = 1;

    //OBS: Tiro e bala s�o coisas diferentes. Quando digo tiro: � a fun��o de atirar. Quando digo bala: � o projetil lan�ado.


    Animator animator;

    void Start()
    {

    }
    void Update()
    {

        //Clique direito do mouse aciona o disparo do drone1
        if (Input.GetButtonDown("Fire2"))
        {
            //Tempo no qual vai lan�ar as balas
            nextTimeToFire = Time.time + FireRate;
            FindObjectOfType<AudioManager>().Play("Drone1"); // Som
            Rigidbody rb = Instantiate(bala1, ShootPointDrone1.position, ShootPointDrone1.rotation).GetComponent<Rigidbody>();



            //Adiciona for�a ao ponto do tiro, para instanciar as balas de maneira adequada
            rb.AddRelativeForce(new Vector3(1, 3, 32), ForceMode.Impulse);
        }

        //Clique esquerdo do mouse aciona o disparo do drone2
        if (Input.GetButtonDown("Fire1"))
        {
           
            nextTimeToFire = Time.time + FireRate;
            FindObjectOfType<AudioManager>().Play("Drone2"); 
            Rigidbody rb = Instantiate(bala2, ShootPointDrone2.position, ShootPointDrone2.rotation).GetComponent<Rigidbody>();

            

            rb.AddRelativeForce(new Vector3(1, 3, 32), ForceMode.Impulse);
        }

    }

}

