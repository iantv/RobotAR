using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.Rotate(new Vector3(45f, 45f, 45f) * Time.deltaTime);
    }
}
