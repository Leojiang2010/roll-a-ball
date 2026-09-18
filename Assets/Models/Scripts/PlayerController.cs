using UnityEngine;

public class P : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 10);  
    }
using UnityEngine;

public class NameOfClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}/************************************************************
* Block D
* COMPONENT OF: Player
* REQUIRED DEPENDENCIES: Rigidbody Component
* DESCRIPTION: It listens for WASD and Arrow key presses to set 
*              vertical and horizontal directions. It uses those
*              to push the player's Rigidbody in that direction
*              at a preset force.
* AUTHOR: BGustinLeo Jiang 09/16/2026
* VERSION: 1.0
*************************************************************/
using UnityEngine;
horizontalMovement = 0.707f;
verticalMovement = 0.707f;
force = 4.75f;
// Update is called once per frame
void Update()
{
    MovePlayer();
}

// Moves the player
private void MovePlayer()
{
    Vector3 direction = new Vector3(horizontalMovement, 0, verticalMovement);
    GetComponent<Rigidbody>().AddForce(Vector3.forward * 10);
}
// Moves the player
private void MovePlayer()
{
    Vector3 direction = new Vector3(horizontalMovement, 0, verticalMovement);
    GetComponent<Rigidbody>().AddForce(direction * force);
}
