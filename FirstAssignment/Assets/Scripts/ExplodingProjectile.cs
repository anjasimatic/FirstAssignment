using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingProjectile : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GameObject prefab = Resources.Load("Snow") as GameObject;
        GameObject snow = Instantiate(prefab) as GameObject;
        snow.transform.position = transform.position;

        Destroy(snow, 5);
        Destroy(gameObject);
    }


}
