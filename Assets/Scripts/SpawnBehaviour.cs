using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    // public variables here
    public GameObject[] bulletPrefab;
    public float distanceBeforeDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Cannon", 2f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void Cannon()
    {
        int bulletInstance = Random.Range(0, bulletPrefab.Length);
        Instantiate(bulletPrefab[bulletInstance], transform.position, bulletPrefab[bulletInstance].transform.rotation);
    }

    

}
