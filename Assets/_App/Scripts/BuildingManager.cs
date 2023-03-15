using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BuildingManager : MonoBehaviour
{
    [SerializeField]protected BuildingTypeSO activeBuildingType;
    private void Update()
    {
       if(Input.GetMouseButtonDown(0) && activeBuildingType != null && !EventSystem.current.IsPointerOverGameObject() && isBuildingAffordable(activeBuildingType))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;
            if (Physics.Raycast(ray, out hitPoint))
            { 
                Vector3 mouseWorldPosition = hitPoint.point;
                foreach(BuildingPrice buildingPrice in activeBuildingType.price)
                {
                    buildingPrice.resource.AddRessource(-buildingPrice.price);
                }
                Instantiate(activeBuildingType.prefab, mouseWorldPosition, Quaternion.identity);
            }      
        }
    }
    public void SetActiveBuildingType(BuildingTypeSO buildingTypeSO)
    {
        activeBuildingType = buildingTypeSO;
    }
    public BuildingTypeSO GetActiveBuildingType()
    {
        return activeBuildingType;
    }
    protected bool isBuildingAffordable(BuildingTypeSO buildingtypeSO)
    {
        if (buildingtypeSO.price == null)
            return true;
        foreach(BuildingPrice buildingPrice in buildingtypeSO.price)
        {
            if(buildingPrice.resource.resourceAmount < buildingPrice.price)
            {
                return false;
            }
        }
        return true;
    }
}
