using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    void Start(){
        
    }

    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
