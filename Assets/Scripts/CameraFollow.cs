using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{
    public Transform _transform, _controller, _cam;
    public float _camSpeed, _camAngle;
    public Slider _sliderAngle;
    private void Update()
    {
        _cam.rotation = Quaternion.Euler(_camAngle * _sliderAngle.value - 13f, 0f, 0f);
        if (!_controller.GetComponent<GloblesAdding>()._gameOver)
        {
            _transform.position = new Vector3(Mathf.Clamp(_controller.position.x * _camSpeed,
                -6f, 5f),
                _transform.position.y, _controller.position.z);
        }
    }
}
