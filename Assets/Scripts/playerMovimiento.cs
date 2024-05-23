using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovimiento : MonoBehaviour
{
    public float Speed = 1.0f;
    public float RotationSpeed = 1.0f;
    private Rigidbody Physics;
    public float JumpForce = 1.0f;
    
   // public float velocidadMovimiento = 1;
    //public float fuerzaSalto = 10;
    //private float movX, movY;
    //private Vector3 movimiento;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Physics = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * Speed);

        //Rotacion
        float rotationY = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * RotationSpeed,0));

        //Salto
        if(Input.GetKeyDown(KeyCode.Space))
        //if(Input.GetButton("Jump"))
        {
            Physics.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
          //this.GetComponent<Rigidbody>().AddForce(Vector3.up *fuerzaSalto * Time.deltaTime,ForceMode.Impulse);

        }
         //transform.Translate(movimiento);

    }
}
