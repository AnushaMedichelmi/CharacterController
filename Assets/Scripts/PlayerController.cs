using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerSpeed;
    CharacterController characterController;
    Vector3 movement;
    Vector2 mouseInput;
    public Camera cam;
    public float rotation;
    void Start()
    {
        characterController = GetComponent<CharacterController>(); //To access the character controller
    }

    // Update is called once per frame
    void Update()
    {
       // mouseInput=new Vector2
        movement.x=Input.GetAxis("Horizontal")*playerSpeed*Time.deltaTime; //To make the player move in horizontal direction
        movement.z = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime; //To make the player move in vertical direction
        characterController.Move(movement); //Supplies the movement of a GameObject with an attached CharacterController component.

        mouseInput.x= Input.GetAxis("Mouse X");
        mouseInput.y= Input.GetAxis("Mouse Y");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y+mouseInput.x, transform.rotation.eulerAngles.z); //Rotation of the Player
        // cam.transform.rotation = Quaternion.Euler(cam.transform.rotation.eulerAngles.x+(-mouseInput.y),cam.transform.rotation.eulerAngles.y,cam.transform.rotation.eulerAngles.z);
        cam.transform.rotation = Quaternion.Euler(cam.transform.rotation.eulerAngles+new Vector3(-mouseInput.y,0f,0f)); //Rotation of the Camera


    }
}
