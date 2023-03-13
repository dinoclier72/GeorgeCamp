using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Resource resource;
    public int amount = 1;
    public void pickup()
    {
        resource.AddRessource(amount);
        Destroy(gameObject);
    }
}
