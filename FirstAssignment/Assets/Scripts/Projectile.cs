using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    private bool isActive;
    private int damage = 1;

    public void Initialize(Vector3 direction)
    {
        isActive = true;
        projectileBody.AddForce(direction);
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject collisionObject = collision.gameObject;

        if(collisionObject.CompareTag("Player"))
        {
            collisionObject.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }

    void Update()
    {
        if (isActive)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime);
        }
    }
}
