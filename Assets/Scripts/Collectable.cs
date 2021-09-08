using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public Material _red, _green, _blue, _yellow;
    public int _index;
    public Slider _slider;

    private void Start()
    {
        int _color = Random.Range(1, 5);
        switch (_color)
        {
            case 1:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
                break;
            case 2:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case 3:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            case 4:
                gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
        }
    }
    public void Update()
    {

        if (_slider.value < _index)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
