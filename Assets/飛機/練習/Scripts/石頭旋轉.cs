using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 石頭旋轉 : MonoBehaviour {

    Rigidbody 石頭;

    Vector3 旋轉 = new Vector3 (5,10,15);

    public float 旋轉速率 = 0.3f;
    
	// Use this for initialization
	void Start () {

        石頭 = GetComponent<Rigidbody>();
        

	}
	
	// Update is called once per frame
	void Update () {

        //transform.position = Random.onUnitSphere * 5;
        this.transform.Rotate(旋轉 * 旋轉速率);

    }
}
