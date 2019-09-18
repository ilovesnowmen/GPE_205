using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour
{

	public float speed = 1;
	public float rotateSpeed = 90;
	public float health = 1;
	public float fireDelay = 1;
	public float shellForce = 1;
	public float shellDamage = 1;
	public bool canFire = true;
	public Rigidbody shellType;
}