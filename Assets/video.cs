using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class video : MonoBehaviour
{
    public GameObject viideo;

    public GameObject Intro;
    // Start is called before the first frame update
    void Start()
    {
        viideo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Ativar());

        if (Input.GetKeyDown(KeyCode.F))
        {
            viideo.SetActive(true);
            Intro.SetActive(false);

        }
    }

    IEnumerator Ativar()
    {
        yield return new WaitForSeconds(35f);

        viideo.SetActive(true);
    }
}
