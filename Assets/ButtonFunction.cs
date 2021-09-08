using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{
    public BallMovement _ball;
    public GameObject _panel;
    public void Pause()
    {
        if (!_panel.active)
        {
            _panel.SetActive(true);
            _ball._paused = true;
        }
        else
        {
            _panel.SetActive(false);
            _ball._paused = false;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
