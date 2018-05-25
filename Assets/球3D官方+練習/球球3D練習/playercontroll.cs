using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroll : MonoBehaviour {

    public float moveX;
    public float moveY;
    public float push;    
    private Rigidbody ptrd;
    public Text wintext;
    public Text counttext;
    private int count;

    Vector3 movement;


    void Start () {

        ptrd = GetComponent<Rigidbody>();


        count = 0;
        wintext.text = "";
        SetCountText ();


		
	}
	
	
	void Update () {
          
      
	}

    private void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        movement = new Vector3(moveX, 0.0f,moveY);
        ptrd.AddForce(push * movement);


    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }


    }

    void SetCountText()
    {
        counttext.text = "Count:" + count.ToString();

        if (count >= 12)
        {
            wintext.text = "你贏了";           
        }

    }




}
