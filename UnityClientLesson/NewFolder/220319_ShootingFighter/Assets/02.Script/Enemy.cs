using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject destroyEffect;

    public void DoDestroyEffect()
    {
        GameObject go = Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(go, 3);
    }

    /*private void OnCollisionEnter(Collision collision)  // �����ִ� collision �� �ε������� Ÿ���̴�.
    {
        if (collision.gameObject != null)
        {
            return;
        }
        else
        {
            Debug.Log(collision.gameObject.name);
        }
    }*/

    /*
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"triggerd! {other.gameObject.name}");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"collieded!! {collision.gameObject.name}");
    }
    */

    /*private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }*/
}
