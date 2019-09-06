using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpFor = 1.0f;
    public int jumpCount = 0;

    public bool grounded = false;
    // Start is called before the first frame update
    void Start()
    {
    


}

    // Update is called once per frame
    void Update()
    {
        

        float horzontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Debug.Log(horzontalInput);

        //transfom.position = new Vector3(transform.position.x+horzontalInput*Time.deltaTime, transform.position.y)
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(horzontalInput, rb.velocity.y, verticalInput);

        if (Input.GetButton("Jump") && jumpCount == 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpFor, rb.velocity.z);
            jumpCount = 1;
        }


            if (Physics.Raycast(transform.position, Vector3.down, 0.8f))
            {
                grounded = true; jumpCount = 0;
            }
            else
            {
                grounded = false;

            }
        
    }
}
