using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeorgeSpawner : MonoBehaviour
{
    public Transform George;
    public List<Tree> treeList;
    public int spawnRadius;
    private static bool TheOneGeorge = false;
    void Awake()
    {
        if (TheOneGeorge)
            return;
        spawnGeorge();
        spawnTree();
        TheOneGeorge = true;
    }

    void spawnGeorge()
    {
        Instantiate(George, transform.position, transform.rotation);
    }
    void spawnTree()
    {
        foreach(Tree tree in treeList)
        {
            Instantiate(tree, transform.position + new Vector3(Random.Range(-spawnRadius, spawnRadius),1, Random.Range(-spawnRadius, spawnRadius)), transform.rotation);
        }
    }
}
