using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(15f, -20f, 30f);
        }
	}
}
