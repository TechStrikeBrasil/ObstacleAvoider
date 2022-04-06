using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int bumpCount = 0;
   void OnCollisionEnter(Collision collision)
   {
       bumpCount++;
       Debug.Log("You've bumped into the walls " + bumpCount + " times.");
   }
}
