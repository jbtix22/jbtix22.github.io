using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMove : MonoBehaviour {

    public float moveSpeed = 10f;

    // Use this for initialization
    void Start () {


    }
    
    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.Space))
            transform.Rotate(10, 0, 0);
        if (Input.GetKeyDown(("w")))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKeyDown(("a")))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (Input.GetKeyDown(("d")))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        if (Input.GetKeyDown(("s")))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);





    }
}
