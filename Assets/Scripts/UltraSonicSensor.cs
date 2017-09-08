using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltraSonicSensor : MonoBehaviour {
    public float Distance;
    public bool debugLines;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        FireCase();

    }

    void FireCase()
    {
        RaycastHit hit;

        Physics.Raycast(transform.position, transform.forward, out hit);

        Distance = hit.distance;

        if (debugLines)
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
        }
    }
}
