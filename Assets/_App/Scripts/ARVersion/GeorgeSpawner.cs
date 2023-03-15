using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeorgeSpawner : MonoBehaviour
{
    public Transform George;
    public List<Tree> treeList;
    public int spawnRadius;
    public GameObject playground;
    public BuildingManager buildingManager;
    private static bool TheOneGeorge = false;
    void Awake()
    {
        if (TheOneGeorge)
            return;
        spawnGeorge();
        spawnTree();
        spawnBuildingManager();
        TheOneGeorge = true;
    }

    void spawnGeorge()
    {
        Instantiate(George, transform.position, transform.rotation);
    }
    void spawnTree()
    {
        var size = Vector3.Scale(playground.GetComponent<Renderer>().bounds.size, playground.transform.localScale);
        foreach(Tree tree in treeList)
        {
            Instantiate(tree, transform.position + new Vector3(Random.Range(-size.x, size.x),1, Random.Range(-size.z, size.z)), transform.rotation);
        }
    }
    void spawnBuildingManager()
    {
        Instantiate(buildingManager, transform.position, transform.rotation);
    }
}
