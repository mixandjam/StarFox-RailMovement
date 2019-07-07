using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool active;
    public GameObject gameCamera;
    public GameObject extraCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            active = !active;
            GameCamera(active);
        }
    }

    void GameCamera(bool state)
    {
        gameCamera.SetActive(!state);
        extraCamera.SetActive(state);
    }
}
