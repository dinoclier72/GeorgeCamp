using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateOnce : MonoBehaviour
{
    public static bool AlreadyGenerated = false;
    void Awake()
    {
        if (AlreadyGenerated) 
        {
            Destroy(gameObject);
        }
        AlreadyGenerated = true;
    }
}
