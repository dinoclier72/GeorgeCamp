using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARPlaneManager))]
public class PlacePlaygroundOnARPlane : MonoBehaviour
{
    [SerializeField] private GameObject playgroundPrefab;
    [SerializeField] private ARPlaneManager arPlaneManager;

    private void Awake()
    {
        arPlaneManager = GetComponent<ARPlaneManager>();
        arPlaneManager.planesChanged += PlaneChanged;
    }

    private void PlaneChanged(ARPlanesChangedEventArgs args)
    {
        if(args.added != null)
        {
            ARPlane arPlane = args.added[0];
            Instantiate(playgroundPrefab, arPlane.transform.position, arPlane.transform.rotation);
        }
    }
}
