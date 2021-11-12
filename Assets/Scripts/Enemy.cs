using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    public int emaxHealth = 100;
    int ecurrentHealth;



    // Start is called before the first frame update
    void Start()
    {
        ecurrentHealth = emaxHealth;
    }

    public void TakeDamage(int damage)
    {
        ecurrentHealth -= damage;

        animator.SetTrigger("Hurt");

        if (ecurrentHealth <= 0)
        {
            eDie();
        }
    }

    void eDie()
    {
        Debug.Log("Enemy died");

        animator.SetBool("IsDead", true);

        GetComponent<Collider2D>().enabled = false;
        GetComponent<EnemyPatrol>().enabled = false;
        this.enabled = false;

        Destroy(gameObject);
    }


}
