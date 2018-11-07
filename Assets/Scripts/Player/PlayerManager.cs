using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	private float force;
	private Rigidbody rigidbody;	
	// Use this for initialization
	void Start () {
		rigidbody = this.transform.GetComponent<Rigidbody>();
		force = 20.0f;	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		Debug.Log(h);
		rigidbody.AddForce(new Vector3(h,0,0)*force);
	}
}
