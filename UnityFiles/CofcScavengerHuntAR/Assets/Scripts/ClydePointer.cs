using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Utils;
using Mapbox.Examples;

public class ClydePointer : MonoBehaviour
{

    LocationStatus playerLocation;
    public Vector2d clydePointerPos;
    [SerializeField]
    public ClydeMenuManager cMManager;

    // Start is called before the first frame update
    void Start()
    {
        cMManager = GameObject.Find("Canvas").GetComponent<ClydeMenuManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        playerLocation = GameObject.Find("Canvas").GetComponent<LocationStatus>();
        var currentPlayerLoc = new GeoCoordinatePortable.GeoCoordinate(playerLocation.GetLocationLat(), playerLocation.GetLocationLong());
        var eventLocation = new GeoCoordinatePortable.GeoCoordinate(clydePointerPos[0], clydePointerPos[1]);
        var distance = currentPlayerLoc.GetDistanceTo(eventLocation);
        Debug.Log("*RAWRUWU* Distance = " + distance);

        if(distance <= 100)
        {
            cMManager.DisplayClydePanel();
        }
    }
}
