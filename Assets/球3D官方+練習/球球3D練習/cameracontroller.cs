using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour {

    public GameObject player;
    public Vector3 set;
	
	void Start () {

        set = transform.position - player.transform.position;


	}
	
	
	void Update () {

        transform.position = player.transform.position + set;


	}
}
