#pragma strict

function Start () {
	renderer.material.color = Color(0.5,1,1);
}

function Update () {
	transform.rotation = Input.gyro.attitude;
	Debug.Log(Input.gyro.rotationRate.x);
	Debug.Log(Input.gyro.rotationRate.y);
	Debug.Log(Input.gyro.rotationRate.z);
	
}