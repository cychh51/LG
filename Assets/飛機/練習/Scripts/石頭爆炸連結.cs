using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 石頭爆炸連結 : MonoBehaviour {

    public GameObject 特效;
    public GameObject 玩家爆炸特效;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "邊界")
        {

            return;

        }
        if(特效 != null)
        {

            Instantiate(特效, this.transform.position, this.transform.rotation);

        }
        if(other.tag == "Player")
        {

            Instantiate(玩家爆炸特效, other.transform.position, other.transform.rotation);

        }


        Destroy(this.gameObject);
        Destroy(other.gameObject);


    }
}
