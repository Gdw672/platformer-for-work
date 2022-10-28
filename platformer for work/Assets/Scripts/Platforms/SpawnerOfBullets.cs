using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOfBullets : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    private void Start()
    {
        InvokeRepeating("spawnBullet", 0, 8f);
    }

    private void spawnBullet() 
    {
        Instantiate(bulletPrefab, gameObject.transform.position, Quaternion.identity);
    }
}
