using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movement : MonoBehaviour
{
    NavMeshAgent nav;
    public GameObject target;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        destination();
    }

    private void destination()
    {
        nav.SetDestination(target.transform.position);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * 5;
        Gizmos.DrawRay(transform.position, direction);
    }
}
