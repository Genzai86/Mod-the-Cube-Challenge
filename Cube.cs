using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour 
{ 
    private Renderer renderer;
    public Vector3 startPosition, scaleChange;
    public float Ropacity = 0.5f;
    public float Yopacity = 0.5f;
    private float rotationTime = 6;
    private float rotationDuration = 3f;
    public float rotationSpeed = 50;

    void Start() 
    {
        transform.position = startPosition;
        transform.localScale = scaleChange;
        renderer = GetComponent<Renderer>();
    }

    //When cursor enter on gameobject it turns red.
    private void OnMouseEnter()
    {
        // Color: (r,g,b,opacity) Red
        renderer.material.color = new Color(1, 0, 0, Ropacity);
    }
    //When cursor go out out from gameobject it turns yellow.
    private void OnMouseExit()
    {
        // Color: (r,g,b,opacity) Yellow Si son valores decimales se añade "f"
        renderer.material.color = new Color(1, 0.92f, 0.016f, Yopacity);
       
    }
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);

        //Each time scene is played the value of rotation speed change randomly.
        if (rotationTime > rotationDuration)

        {
            rotationSpeed = Random.Range(20, 200);
            rotationTime = 0;
        }
    }

}
