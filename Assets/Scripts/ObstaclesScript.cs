using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}