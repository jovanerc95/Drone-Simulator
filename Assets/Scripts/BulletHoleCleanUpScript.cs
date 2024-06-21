using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHoleCleanUp : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 10f);
    }
}
