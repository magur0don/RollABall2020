using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpColorChange : MonoBehaviour
{
    private PickUpDisposition m_pickUpDisposition = null;

    private Color SpeedUpColor = Color.red;
    private Color SpeedDownColor = Color.blue;
    private Color QTEColor = Color.magenta;

    void Start()
    {
        m_pickUpDisposition = GetComponent<PickUpDisposition>();

        var mat = GetComponent<MeshRenderer>().material;

        switch (m_pickUpDisposition.m_pickUpDisposition)
        {
            case PickUpDisposition.PickUpDisopsition.SpeedUp:
                mat.color = SpeedUpColor;
                break;
            case PickUpDisposition.PickUpDisopsition.SpeedDown:
                mat.color = SpeedDownColor;
                break;
            case PickUpDisposition.PickUpDisopsition.QTE:
                mat.color = QTEColor;
                break;
        }
    }
}
