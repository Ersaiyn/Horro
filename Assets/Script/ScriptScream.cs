using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScream : MonoBehaviour
{

    public GameObject ScreamIMG;
    AudioSource Audio;
    public AudioClip ScarySound;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
        ScreamIMG.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            ScreamIMG.SetActive(true);
            Audio.PlayOneShot(ScarySound);
            Destroy(ScreamIMG,2f);
            Destroy(gameObject, 2f);
        }
    }
}
