using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    public GameObject bulletPrefab;

    public void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
    }

    private void Start()
    {
        SpawnBullet();
    }
}
