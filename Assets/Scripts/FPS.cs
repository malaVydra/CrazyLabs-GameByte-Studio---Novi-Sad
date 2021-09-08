using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPS : MonoBehaviour
{
    public TextMeshProUGUI _fps;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
}
