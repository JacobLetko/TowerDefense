using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

    public Color hoverColor;
    public Color startColor;

    private Renderer rend;

    public GameObject turretToBuild;
    private GameObject Turret;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if(Turret != null)
        {
            Debug.Log("Cant Build There");
            return;
        }
        else
        {
            Turret = Instantiate(turretToBuild);
            Turret.transform.position = transform.position;
        }

    }

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
