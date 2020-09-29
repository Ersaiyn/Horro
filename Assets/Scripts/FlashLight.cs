using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{

    Light spotLight;
    AudioSource audio;
    public AudioClip bip;
	
    void Start()
    {
        spotLight = GetComponent<Light>();
        audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
	{
	    if(spotLight.enabled == false)
	    {
		spotLight.enabled = true;
                audio.PlayOneShot(bip);
	    }
	    else
	    {
		spotLight.enabled = false;
                audio.PlayOneShot(bip);
	    }
	}
    }
}
