﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour {

    public bool positive;
	// Use this for initialization
	void Start () {
        if (positive)
        {
            //this.transform.rotation = new Quaternion(0, 0, 0,0);
            this.transform.Rotate(Vector3.zero);
            this.transform.Rotate(0, 0, 45.0f);
        }
        else
        {
            // this.transform.rotation = new Quaternion(0, 0, 0, 0);
            this.transform.rotation = new Quaternion(0, 0, 0, 0);
            this.transform.Rotate(0, 0, -45.0f);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
