using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDamage : MonoBehaviour
{
    private SphereStates m_sphereStates = null;

    private void Awake()
    {
        m_sphereStates = GetComponent<SphereStates>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            m_sphereStates.SphereHp--;
        }
    }
}
