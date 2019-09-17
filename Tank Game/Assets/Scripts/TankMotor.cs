using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMotor : MonoBehaviour
{
	// Variables for holding components
	private CharacterController characterController;
	public Transform tf;

    void Start()
	{
		characterController = gameObject.GetComponent<CharacterController>();
		tf = gameObject.GetComponent<Transform>();
	}

    void Update(){}


	public void Move(float speed) //Gives us forward and backward motion
	{
		Vector3 moveVector = tf.forward * speed; // Take the speed and create a move vector for SimpleMove()
		characterController.SimpleMove(moveVector); // Time.DeltaTime is applied automaticly
	}

	public void Rotate(float speed) //Gives us left and right Rotation
	{
		Vector3 rotateVector = tf.up * speed * Time.deltaTime; //Same as Move() but needs Time.DeltaTime because we are not using simple move
		tf.Rotate(rotateVector, Space.Self);
	}

}
