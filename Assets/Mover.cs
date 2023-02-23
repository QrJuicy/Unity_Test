using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float num = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float movSpeed = num * Time.deltaTime *Input.GetAxis("Vertical");
        transform.Translate(movSpeed, 0, 0);
    }
}
