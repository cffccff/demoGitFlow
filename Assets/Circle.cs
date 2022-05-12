using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float speed = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vertical_change = Input.GetAxis("Vertical");
        float horizontal_change = Input.GetAxis("Horizontal");
        Vector2 pos = transform.position;
        pos.y += vertical_change * Time.deltaTime;
        pos.x += horizontal_change * Time.deltaTime;
        transform.position = pos;
    }
}
