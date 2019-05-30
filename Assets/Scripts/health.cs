using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    int hitpoints;
    public int HP
    {
        get
        {
            return hitpoints;
        }

        set
        {
            hitpoints = value;
            if (hitpoints <= 0)
                Destroy(gameObject);
        }
    }

    public int startingHealth;

    private void Awake()
    {
        HP = startingHealth;
    }
}
