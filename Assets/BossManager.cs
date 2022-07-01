using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    //Organizar a bossfight
    public Behaviour rotacionar;
    public Transform nascerbomba;
    public GameObject bomba;
    public int BossHealth;
    public Transform TBoss;
    public NascerPilar pilar1;
    public NascerPilar2 pilar2;
    //public int danoAoBoss;
    //public int danoAoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        //danoAoPlayer = 0;
        //danoAoBoss = 0;
        BossHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void DanoAoBoss()//pra quando o golpe n acertar o player fazendo a bomba cair
    {
        Debug.Log("chamou");
        Instantiate(bomba, nascerbomba.position, nascerbomba.rotation);
    }
    public void BossVolta() 
    {
        rotacionar.enabled = true;
        TBoss.Rotate(0f,0f,-25f);
        pilar1.Collider.enabled = true;
        pilar2.Collider.enabled = true;

    }
    public void DanoAoPlayer() //pra quando o golpe acertar o layer
    {
            rotacionar.enabled = true;//ele volta a girar
    }
    public void Fraqueza() 
    {
        BossHealth--;
    }
    void Morrer() 
    {
        if (BossHealth == 0)
        {
            Debug.Log("morreu");
        }
    }
}
