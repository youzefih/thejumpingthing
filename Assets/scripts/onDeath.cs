using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class onDeath : MonoBehaviour
{

    public bool Death = false;
    private float delay = .75f;
    private float timeElapsed;
   // public AudioSource song;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Death == true)
        {
            //song.Play();
            timeElapsed += Time.deltaTime;
            //if (timeElapsed > delay) {

                SceneManager.LoadScene(1);
            //}



        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Death = true;
    }
}
