using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2Flag : MonoBehaviour
{
    public bool flagTouched = false;
    private float delay = .5f;
    private float timeElapsed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (flagTouched == true)
        {
            timeElapsed += Time.deltaTime;

                SceneManager.LoadScene(5);


        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        flagTouched = true;
    }
}
