using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashLight : MonoBehaviour
{

    Light spotLight;
    AudioSource audio;
    public AudioClip bip;

    public float maxBatteryLife = 100;
    public float curBatteryLife;
    float lightDrain = 1f;

    public Image batteryUI;

    void Start()
    {
        spotLight = GetComponent<Light>();
        audio = GetComponent<AudioSource>();
        curBatteryLife = maxBatteryLife;
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

        if(spotLight.enabled == true && curBatteryLife > 0)
        {
            curBatteryLife -= lightDrain * Time.deltaTime;
        }

        if(curBatteryLife <= 0)
        {
            curBatteryLife = 0;
            spotLight.enabled = false;
        }

        batteryUI.transform.localScale = new Vector3(
            curBatteryLife/maxBatteryLife,
            batteryUI.transform.localScale.y,
            batteryUI.transform.localScale.z
        );
    }

    public void AddEnergy()
    {
        curBatteryLife = maxBatteryLife;
    }

}