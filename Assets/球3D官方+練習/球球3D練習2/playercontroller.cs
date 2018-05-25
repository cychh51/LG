using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playercontroller : MonoBehaviour {

    public float moveX;//宣告一個前進
    public float moveY;//宣告一個左右
    Rigidbody ptrd;
    public float speed;//宣告一個速度
    Vector3 movement;
    public Text wintext;
    public Text conttext;
    private int cont = 0;
    



	void Start () {

        ptrd = GetComponent<Rigidbody>();
        wintext.text = "";
        conttext.text = "分數:";
            cont = 0;

	}
	
	
	void Update () {

        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        movement = new Vector3(moveX,0, moveY);
        ptrd.AddForce(speed * movement);

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            cont = cont + 1;
            conttext.text = "分數:" + cont.ToString();
        }
        if (cont >= 5)
        {
            wintext.text = "你贏了".ToString();
            Time.timeScale = 0f;//遊戲暫停
            
        }

    }

}
