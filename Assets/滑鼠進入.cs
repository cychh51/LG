using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 滑鼠進入 : MonoBehaviour {



    AudioSource audio;

    public AudioClip one;
    

	// Use this for initialization
	void Start () {

        audio = GetComponent<AudioSource>();


	}
	
	// Update is called once per frame
	void Update () {
		



	}


    private void OnMouseEnter()
    {
      
        audio.clip = one;

        if (!audio.isPlaying)
        {

             audio.Play();

        }
        
    }

    private void OnMouseOver()
    {

        

    }

    private void OnMouseExit()
    {
        audio.Pause();
    }

}
