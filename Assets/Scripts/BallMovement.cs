using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public Transform _transform;
    public GloblesAdding _ga;
    public float _speed;
    public Slider _speedSlider;
    public bool _paused = false;
    private void Awake()
    {
        _transform = gameObject.GetComponent<Transform>();
    }

    public void FixedUpdate()
    {
        _speed = 30f * _speedSlider.value;
        if (!_ga._gameOver && !_ga._levelEnd && !_paused)
        {
            _transform.position = new Vector3(_transform.position.x,
            _transform.position.y, _transform.position.z + _speed * Time.deltaTime);
        }
    }
}
