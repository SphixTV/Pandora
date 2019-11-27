using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    public int orthographicSizeMin;
    public int orthographicSizeMax;
    void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector3 movement = new Vector3(moveHorizontal, moveVertical, -10);

        Vector3 newPosition;
        newPosition.x = movement.x + transform.position.x; newPosition.y = movement.y + transform.position.y;
        newPosition.z = -10;
        transform.position = Vector3.Slerp(transform.position, newPosition, speed * Time.deltaTime);





        if (Input.GetAxis("Mouse ScrollWheel")< 0)
        {
            // forward
            Camera.main.orthographicSize++;
            
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        { // back

            Camera.main.orthographicSize--;
            
        }
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, orthographicSizeMin, orthographicSizeMax);
    }
}
