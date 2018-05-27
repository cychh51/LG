using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shot_controller : MonoBehaviour {

    public Transform shotspawn;
    public GameObject shot;

    public float time = 0.5f;

    public float repeatRate = 0.5f;

	void Start () {

        InvokeRepeating("fire", time, repeatRate);

	}

    private void Update()
    {
        



    }


    void fire()
    {
        Instantiate(shot, shotspawn.transform.position, shotspawn.transform.rotation);
    }


}
