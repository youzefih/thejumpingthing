using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float movementIncrement = .5f;
    public float jumpIncrement = .5f;
    public AudioSource song; 
    public bool canJump = false;


    



    void Start()
    {
       // song = GameObject.FindObjectOfType<AudioSource>();
        rigid = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.root.position += Vector3.right * movementIncrement;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.root.position += Vector3.left * movementIncrement;
        }

        if (Input.GetKey(KeyCode.Space) && (canJump ==true))
        {
            song.Play();
                transform.root.position += Vector3.up * jumpIncrement;
            canJump = false;
        }

        
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
       
            canJump = true;
      

    }


}
