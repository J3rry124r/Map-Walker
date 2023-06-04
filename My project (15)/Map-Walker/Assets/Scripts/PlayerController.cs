using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
public float turnSpeed;
public float horizontalInput;
public float verticalInput;
    // Update is called once per frame
    void Update()
    {
        //move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        }
}
