using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class RotateCube : MonoBehaviour, IInputClickHandler
{
    public GameObject cube;

    private bool isRotating = false;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        isRotating = !isRotating;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
            cube.transform.Rotate(new Vector3(5, 10, 4));
    }
}
