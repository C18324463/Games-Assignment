using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5f;
    public float rotSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float c = Input.GetAxis("Vertical") * speed;
        float r = Input.GetAxis("Horizontal") * speed;
        transform.Translate(new Vector3(r, 0, c) * Time.deltaTime);
    }
}
