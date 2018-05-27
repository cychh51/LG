using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 石頭移動 : MonoBehaviour {

    Vector3 移動;
    Rigidbody 石頭;
    public float 移動速度 = 10;
	// Use this for initialization
	void Start () {

        石頭 = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {



	}

    private void FixedUpdate()
    {       
        移動 = new Vector3(0, 0, -1);
        石頭.velocity = 移動 * 移動速度;
    }
}
