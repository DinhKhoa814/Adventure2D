using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private GameObject cam;
    [SerializeField] private float parallaxEffect;
    private float xPosition;
    private float length;
    private void Start()
    {
        cam = GameObject.Find("Main Camera");
        length = GetComponent<SpriteRenderer>().bounds.size.x;//do rong cua background
        xPosition = transform.position.x;
    }
    private void Update()
    {
        float distanceMoved = cam.transform.position.x *(1 - parallaxEffect);
        float distanceToMove = cam.transform.position.x * parallaxEffect;
        transform.position = new Vector3(xPosition + distanceToMove, transform.position.y);
        if (distanceMoved > xPosition + length) xPosition += length;//sang phai
        else if (distanceMoved < xPosition - length) xPosition -= length;//sang trai
    }
}
