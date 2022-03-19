using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // ÃÑ¾Ë¸¸µé º¯¼ö
    public GameObject bulletPrefab;
    // ÃÑ¾Ë »ý¼º À§Ä¡
    public Transform firePoint;

    public float fireTimeGap = 0.3f;
    private float fireTimer;

    private void Awake()
    {
        fireTimer = fireTimeGap;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            fireTimer = fireTimeGap;
        }

        if (fireTimer < 0 && Input.GetKey(KeyCode.Space))
        {
            // ÃÑ¾Ë »ý¼º
            Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
            fireTimer = fireTimeGap;
        }
        else
        {
            fireTimer -= Time.deltaTime;
        }
        
    }
}
