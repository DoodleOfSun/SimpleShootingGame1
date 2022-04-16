using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{

    public float playerSpeed = 5;
    private Vector3 moveVec = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMove(InputValue input)
    {
        Vector2 inputVec = input.Get<Vector2>();
        // moveVec = new Vector3(inputVec.x, 0, inputVec.y);
        moveVec = new Vector3(inputVec.x, inputVec.y, 0);
    }

    
    void OnMove()
    {
        // float h = Input.GetAxis("Horizontal");
        // float v = Input.GetAxis("Vertical");

    }

    // Update is called once per frame
    void Update()
    {

        // Vector3 dir = new Vector3(h,v,0);
        
        transform.position += moveVec * playerSpeed * Time.deltaTime;
    }
}
