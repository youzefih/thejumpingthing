using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winningScene : MonoBehaviour
{
    

    private float delay = 3f;
    private float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKey)
        {
            if(Input.anyKey)  SceneManager.LoadScene(0);
        }




    }
}
