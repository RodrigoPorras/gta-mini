using UnityEngine;
using System.Collections;

public class car : MonoBehaviour {
	public WheelCollider wheelFR;
	public WheelCollider wheelFL;
	public WheelCollider wheelBR;
	public WheelCollider wheelBL;

	public float speed=10;
	public float braking=20;
	public float turning=20;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//forward
		wheelBR.motorTorque = Input.GetAxis("Vertical")*speed;
		wheelBL.motorTorque = Input.GetAxis("Vertical")*speed;

		wheelBR.brakeTorque = 0;
		wheelBL.brakeTorque = 0;

		//turn
		wheelFL.steerAngle = Input.GetAxis("Horizontal")*turning;
		wheelFR.steerAngle = Input.GetAxis("Horizontal")*turning;

		//brakes
		if(Input.GetKey(KeyCode.Space)){
			wheelBR.brakeTorque = braking;
			wheelBL.brakeTorque = braking;
		}

	}
}
