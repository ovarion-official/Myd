using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class treeControll : MonoBehaviour {
    public GameObject Object;
    public float Speed;
    void Update(){
        if (Input.GetKey(KeyCode.UpArrow)){
            Object.transform.position += Object.transform.up * Speed;
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            Object.transform.position -= Object.transform.up * Speed;
        }
        if (Input.GetMouseButton(2)){
            Object.transform.Rotate(0, Speed, 0);
        }
        if (Input.GetKey(KeyCode.W)){
            Object.transform.position += Object.transform.forward * Speed;
        }
        if (Input.GetKey(KeyCode.S)){
            Object.transform.position -= Object.transform.forward * Speed;
        }
        if (Input.GetKey(KeyCode.D)){
            Object.transform.position += Object.transform.right * Speed;
        }
        if (Input.GetKey(KeyCode.A)){
            Object.transform.position -= Object.transform.right * Speed;
        }
    }
}