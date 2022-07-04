using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporte : MonoBehaviour
{
    public GameObject ponto;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    public ThirdPersonMovement personagem;
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
            StartCoroutine(CharacterControler());
            FindObjectOfType<AudioManager>().Play("Teleporte");
            Debug.Log("teleport");
            player.transform.position = ponto.transform.position;
           
        }
    }

    //Vai desativar o character controler para o teleporte conseguir mudar a posição do player. Logo dps, vai ativar
    IEnumerator CharacterControler()
    {
        personagem.charctrl.enabled = false;

        yield return new WaitForSeconds(1f);

        personagem.charctrl.enabled = true;

    }
}
