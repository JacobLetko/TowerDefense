using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public float speed;

    private Stack<Vector3> currentPath;
    private Vector3 currentPointPosition;
    private float moveTimeTotal;
    private float moveTimeCurrent;

    public void NavigateTo(Vector3 dest);

    public void Stop();

    public void Update();
}
