using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{
	public static GameManager instance;


	void Awake()
	{
		if (instance == null) {instance = this;}
		else {Debug.LogError("There can only be one"); Destroy(gameObject);}
	}
}
