using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("enter trigger");
        Destroy(other.gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter collision");
    }

}