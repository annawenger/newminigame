using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charakterController : MonoBehaviour {

    public Camera cam;


	// Use this for initialization
	void Start () {
		if (camera == null)
        {
            cam = Camera.main;       
            }
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 rawPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPosition = new Vector3(rawPosition.x, 0.0f, 0.0f);
        Rigidbody2D.MovePosition(targetPosition);
	}

    } 
}
