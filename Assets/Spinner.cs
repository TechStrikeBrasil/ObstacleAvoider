using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationX = 1f;
    [SerializeField] float rotationZ = 1f;
    [SerializeField] float rotationY = 1f;
    
    void Update()
    {
        gameObject.transform.Rotate(rotationX, rotationY, rotationZ);
    }
}
