using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float playerMoveSpeed;
    [SerializeField] float playerRotateSpeed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * playerMoveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) )
        {
            transform.Rotate(-Vector3.up, playerRotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, playerRotateSpeed * Time.deltaTime );
        }


    }
}
