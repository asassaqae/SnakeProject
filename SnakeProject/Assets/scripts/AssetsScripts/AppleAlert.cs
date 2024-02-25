using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AppleAlert : MonoBehaviour
{
    [SerializeField] UnityEvent OnTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnTrigger?.Invoke();
    }
}
