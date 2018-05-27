using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable
    ]
public class 移動限制
{

    public int xMin,xMax,yMin,yMax;

}

public class Player_move : MonoBehaviour {

    Rigidbody pla;

    Vector3 movement;

    public 移動限制 限制;
    public GameObject shot;
    public GameObject shotspawn;
    public float speed = 10;
    public float 傾斜 = 10;

    private float 延遲時間 = 0.1f;
    private float 延遲;
    private float x, y;

	void Start () {

        pla = GetComponent<Rigidbody>();


	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKey(KeyCode.Mouse0) && Time.time > 延遲)
        {
            延遲 = Time.time + 延遲時間;          
            Instantiate(shot, shotspawn.transform.position, shot.transform.rotation);
        }

	}

    private void FixedUpdate(){


        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        movement = new Vector3(x, 0, y);
        pla.velocity = movement * speed;
        pla.rotation = Quaternion.Euler(0, 0, pla.velocity.x * -傾斜);
        pla.position = new Vector3
        (
            Mathf.Clamp(pla.position.x, 限制.xMin, 限制.xMax),
            0,
            Mathf.Clamp(pla.position.z, 限制.yMin, 限制.yMax)
        );

    }
}
