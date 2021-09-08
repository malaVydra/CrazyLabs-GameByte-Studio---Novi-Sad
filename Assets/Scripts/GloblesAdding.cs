using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.EventSystems;

public class GloblesAdding : MonoBehaviour
{
    public Transform _transform, _cam;

    public GameObject _loptica, _first, _new, _new1, _new2, _new3, _new4, _new5, _new6, _new7, _new8;
    
    public float _speed, _distance, _lrspeed, _offset;

    public int _globles;

    public GameObject _restart;

    public SphereCollider _controllerCollider;

    public bool _gameOver, _levelEnd;

    private void Start()
    
    {
        _gameOver = false;
        _transform = gameObject.GetComponent<Transform>();
        int _color = Random.Range(1, 5);
        switch (_color)
        {
            case 1:
                _first.GetComponent<MeshRenderer>().material.color = Color.cyan;
                break;
            case 2:
                _first.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case 3:
                _first.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
            case 4:
                _first.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
        }
    }

    public void FixedUpdate()
    {
        if (!_levelEnd)
        {
            _transform.Rotate((320-_globles*10f)*Time.deltaTime,0,0);
        }
        if (Input.GetMouseButton(0)) // Easier for testing on PC
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = _distance;

            //  Limiting the X coordinate:
            if (!_gameOver && !_levelEnd)
            {
                if (EventSystem.current.IsPointerOverGameObject())
                    return;
                _transform.position = new Vector3(Camera.main.ScreenToWorldPoint(mousePosition).x * _lrspeed,
                    _transform.position.y, _transform.position.z);
            }
        }
    }

    private void Update()
    {
        if ((_globles < 0 || _transform.position.y < -0.7f) && !_gameOver)
        {
            GameOver();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("collect"))
        {
            Destroy(other);
            _globles += 1;
            switch (_globles)
            {
                case 1:
                    _first.GetComponent<Transform>().localPosition = new Vector3(-0.125f, 0f, 0f);
                    _new = Instantiate(_loptica, _transform);
                    _new.GetComponent<Transform>().localPosition = new Vector3(0.125f, 0f, 0f);
                    _new.GetComponent<MeshRenderer>().material.color = 
                        other.GetComponent<MeshRenderer>().material.color;
                    _controllerCollider.radius = 0.3f;
                    break;
                case 2:
                    _first.GetComponent<Transform>().localPosition = new Vector3(0f, 0f, 0f);
                    _new1 = Instantiate(_loptica, _transform);
                    _new.GetComponent<Transform>().localPosition = new Vector3( 0.25f, 0f, 0f);
                    _new1.GetComponent<Transform>().localPosition = new Vector3( -0.25f, 0f, 0f);
                    _new1.GetComponent<MeshRenderer>().material.color =
                        other.GetComponent<MeshRenderer>().material.color;
                    _controllerCollider.radius = 0.32f;
                    break;
                case 3:
                    _first.GetComponent<Transform>().localPosition = new Vector3( 0f, -0.125f, 0f);
                    _new2 = Instantiate(_loptica, _transform);
                    _new.GetComponent<Transform>().localPosition = new Vector3(-0.175f, 0.1f, 0f);
                    _new1.GetComponent<Transform>().localPosition = new Vector3(0.1f, 0.1f, 0f);
                    _new2.GetComponent<Transform>().localPosition = new Vector3(0f, 0f, 0.15f);
                    _new2.GetComponent<MeshRenderer>().material.color =
                        other.GetComponent<MeshRenderer>().material.color;
                    _transform.localScale = new Vector3(1.1f,1.1f,1.1f);
                    _controllerCollider.radius = 0.32f;
                    break;
                case 4:
                    _new3 = Instantiate(_loptica, _transform);
                    _new3.GetComponent<Transform>().localPosition = new Vector3(0f, 0f, -0.15f);
                    _new3.GetComponent<MeshRenderer>().material.color =
                        other.GetComponent<MeshRenderer>().material.color;
                    _controllerCollider.radius = 0.33f;
                    break;
                case 5:
                    _new4 = Instantiate(_loptica, _transform);
                    _new4.GetComponent<Transform>().localPosition = new Vector3(-0.188f, -0.122f, 0f);
                    _new4.GetComponent<MeshRenderer>().material.color =
                        other.GetComponent<MeshRenderer>().material.color;
                    _controllerCollider.radius = 0.34f;
                    break;
                case 6:
                    _new5 = Instantiate(_loptica, _transform);
                    _new5.GetComponent<Transform>().localPosition = new Vector3(0.18f, 0f, -0.06f);
                    _new5.GetComponent<MeshRenderer>().material.color =
                        other.GetComponent<MeshRenderer>().material.color;
                    _transform.localScale = new Vector3(1.2f,1.2f,1.2f);
                    _controllerCollider.radius = 0.37f;
                    break;
                case 7:
                    _new6 = Instantiate(_loptica, _transform);
                    _new6.GetComponent<Transform>().localPosition = new Vector3(0.182f, -0.085f, 0.1f);
                    _new6.GetComponent<MeshRenderer>().material.color =
                        other.GetComponent<MeshRenderer>().material.color;
                    _transform.localScale = new Vector3(1.3f,1.3f,1.3f);
                    _controllerCollider.radius = 0.38f;
                    break;
                case 8:
                    _new7 = Instantiate(_loptica, _transform);
                    _new7.GetComponent<Transform>().localPosition = new Vector3(-0.195f, -0.068f, -0.144f);
                    _new7.GetComponent<MeshRenderer>().material.color =
                        other.GetComponent<MeshRenderer>().material.color;
                    _transform.localScale = new Vector3(1.35f,1.35f,1.35f);
                    _controllerCollider.radius = 0.40f;
                    break;
                case 9:
                    _new8 = Instantiate(_loptica, _transform);
                    _new8.GetComponent<Transform>().localPosition = new Vector3(-0.221f, 0.025f, 0.127f);
                    _new8.GetComponent<MeshRenderer>().material.color =
                        other.GetComponent<MeshRenderer>().material.color;
                    _transform.localScale = new Vector3(1.5f,1.5f,1.5f);
                    _controllerCollider.radius = 0.43f;
                    break;
            }

            if (_globles > 9)
            {
                _globles = 9;
            }
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Prepreka")
        {
            _globles -= 1;

            switch (_globles)
            {
                case -1:
                    Destroy(_first);
                    break;
                case 0:
                    Destroy(_new);
                    _first.transform.position = new Vector3(0, 0, 0);
                    _transform.localScale = new Vector3(0, 0, 0);
                    _controllerCollider.radius = 0.26f;
                 
                    break;
                case 1:
                    Destroy(_new1);
                
                    _controllerCollider.radius = 0.3f;
                    break;
                case 2:
                    Destroy(_new2);
                 
                    _controllerCollider.radius = 0.32f;
                    break;
                case 3:
                    Destroy(_new3);
                    _transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
                
                    _controllerCollider.radius = 0.32f;
                    break;
                case 4:
                    Destroy(_new4);
                    
                    _controllerCollider.radius = 0.33f;
                    break;
                case 5:
                    Destroy(_new5);
                    
                    _controllerCollider.radius = 0.34f;
                    break;
                case 6:
                    Destroy(_new6);
                    _transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
                    _controllerCollider.radius = 0.37f;
               
                    break;
                case 7:
                    Destroy(_new7);
                    _transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
                    _controllerCollider.radius = 0.38f;
                   
                    break;
                case 8:
                    Destroy(_new8);
                    _transform.localScale = new Vector3(1.35f, 1.35f, 1.35f);
                    _controllerCollider.radius = 0.4f;
                    
                    break;
            }
        }else if(collision.gameObject.tag == "kraj")
        {
            LevelEnd();
        }
    }
    public void GameOver()
    {
        _gameOver = true;
        _globles = 0;
        _restart.SetActive(true);
    }

    public void LevelEnd()
    {
        _levelEnd = true;
        _restart.SetActive(true);
    }
}
