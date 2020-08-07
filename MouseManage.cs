using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseManage : MonoBehaviour
{
    // Start is called before the first frame update
    public LayerMask clickableLayer;
    public Sprite crossHair;
    public Sprite Elevate;
    public Image myIMGcomponent;

    // Cursor Texture

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // Cast a ray in the direction of your pointer (50 meters?) and see if it intercepts with a specified layer
        // It stores the hit object information in hit, a RaycastHit object.
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 50, clickableLayer.value))
        {
            //crossHair.color = Color.red; // if something is spotted
            myIMGcomponent.sprite = Elevate;
            // mousePosition returns the current mouse position in pixel coordinate.
            //Debug.Log("This can be clicked!");
            // Detect a left click 
            if (hit.collider.tag == "tile")
            {
               // Debug.Log("This is a tile");
                move(hit, 5);
            }
            else if (hit.collider.tag == "sphere")
            {
                //Debug.Log("This is a sphere");
                move(hit, 5);
            }
            else if (hit.collider.tag == "door")
            {
                //Debug.Log("This is a door");
                // Transform door = hit.transform; // Elevate the door
                // move(hit, 5); // Door cannot move

            }
        }
        else
        {// Test if cursor stays and displays
            myIMGcomponent.sprite = crossHair;
        }
    }

    void move(RaycastHit hit, int dist)
    {
        var obj = hit.transform;
        if (Input.GetMouseButtonDown(0))
        {
            obj.Translate(0,dist,0); // Add height
 
        }
        else if (Input.GetMouseButtonDown(1))
        {
            obj.Translate(0,-dist, 0); // Translate down (same effect)

        }
    }
}

