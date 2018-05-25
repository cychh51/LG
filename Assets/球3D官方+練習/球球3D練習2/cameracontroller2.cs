using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller2 : MonoBehaviour {

	public GameObject player;
    public Vector3 set;

	void Start () {

        set = transform.position - player.transform.position;


	}
	
	// Update is called once per frame
	void Update () {


        transform.position = player.transform.position + set;

	}
}
