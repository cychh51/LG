using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 子彈 : MonoBehaviour {

    public float speed = 20;

    Vector3 移動方向;

    Rigidbody itself;
    

	// Use this for initialization
	void Start () {

        itself = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(0, 0, speed * Time.deltaTime);
       
	}
}
