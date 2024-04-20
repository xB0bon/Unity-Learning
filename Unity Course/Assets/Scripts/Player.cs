using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f; // pozwala na edycje w unity
    private void Update()
    {
        
        Vector2 inputVector = new Vector2();
        if (Input.GetKey((KeyCode.W)))
        {
            inputVector.y += 1;
            
        }
        if (Input.GetKey((KeyCode.S)))
        {
            inputVector.y -= 1;
            
        }
        if (Input.GetKey((KeyCode.A)))
        {
            inputVector.x -=1;
            
        }
        if (Input.GetKey((KeyCode.D)))
        {
            inputVector.x += 1;
            
        }
        inputVector = inputVector.normalized; // blokuje szybsze poruszanie się na boki
        
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        
        transform.position += moveDir * moveSpeed * Time.deltaTime; // poztać poruszą się tak sanmo szybko bez zaleznosi fps

        float rotateSpeed = 10;
        transform.forward = Vector3.Slerp(transform.forward, -moveDir, rotateSpeed * Time.deltaTime);
        Debug.Log(moveDir);
        
        
    }
}
