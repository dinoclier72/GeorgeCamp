using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    [SerializeField]private BuildingTypeSO activeBuildingType;
    private void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(null, mouseWorldPosition, Quaternion.identity);
        }
    }
}
