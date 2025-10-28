using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Player : MonoBehaviour
{   
    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            
            Ray rayOrigin = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            RaycastHit hit;
            
            if (Physics.Raycast(rayOrigin, out hit))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);

                var hitObject = hit.collider.GetComponent<MeshRenderer>();

                if (hitObject != null)
                {
                    Debug.Log("Hit: " + hit.collider.name);
                    hitObject.material.color = Random.ColorHSV();
                }
            }
        }
        
        //requires user input
        //left mouse click
        //fire raycast from main camera or mouse position
        //access object that is hit

        //change colour 
    }
}
