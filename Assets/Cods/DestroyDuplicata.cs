using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDuplicata : MonoBehaviour
{
    private static DestroyDuplicata DestroyInstance;
    // Start is called before the first frame update

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (DestroyInstance == null)
        {
            DestroyInstance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
