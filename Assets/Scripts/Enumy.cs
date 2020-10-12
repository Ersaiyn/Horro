using System.Collections;
using UnityEngine.UI;
using UnityEngine;
 
public class Enumy : MonoBehaviour
{
    public float seeDistance = 30.5f;
    public float attackDistance = 5.0f;
    private UnityEngine.AI.NavMeshAgent nav;
    public Transform target;
    public Animation anim;
    public AnimationClip a_Idle;
    public float a_IdleSpeed = 1;
    public AnimationClip a_Walk;
    public float a_WalkSpeed = 2;
    public AnimationClip a_Attack;
    public float a_AttackSpeed = 2;
    private bool walk;
    private bool Attacka;
    public int Damage;
 
    public float health;
    public float maxHealth;
    public AnimationClip Death;
    public Image healthBar;
 
    void Start()
    {
        GetComponent<Animation>()[a_Idle.name].speed = a_IdleSpeed;
        GetComponent<Animation>()[a_Attack.name].speed = a_AttackSpeed;
        GetComponent<Animation>()[a_Walk.name].speed = a_WalkSpeed;
        GetComponent<Animation>().CrossFade(a_Idle.name);
 
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
 
        health = maxHealth;
    }
 
    void IdleState()
    {
        nav.enabled = false;
        GetComponent<Animation>().CrossFade(a_Idle.name);
    }
 
    void Update()
    {
        if (anim[a_Attack.name].enabled == false)
        {
            Attacka = true;
        }
 
        if (Vector3.Distance(transform.position, target.transform.position) <= seeDistance)
        {
            if (anim[a_Attack.name].time > 0.9 * anim[a_Attack.name].length & target.tag == "Player")
            {
                target.GetComponent<Target>().health -= Damage;
            }
        }
 
        if (target == null)
        {
            IdleState();
        }
 
        if (Vector3.Distance(transform.position, target.transform.position) <= seeDistance & Attacka == true)
        {
            if (Vector3.Distance(transform.position, target.transform.position) > attackDistance & anim[a_Attack.name].enabled == false)
            {
                GetComponent<Animation>().CrossFade(a_Walk.name);
                walk = true;
                nav.enabled = true;
                nav.SetDestination(target.position);
            }
            else
            {
                if (target.tag == "Player")
                {
                    nav.enabled = false;
                    GetComponent<Animation>().CrossFade(a_Attack.name);
                    walk = false;
                    Vector3 lookAtPosition = target.position;
                    lookAtPosition.y = transform.position.y;
                    transform.LookAt(lookAtPosition);
                }
            }
        }
        else
        {
            GetComponent<Animation>().CrossFade(a_Idle.name);
            walk = false;
            nav.enabled = false;
        }
 
        healthBar.fillAmount = health / maxHealth;
        if (health > maxHealth)
        {
            health = 100;
        }
        if (health < 0)
        {
            GetComponent<Animation>().CrossFade(Death.name);
            Destroy(gameObject, Death.length);
        }
    }
}