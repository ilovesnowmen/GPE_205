using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TankData))]


public class Gun : MonoBehaviour
{

	public TankData data;
	public Transform tf;


    void Start()
    {
	    if (data == null) {data = gameObject.GetComponent<TankData>();}
	    if (tf == null){tf = gameObject.GetComponent<Transform>();}
    }

    void Update()
    {
        
    }

    public void Fire(float force, float damage)
    {
	    Rigidbody clone;
	    clone = Instantiate(data.shellType, tf.position, tf.rotation);
	    clone.velocity = transform.TransformDirection(Vector3.forward * data.shellForce);
    }
}
