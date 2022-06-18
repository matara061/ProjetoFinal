using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMenus : MonoBehaviour
{
    public bool Pause;

    // Start is called before the first frame update
    void Start()
    {
        Pause = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && Pause == false)
        {
            Pause=true;
            SceneManager.LoadScene("Menu", LoadSceneMode.Additive);
        }else 
            if(Input.GetKeyDown(KeyCode.Escape) && Pause == true)
        {
            Pause = false;
            SceneManager.UnloadScene("Menu");
        }

        if(Pause == false)
        {
            Time.timeScale = 1;
        }else
            Time.timeScale = 0;

    }
}
