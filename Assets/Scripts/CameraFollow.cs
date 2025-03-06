using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // kameran�n takip etmesi i�in karakteri target yapma
    public Vector3 offset; //dengeleme
    [SerializeField] 
    private float smoothSpeed; //yumu�atma

    void LateUpdate() 
    {
        Vector3 desiredPosition = target.position + offset; //target etraf�nda offset ile kamera konumunu hesaplama

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); //smoothlama
        transform.position = smoothedPosition;

    }
}
