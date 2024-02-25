using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private void OnEnable()
    {
        Refences.points.Add(gameObject.transform);
    }

    private void OnDisable()
    {
        Refences.points.Remove(gameObject.transform);
    }
}
