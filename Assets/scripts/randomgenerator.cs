using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class randomgenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        System.Random rnd = new System.Random(123);
        Debug.Log(rnd.Next(1,5));
        Debug.Log(rnd.Next(1,5));
        Debug.Log(rnd.Next(1,5));
        Debug.Log(UnityEngine.Random.Range(1,5));
        Debug.Log(RandomValueint());
    }

    public void RandomValue(){
            System.Random rnd = new System.Random(123);  //deklaration einer Methode
            Debug.Log(rnd.Next(1,5));
        }
    public int RandomValueint()
    {
        System.Random rnd = new System.Random(123);  //deklaration einer Methode
        return rnd.Next(1, 5);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
