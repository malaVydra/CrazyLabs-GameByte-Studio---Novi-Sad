using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMoving : MonoBehaviour
{
    public Transform _transformTile;

    public float _speedTile;
    private void Update()
    {
        _transformTile.position = new Vector3(_transformTile.position.x, _transformTile.position.y,
            (_transformTile.position.z - _speedTile * Time.deltaTime));
    }
}