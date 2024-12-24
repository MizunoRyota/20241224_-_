using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public int point = 100;
    private void OnCollisionEnter(Collision collision)
    {
        //ScoreScript.instance.ScoreManager(point);
    }
}
