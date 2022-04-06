using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDropper : MonoBehaviour
{
    [SerializeField] float dropTime = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time alive: " + Time.time);

        if (Time.time > dropTime){
            GetComponent<Rigidbody>().gameObject.SetActive(true);
        }
    }
}
