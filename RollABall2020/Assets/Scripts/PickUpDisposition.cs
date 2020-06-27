using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDisposition : MonoBehaviour
{
    public enum PickUpDisopsition
    {
        None = 0,       //何もない
        SpeedUp,        //加速する
        SpeedDown,      //減速する
        QTE,            //QTEが始まる
        DispositionMax  //性質数のMAX
    }
    
    public PickUpDisopsition m_pickUpDisposition = PickUpDisopsition.None;

    private void Awake()
    {
        var randomDisposition = 0;

        randomDisposition = Random.Range((int)PickUpDisopsition.None, (int)PickUpDisopsition.DispositionMax);

        m_pickUpDisposition = (PickUpDisopsition)randomDisposition;
    }
}
