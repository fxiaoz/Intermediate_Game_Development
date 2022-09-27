using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public Transform newPosition;
    private CameraController _cameraController;

    // Start is called before the first frame update
    void Start()
    {
        _cameraController = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Debug.Log("wow");
            _cameraController.ChangeTarget(newPosition);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
}
