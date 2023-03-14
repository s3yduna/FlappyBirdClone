using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    
    [SerializeField]
    float pipeSpeed;

    private void Start()
    {
        Destroy(gameObject, 9);
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime;
    }




}
