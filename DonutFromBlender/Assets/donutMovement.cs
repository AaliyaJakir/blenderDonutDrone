using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donutMovement : MonoBehaviour
{

    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        float moveUp = Input.GetAxis("Jump");   

        Vector3 movement = new Vector3(moveHorizontal, moveUp * 0.5f, moveVertical);

        transform.position = transform.position + movement * Time.deltaTime *100f;

        rigidbody.AddForce(movement);
    }
}
