using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private PlayerMenus Pause;
    void Start()
    {
        Pause = FindObjectOfType<PlayerMenus>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume()
    {
        SceneManager.UnloadScene("Menu");
        Pause.Pause = false;
    }

    public void TelaInicial()
    {
       
        SceneManager.LoadScene("Tela inicial");
    }

    public void Iniciar()
    {
        FindObjectOfType<AudioManager>().Play("Iniciar"); // Carrega um som ao apertar o botão correspondente
        SceneManager.LoadScene("Dungeon Um");// carregar cena inicial
    }

    public void Creditos()
    {
        FindObjectOfType<AudioManager>().Play("Creditos");// som 
        SceneManager.LoadScene("Creditos");

    }

    public void Voltar()
    {
        // colocar na cena creditos
    }

    public void Sair()
    {
        FindObjectOfType<AudioManager>().Play("Exit");// som 
        Application.Quit();
    }
}
