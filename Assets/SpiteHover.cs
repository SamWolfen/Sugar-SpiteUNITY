using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiteHover : MonoBehaviour {

    public float Counter, sinCounter, Rate;
    Vector3 Pos;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Pos = this.gameObject.transform.position;

        Counter += Rate * Time.deltaTime;
        sinCounter = Mathf.sin(Counter);

        Pos += new Vector3(0, sinCounter, 0);


        this.gameObject.transform.position = Pos;
            }
}
