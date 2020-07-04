using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDisposition : MonoBehaviour
{
    public enum PublicPickUpDisposition
    {
        None = 0,       //何もない
        SpeedUp,        //加速する
        SpeedDown,      //減速する
        QTE,            //QTEが始まる
        DispositionMax  //性質数のMAX
    }
    
    public PublicPickUpDisposition m_pickUpDisposition = PublicPickUpDisposition.None;

    private void Awake()
    {
        var randomDisposition = 0;

        randomDisposition = Random.Range((int)PublicPickUpDisposition.None, (int)PublicPickUpDisposition.DispositionMax);

        m_pickUpDisposition = (PublicPickUpDisposition)randomDisposition;
    }
}
