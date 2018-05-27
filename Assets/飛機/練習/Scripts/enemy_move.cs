using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_move : MonoBehaviour {

    Rigidbody enemy;

    public float speed = -10;

	// Use this for initialization
	void Start () {



        enemy = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		



	}


    private void FixedUpdate()
    {

        enemy.velocity = transform.forward * speed;

    }
}
