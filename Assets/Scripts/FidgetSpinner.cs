using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FidgetSpinner : MonoBehaviour
{
    private void Update()
    {
        gameObject.GetComponent<Transform>().Rotate(0f, 700*Time.deltaTime,0f);
    }
}
