using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    public GameObject bulletPrefab;

    public void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, this.transform.position, Quaternion.identity) as GameObject;
        Bullet script = bullet.GetComponent<Bullet>();
        script.direction = Quaternion.Euler(0, 0, Random.Range(0, 360)) * Vector2.right;
    }

    private void Start()
    {
        SpawnBullet();
    }
}
