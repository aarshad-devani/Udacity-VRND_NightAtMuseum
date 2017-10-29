using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoint : MonoBehaviour {

    [Header("Waypoint Options")]
    public bool isAreaWaypoint = false;
    public GameObject player;
    public bool teleport;
    public GameObject[] informationPanels;
    


	// Use this for initialization
	void Start () {
        if (isAreaWaypoint)
        {
            foreach(GameObject informationPanel in informationPanels)
            {
                informationPanel.SetActive(false);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onWaypointClick()
    {
        if (teleport)
        {
            player.transform.position = gameObject.transform.position;
        }
        else
        {
            iTween.MoveTo(player, iTween.Hash(
                "position", gameObject.transform.position,
                "time", 0.2,
                "easetype", "linear"
                )
            );
        }
        if (isAreaWaypoint)
        {
            foreach (GameObject informationPanel in informationPanels)
            {
                informationPanel.SetActive(true);
            }
        }
    }

    public void HideInformationPanels()
    {
        if (informationPanels.Length > 0)
        {
            foreach (GameObject informationPanel in informationPanels)
            {
                informationPanel.SetActive(false);
            }
        }
    }
}
