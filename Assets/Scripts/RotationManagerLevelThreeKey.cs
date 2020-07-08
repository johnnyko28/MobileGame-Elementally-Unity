﻿using UnityEngine;

public class RotationManagerLevelThreeKey : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //the following code connects cubes after rotation has been made
        Transform cubeToConnect1 = transform.Find("Cube (68)");
        Transform cubeToConnect2 = GameObject.Find("Cube (80)").transform;
        Transform cubeToConnect3 = GameObject.Find("Cube (30)").transform;
        Transform cubeToConnect4 = GameObject.Find("Cube (94)").transform;
        //return if Transform not found
        if (cubeToConnect1 == null || cubeToConnect2 == null)
        {
            Debug.Log("Cube not reachable");
            return;
        }
        //check if the rotation angle is 270 degree, which connects two blocks
        if (Mathf.Abs(transform.rotation.eulerAngles.z - 0f) < 0.1f)
        {
            cubeToConnect3.GetComponent<Walkable>().possiblePath[2].active = true;
            cubeToConnect4.GetComponent<Walkable>().possiblePath[1].active = true;
            cubeToConnect4.GetComponent<Walkable>().canWalkOnThisBlock = true;
        }
        else
        {
            cubeToConnect3.GetComponent<Walkable>().possiblePath[2].active = false;
            cubeToConnect4.GetComponent<Walkable>().possiblePath[1].active = false;
            cubeToConnect4.GetComponent<Walkable>().canWalkOnThisBlock = false;
        }
    }
}