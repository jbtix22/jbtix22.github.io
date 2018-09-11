using UnityEngine;
using System.Collections;

public class Scaler : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
            transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
        if (Input.GetKey(KeyCode.Z))
            transform.localScale -= new Vector3(0.1F, 0.1F, 0.1F);

    }
}
