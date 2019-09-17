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

    void Start()
    {
        if (data == null) { gameObject.GetComponent<TankData>(); }
		if (motor == null) { gameObject.GetComponent<TankMotor>(); }
    }

    void Update()
    {

	}
}
