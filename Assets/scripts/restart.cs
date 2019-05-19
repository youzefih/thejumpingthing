using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1"))
        {
            SceneManager.LoadScene(3);
        }
        if (Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
        if (Input.GetKey("2"))
        {
            SceneManager.LoadScene(5);
        }
    }
}
