using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDano : MonoBehaviour
{
    [Header("Condições")]
    public int life = 10;
    public int currentLife = 10;
    public bool morte;
    public bool dam;

    [Header("Referencias")]
    public ThirdPersonMovement player;
    [SerializeField]
    private Slider slide;

    
    // Start is called before the first frame update
    void Start()
    {
        slide = FindObjectOfType<Slider>();
        currentLife = life;
        dam = false;
    }

    // Update is called once per frame
    void Update()
    {
        // if(currentLife <= 0)
        // {
        //     Destroy(gameObject, 2);
        //     SceneManager.LoadScene("Tela de morte");
        // }
        if(dam)
        {
            currentLife--;
            SetLife(currentLife);
            player.Damage();
            dam = false;
            Debug.Log("Dano");
        }
    }

   // private void OnCollisionEnter(Collision collision)
   // {
   //     if (collision.gameObject.CompareTag("Minion") || collision.gameObject.CompareTag("Boss")) // verifica se esta em contato com inimigo
   //     {
   //         currentLife--;
   //         SetLife(currentLife);
   //         player.Damage();
   //         Debug.Log("Dano");
   //     }
   // }

    public void SetMaxLife(int life)
    {
        slide.maxValue = life;
        slide.value = life;
    }

    public void SetLife(int life)
    {
        slide.value = life;
    }
}
