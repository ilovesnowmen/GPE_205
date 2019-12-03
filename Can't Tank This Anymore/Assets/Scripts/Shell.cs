using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Shell : MonoBehaviour
{
	// Variables
	public TankData data;
	public float force;
	public float damage;
	public float selfDestructTimer;

	public Rigidbody rb;
	public Transform tf;
	private float timer;

    // Start is called before the first frame update
    void Start()
    {
		// Getting components
	    rb = GetComponent<Rigidbody>();
	    tf = GetComponent<Transform>();

		// Setting variables
	    force = data.shellForce;
	    damage = data.shellDamage;
	    selfDestructTimer = data.shellLifeSpan;

		// Adding force
		rb.AddForce(tf.forward * force);

    }

    // Update is called once per frame
    void Update()
    {
		//timer
	    timer += Time.deltaTime;
	    if (timer >= selfDestructTimer)
	    {
			Destroy(gameObject);
	    }
    }

    private void OnCollisionEnter(Collision other)
    {
	    if (other.gameObject.GetComponent<TankData>() != null)
	    {
			//deal damage
			other.gameObject.GetComponent<TankData>().currentHealth -= damage;
	    }
		Destroy(gameObject);

    }
}
