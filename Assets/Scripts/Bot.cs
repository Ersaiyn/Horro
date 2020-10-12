using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    
    CapsuleCollider capsuleCollider;
    Animator animator;
    //MovementAnimator movementAnimator;
    bool dead;

    public GameObject deathAnimation;

    Animator anim;
    public float health = 100;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            DestroyMyObject();
        }
    }
    
    void Start() 
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        animator = GetComponentInChildren<Animator>();
        //movementAnimator = GetComponent<MovementAnimator>();   
    }

    void DestroyMyObject()
    {
        Destroy(gameObject, 10);
    }

    void Update ()
    {
    if (dead)
        return;
    }
  public void Kill()
{
    if (!dead) {
        dead = true;
        Destroy(capsuleCollider);
        //Destroy(movementAnimator);
        //Destroy(navMeshAgent);
        animator.SetTrigger("died");
    }
}
}