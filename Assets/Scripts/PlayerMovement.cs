using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //Debug.Log("Hello. This code is inside of Start.");

        //this code teleports my game object to a new position
        //transform.position = new Vector3(0, 0, 0);

        


    }
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log("This is called from Update.");

        transform.Translate(0.1f, 0, 0);

    }
}
