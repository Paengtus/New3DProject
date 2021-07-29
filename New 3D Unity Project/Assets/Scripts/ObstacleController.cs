using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision AAA)
    {
        if(AAA.transform.tag == "Player")
        {
            Debug.Log("게임오버");
        }
    }
}
