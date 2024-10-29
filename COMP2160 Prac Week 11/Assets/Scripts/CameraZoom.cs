using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraZoom : MonoBehaviour
{
    private Actions actions;
    private InputAction mouseScrollAction;
    [SerializeField] private float zoomAmount = 2f;
    private float orthZoomAmount;
    
    void Awake() 
    {
        actions = new Actions();
        mouseScrollAction = actions.camera.zoom;

        orthZoomAmount = zoomAmount / 10;
    }

    void OnEnable()
    {
        mouseScrollAction.Enable();
    }

    void OnDisable()
    {
        mouseScrollAction.Disable();
    }

    void Update()
    {
        float mouseScroll = mouseScrollAction.ReadValue<float>();
        Debug.Log("Mouse Scroll: " + mouseScroll);

        if (mouseScroll < 0) //Zoom in 
        {
            Camera.main.fieldOfView += zoomAmount;
            Camera.main.orthographicSize += orthZoomAmount;
        }
        else if (mouseScroll > 0)
        {
            Camera.main.fieldOfView -= zoomAmount;
            Camera.main.orthographicSize -= orthZoomAmount;
        }
    }
}
