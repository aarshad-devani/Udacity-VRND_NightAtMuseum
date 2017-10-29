using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour {

    public GameObject[] waypoints;
    public GameObject[] spotPoints;
    public GameObject spotLight;

    private GameObject previousWaypoint;

    
    //private GameObject currentWaypoint;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void setCurrentWaypoint(GameObject currentObject)
    {
        if (previousWaypoint)
        {
            toggleCollider(previousWaypoint);

        }
        //currentWaypoint = currentObject;
        toggleCollider(currentObject);
        //toggleCollider(previousWaypoint);
        previousWaypoint = currentObject;
    }

    private void toggleCollider(GameObject thisGameObject)
    {
        (thisGameObject.GetComponent<Collider>()).enabled = !((thisGameObject.GetComponent<Collider>()).enabled);
    }

    private void setColliderMode(GameObject thisGameObject, bool toggleValue)
    {
        (thisGameObject.GetComponent<Collider>()).enabled = toggleValue;
    }

    public void showSpotLight(int number)
    {
        spotLight.transform.LookAt(spotPoints[number].transform);
    }
}
