using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   [SerializeField] private float startingHealth;
    public float currentHealth;

    private void Awake()
    {
        currentHealth = startingHealth;
    }
    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            TakeDamage(1);
    }

}
