using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    Bullet shoot;
    public List<GameObject> attakers;

    private void Start()
    {
        shoot = GetComponent<Bullet>();
    }

    private void Update()
    {
        if (attakers.Count > 0)
        {
            if (attakers[0] == null)
            {
                attakers.RemoveAt(0);
                shoot.target = attakers[0];
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            attakers.Add(other.gameObject);
        }
        shoot.target = attakers[0];
    }

    private void OnTriggerExit(Collider other)
    {
        attakers.RemoveAt(0);
        if (attakers.Count > 0)
            shoot.target = attakers[0];
        else
            shoot.target = null;
    }
}
