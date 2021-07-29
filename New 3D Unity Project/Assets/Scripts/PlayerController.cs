using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;

    public float turnSpeed = 10f;
    public float inputHorizontalValute;
    public float inputVerticalValute;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontalValute = Input.GetAxis("Horizontal");
        inputVerticalValute = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * inputHorizontalValute);
    }
}
