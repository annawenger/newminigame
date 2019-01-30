using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour {

void OnTriggerEnter2D (Collider2D other)
    {
        Debug.Log("enter trigger ball: "+ other.name);
        Destroy(other.gameObject);
    }
}