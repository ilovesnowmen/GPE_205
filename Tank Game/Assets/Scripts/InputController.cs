using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TankData))]
[RequireComponent(typeof(TankMotor))]

public class InputController : MonoBehaviour
{

	public enum InputScheme { WASD, ArrowKeys};
	public InputScheme input = InputScheme.WASD;

	public TankData data;
	public TankMotor motor;
	public Gun gun;

    void Start()
    {
        if (data == null) { data = gameObject.GetComponent<TankData>(); }
		if (motor == null) { motor = gameObject.GetComponent<TankMotor>(); }
		if (gun == null) { gun = gameObject.GetComponent<Gun>(); }
    }

    void Update()
    {
		switch (input)
		{
			case InputScheme.WASD:
				if (Input.GetKey(KeyCode.W)){motor.Move(data.speed);}
				if (Input.GetKey(KeyCode.A)){motor.Rotate(-data.rotateSpeed);}
				if (Input.GetKey(KeyCode.D)){motor.Rotate(data.rotateSpeed);}
				if (Input.GetKey(KeyCode.S)){motor.Move(-data.speed);}
				if (Input.GetKeyDown(KeyCode.Space))
				{ 
					//check to see if you can fire
					if (data.canFire == true) { gun.Fire(data.shellForce, data.shellDamage);}
					//fire gun
					//Set delay
				}
				break;
		}
	}
}
