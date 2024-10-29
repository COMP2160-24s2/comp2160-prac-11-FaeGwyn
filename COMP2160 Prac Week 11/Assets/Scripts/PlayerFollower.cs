using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField] private Transform target; 
    [SerializeField] private float gizmosRadius = 2f;

    void Update()
    {
        transform.position = target.position;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, gizmosRadius);
    }
}
