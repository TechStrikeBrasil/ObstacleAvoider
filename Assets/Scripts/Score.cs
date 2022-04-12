using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] int bumpCount = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Hit") { return; }
        bumpCount++;
        Debug.Log("You've bumped into the walls " + bumpCount + " times.");
    }
}
