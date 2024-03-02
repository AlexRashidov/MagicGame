using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    void Start()
    {
        player = GameObject.FindGameObject("Player").transform;
    }

}
