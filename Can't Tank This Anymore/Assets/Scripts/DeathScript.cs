using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
	public TankData data;

    // Start is called before the first frame update
    void Start()
    {
	    data = GetComponent<TankData>();
    }

    // Update is called once per frame
    void Update()
    {
	    if (data.currentHealth <= 0)
	    {
			Destroy(gameObject);
	    }
    }
}
