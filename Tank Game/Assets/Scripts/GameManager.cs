using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	//Game Manager Stuff
	public static GameManager GM;

	private void Awake()
	{
		if(GM == null){GM = this;}
		else{Debug.LogError("Only one GM"); Destroy(gameObject);}
	}
}
