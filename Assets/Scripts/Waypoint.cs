using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public List<Waypoint> points;

    public Waypoint prev
    {
        get;
        set;
    }
    public Waypoint Dist
    {
        get;
        set;
    }

    void OnDrawGizmos()
    {
        if (points == null)
            return;
        Gizmos.color = new Color(0f, 0f, 0f);
        foreach(var point in points)
        {
            if (poit != null)
                gizmos.DrawLine(transform.position, point.transform.position);
        }
    }
}
