using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject kight;
    public float interval;
    public float timer;
    public int limit;

    private void Update()
    {
        timer -= Time.fixedDeltaTime;
        if (timer <= 0)
        {
            StartCoroutine(spawnCouple());
        }
    }

    void spawn()
    {
        GameObject spawn = Instantiate(kight);
        spawn.transform.position = transform.position + new Vector3(0, 0, -1);
    }

    IEnumerator spawnCouple()
    {
        timer = interval;
        for (int i =0; i < limit; i++ )
        {
            spawn();
            yield return new WaitForSeconds(0.5f);
        }

        limit++;
        
    }

}
