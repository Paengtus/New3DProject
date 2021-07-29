using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;

    public Vector3 offset = new Vector3(0, 5, -5);


    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + new Vector3(0, 5, -5);
    }
}
