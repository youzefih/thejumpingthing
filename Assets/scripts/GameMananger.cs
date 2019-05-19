using UnityEngine;
using System.Collections;
public  class GameMananger
{

    public static GameMananger instance = null;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {

    }
}