using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.1f;

    void Start()
    {
    }

    void Update()
    {
        Move();
    }

    public void Move() {

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float accelerate = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(0, accelerate, 0);
        transform.Rotate(0, 0, -steerAmount);
    }
}
