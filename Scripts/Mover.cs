﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Mover : MonoBehaviour {
    private Rigidbody rigid;
    public float speed;
    void Start () {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;
	}
	void Update () {
		
	}
}
