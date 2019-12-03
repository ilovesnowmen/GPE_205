using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour
{
	// Data Variables
    [Header("Components")]
    public Transform tf;
    public TankMover mover;   

    [Header("Variables")]
    public float moveSpeed;
    public float rotateSpeed;
    public float reverseMoveSpeed;

    public float fireDelay = 1;
    public float shellDamage = 1;
    public float shellForce = 5;
    public float shellLifeSpan = 5;

    public float maxHealth = 5;
    public float currentHealth;



	private void Awake()
    {
        tf = GetComponent<Transform>();
        mover = GetComponent<TankMover>();
    }
    // Start is called before the first frame update
    void Start()
    {
		// Set Health
	    currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
