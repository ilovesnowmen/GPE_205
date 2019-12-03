using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
	// object variables
	public GameObject shell;
	public GameObject barrel;

	public TankData data;

	void Start()
	{
		data = GetComponent<TankData>();
	}

    public void Fire()
	{
		// Creeate shell
		GameObject clone;
		clone = Instantiate(shell, barrel.transform.position, barrel.transform.rotation);
		clone.gameObject.GetComponent<Shell>().data = data;
	}
}
