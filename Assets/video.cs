using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class video : MonoBehaviour
{
    public GameObject viideo;
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

        }
    }

    IEnumerator Ativar()
    {
        yield return new WaitForSeconds(37f);

        viideo.SetActive(true);
    }
}
