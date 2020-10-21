using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 10f;
    public float gravity = -10f;
    public float jumpHeight = 5f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    private int page = 0;
    private GameObject pagePickedUp;

    Vector3 velocity;
    bool isGrounded;


    private void Start()
    {

    }

    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButton("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            //Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Porte") && page >= 10)
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Page")
        {
            print("Page: " + page);
            pagePickedUp = other.gameObject;
            page += 1;
            Destroy(pagePickedUp);
        }
        

    }
}