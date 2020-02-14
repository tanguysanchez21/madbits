using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float baseATK;
    public float baseDEF;
    private float ATK;
    private float DEF;

    public Transform player;
    public GameObject projectile;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        ATK = baseATK;
        DEF = baseDEF;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) Fire();
        if (Input.touchCount > 0) Fire();
    }

    void Fire() { animator.SetBool("AttackAnimation", true); }

    void ThrowProjectile()
    {
        GameObject bullet = Instantiate(projectile) as GameObject;

        Vector3 position = player.transform.position;
        bullet.transform.position = new Vector3(position.x, position.y - 0.155f, position.z);

        animator.SetBool("AttackAnimation", false);
    }
}
