using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class InputController : MonoBehaviour
{
    public enum ControlScheme { WASD, ArrowKeys };

    public TankData pawn;
    public ControlScheme controlScheme;

    private float timer;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Start with the assumption that I'm not moving
        Vector3 directionToMove =  Vector3.zero;

        if (controlScheme == ControlScheme.WASD)
        {
            // If the W key is down -- Add "forward" to the direction I'm moving
            if (Input.GetKey(KeyCode.W))
            { directionToMove += Vector3.forward;}

            // If S key is down -- Add "reverse" to the direction I am moving
            if (Input.GetKey(KeyCode.S))
            { directionToMove += -Vector3.forward; }

            if (Input.GetKey(KeyCode.A))
            { pawn.mover.Rotate(-pawn.rotateSpeed * Time.deltaTime); }

            if (Input.GetKey(KeyCode.D))
            { pawn.mover.Rotate(pawn.rotateSpeed * Time.deltaTime); }

        }
        else if (controlScheme == ControlScheme.ArrowKeys)
        {
	        if (Input.GetKey(KeyCode.UpArrow))
            { directionToMove += Vector3.forward; }

            if (Input.GetKey(KeyCode.DownArrow))
            { directionToMove += -Vector3.forward; }
        }

        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
	        if (timer >= pawn.fireDelay)
	        {

				SendMessage("Fire");
				timer = 0;
	        }

        }

        // After I've checked all my inputs, tell my mover to move in the final direction 
        pawn.mover.Move(directionToMove);
    }
}
