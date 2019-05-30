using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public GameObject bullet;
    public float interval;
    float timer;
    public float speed;
    public GameObject target;


    // Update is called once per frame
    void Update()
    {
        timer -= Time.fixedDeltaTime;
        if (timer <= 0)
        {
            timer = interval;
            if(target != null)
            bulletspawn();
        }
    }

    void bulletspawn()
    {
        GameObject sbullet = Instantiate(bullet);
        sbullet.transform.position = transform.position;
        Vector3 shootdir = (target.transform.position - transform.position).normalized;
        sbullet.GetComponent<Rigidbody>().velocity = shootdir * speed;
        Destroy(sbullet, 3);
    }
}
