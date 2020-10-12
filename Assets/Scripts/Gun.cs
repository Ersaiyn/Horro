using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun :MonoBehaviour
{
    public float damage = 10;
    public float range = 100;

    public Camera fpsCam;
    public ParticleSystem shootEffect;
    public GameObject bulletEffect;
    public float impactForce = 60;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        shootEffect.Play();
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            GameObject effect = Instantiate(bulletEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(effect, 1);

            Rigidbody rigidbody = hit.collider.GetComponent<Rigidbody>();
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            Target target = hit.collider.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            Debug.Log(hit.collider.name);
        }
    }
}