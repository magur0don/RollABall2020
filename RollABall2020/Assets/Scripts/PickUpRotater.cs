using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRotater : MonoBehaviour
{
    private Transform m_pickUpTransform = null;
    
    private void Start()
    {
        m_pickUpTransform = GetComponent<Transform>();
    }

    void Update()
    {
        m_pickUpTransform.Rotate(0,1,0, Space.Self);
    }
}
