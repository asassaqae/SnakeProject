using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    [SerializeField] GameObject explosionEffect;


    public void Death()
    {
        GameData.Score++;
        GameData.applesRemaning--;
        GameData.ShowScore();
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }
}
