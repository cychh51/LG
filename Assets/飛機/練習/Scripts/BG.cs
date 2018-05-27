using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour {

    private float NEW_POSITION;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        NEW_POSITION = Mathf.Repeat(Time.time , 20);

        this.transform.position = new Vector3(0, -10, -NEW_POSITION);


	}
}
