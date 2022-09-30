using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] Slider HealthBar;

    float maxHealth = 4;
    float currentHealth;

    void Start()
    {
        HealthBar.value = maxHealth;
        currentHealth = HealthBar.value;
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Projectile")
        {
            HealthBar.value -= 1f;
            currentHealth = HealthBar.value;
        }
    }
}
