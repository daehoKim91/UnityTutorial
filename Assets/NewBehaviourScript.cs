using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	private float tScale;
	private Vector2 vel;
	private Vector2 accel;
	private float mass;
	private float modulus;					//탄성 계수

	private Vector3 prevPosition;

	// Use this for initialization
	void Start () {
		Debug.Log ("Obj start");

		tScale = 0.1f;
		vel.x = vel.y = 0.0f;
		mass = 1.0f;

		accel.x = accel.y = 0.0f;

		modulus = 0.8f;

		prevPosition = this.transform.position;
	}

	// Update is called once per frame
	void Update () {
		prevPosition = this.transform.position;

		//calc velocity
		vel.x += accel.x * tScale;
		vel.y += accel.y * tScale;

		//change position
		Vector3 tPos;
		tPos = this.transform.position;
		tPos.x += vel.x * tScale;
		tPos.z += vel.y * tScale;

		this.transform.position = tPos;

		//change force
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			accel.y += 0.1f;
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			accel.x -= 0.1f;
		}

		if(Input.GetKeyDown(KeyCode.DownArrow)){
			accel.y -= 0.1f;
		}
		
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			accel.x += 0.1f;
		}

		if(Input.GetKeyDown(KeyCode.Space)){
			accel.x = accel.y = 0.0f;
		}

		Debug.Log (accel);
	}

	void OnCollisionEnter( Collision col ) {
		Debug.Log ("Collision Detected");
		//transform.position = prevPosition;

		vel.x *= -1.0f * modulus;
		vel.y *= -1.0f * modulus;
	}

	void OnCollisionStay(Collision collisionInfo){
		vel.x = vel.y = 0.0f;
		Debug.Log ("Stay");
	}
}
