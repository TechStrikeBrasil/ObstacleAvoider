using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDropper : MonoBehaviour
{
    [SerializeField] float dropTime = 3f;

    MeshRenderer renderer; 
    Rigidbody rbody;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time alive: " + Time.time);

        if (Time.time > dropTime){
            renderer.enabled = true;
            rbody.useGravity = true;
        }
    }
}
