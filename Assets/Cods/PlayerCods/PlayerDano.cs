using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDano : MonoBehaviour
{

    public int life = 10;
    public bool morte;
    public ThirdPersonMovement player;

    public GameObject lifeBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(life <= 0)
        {
            Destroy(gameObject, 2);
            SceneManager.LoadScene("Tela de morte");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Minion") || collision.gameObject.CompareTag("Boss"))
        {
            life--;
            player.Damage();
            Debug.Log("Dano");
        }
    }
}
