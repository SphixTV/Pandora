using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    Block block;
    Vector3 mousePosition, targetPosition;
 
    public GridSystem gridSystem;
    //To Instantiate TargetObject at mouse position
    public Transform targetObject;
    public Transform blocks;
    public Transform child;
    float distance = 10f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        //To get the current mouse position
        mousePosition = Input.mousePosition;

        //Convert the mousePosition according to World position
        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, distance));
        targetPosition.x = Mathf.Round(targetPosition.x);
        targetPosition.y = Mathf.Round(targetPosition.y);
        //Set the position of targetObject
        targetObject.position = targetPosition;

        //Debug.Log(mousePosition+"   "+targetPosition);


        //If Left Button is clicked
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("SAS");
            block = new Block();
            block.blockID = 1;
            block.BlockName = "Erde";
            block.BlockPos = new Vector3(targetPosition.x, targetPosition.y, targetPosition.z);
            //create the instance of targetObject and place it at given position.
            gridSystem.PlaceBlock(block, targetObject.gameObject, child);
        }

    }
}
