using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float secondsUntilDie;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secondsUntilDie -= Time.deltaTime;
        transform.localScale *= secondsUntilDie;
        if (secondsUntilDie <= 0)
        {
            Destroy(gameObject);
        }
    }
}
