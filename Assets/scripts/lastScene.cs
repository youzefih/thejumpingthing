using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lastScene : MonoBehaviour
{
    private float delay = 5f;
    private float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delay)
        {
            SceneManager.LoadScene(0);
        }


    }
}