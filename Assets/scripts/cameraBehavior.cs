using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBehavior : MonoBehaviour
{
    public GameObject player;
    public Transform targetTransform;
    Vector3 tempVec3 = new Vector3();
    
    void Start()
    {
       
    }


    void LateUpdate()
    {
        float two = 2.25F;
        float playerHeightMax = player.transform.position.y - two;
        float playerHeightMin = player.transform.position.y + two;

        float cameraHeight = transform.position.y;

        if (playerHeightMax > cameraHeight || playerHeightMin < cameraHeight)
        {
            tempVec3.y = targetTransform.transform.position.y;
        }
        else
        {
            tempVec3.y = this.transform.position.y;
        }

        tempVec3.x = targetTransform.position.x;

        tempVec3.z = this.transform.position.z;
        this.transform.position = tempVec3;

    }

}
