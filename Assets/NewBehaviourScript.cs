using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		transform.Translate(Input.acceleration.x, 0, Input.acceleration.y);






		/*
		rigidbody.MovePosition(new Vector3(transform.position.x, (transform.position.y + 10f * Time.deltaTime), transform.position.z));
		*/
	}
}
