using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] float obstacleMoveSpeed;

    private void Update()
    {
        transform.Translate(Vector3.forward * obstacleMoveSpeed * Time.deltaTime);
    }
}
