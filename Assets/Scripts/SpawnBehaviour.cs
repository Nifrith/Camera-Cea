using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    // public variables here
    [SerializeField] GameObject[] bulletPrefab;
    [SerializeField] float spawnDelay;
    [SerializeField] float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Cannon", spawnInterval, spawnDelay);
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
