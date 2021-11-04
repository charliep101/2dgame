using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    

    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;

    public float attackRange = 0.5f;
    public int attackDamage = 40;

// Update is called once per frame
void Update()
    {
    if (Input.GetKeyDown(KeyCode.E))
        {
            Attack();
        } 
    }
   void Attack()
   {

        animator.SetTrigger("Attack");

       Collider2D[] hitEnimies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnimies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(20);
        }

   }
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}


   