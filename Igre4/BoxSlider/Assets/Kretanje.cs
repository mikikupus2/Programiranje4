using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Kretanje : MonoBehaviour
{
    public GameObject prefab;
    public Rigidbody rb;
    public Canvas gameover;
    public Canvas end;
    public float forward = 1000f;
    public float horizontal = 1000f;
    public bool game = true;
    void Start()
    {
        gameover.enabled = false;
        end.enabled = false;
        Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
    }
    void FixedUpdate()
    {
        if(game)
        {
            rb.AddForce(0, 0, forward * Time.deltaTime);
            if (Input.GetKey("a"))
                rb.AddForce(-horizontal * Time.deltaTime, 0, 0);
            if (Input.GetKey("d"))
                rb.AddForce(horizontal * Time.deltaTime, 0, 0);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Kutija")
        {
            gameover.enabled = true;
            game = false;
            rb.velocity = Vector3.zero;
        }
        else if(collision.collider.tag == "kraj")
        {
            end.enabled = true;
            game = false;
            rb.velocity = Vector3.zero;
        }
    }
}
