using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (TankData))]
public class TankMover : MonoBehaviour
{
    public TankData data;
    private CharacterController characterController;
 

    // Start is called before the first frame update
    void Start()
    {
        data = GetComponent<TankData>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Move (Vector3 worldDirectionToMove)
    {
        // Calculate our direction based on our rotation (so 0,0,1 becomes OUR forward)
        Vector3 directionToMove = data.tf.TransformDirection(worldDirectionToMove);
        // Actually move
        characterController.SimpleMove(directionToMove * data.moveSpeed);
    }

    public void Rotate (float direction)
    {
        data.tf.Rotate(new Vector3(0, direction * data.rotateSpeed * Time.deltaTime, 0));
    }
}
