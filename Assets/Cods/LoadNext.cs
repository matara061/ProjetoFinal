using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour
{
    public string SceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) // ao entrar no collider
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Portal");
            SceneManager.LoadScene(SceneName);
        }
    }
}
