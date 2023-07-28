using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    private GameObject[] musicObjects;

    public void Awake()
    {
        musicObjects = GameObject.FindGameObjectsWithTag("BGMusic");

        if (musicObjects.Length >= 2)
        {
            Destroy(musicObjects[1]);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
