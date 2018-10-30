using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {
    public float tumble;
    private Rigidbody rigid;
    	void Start () {
        rigid = GetComponent<Rigidbody>();
        rigid.angularVelocity = Random.insideUnitSphere * tumble;
	}

}
