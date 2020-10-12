using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgByCollisionEnemy : MonoBehaviour
{
    public GameObject deathAnimation;
    

    void Start() 
    {
        Invoke ("DestroyMyObject", 1f);
    }

    void DestroyMyObject()
    {
        Destroy(gameObject, 5);
    }

    void Update()
    {
        
    }
}
