using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gerador : MonoBehaviour
{
    public bool entrou; // verificar se entrou para evitar abrir a scene varias veses 
    public string SceneName; // colocar o nome de qualquer scene 

    // Start is called before the first frame update
    void Start()
    {
        entrou = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) // ao entrar no collider
    {
        if (collision.gameObject.CompareTag("Player") && !entrou)
        {
            Debug.Log("entrou");
            entrou = true;
            SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);
        }
    }

    private void OnTriggerExit(Collider collision) // ao sair do collider
    {
        if (collision.gameObject.CompareTag("Player") && entrou)
        {
            Debug.Log("saiu");
            entrou = false;
            SceneManager.UnloadSceneAsync(SceneName);
        }
    }
}
