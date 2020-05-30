using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class PickUpCountPresenter : MonoBehaviour
{
    [SerializeField] private Text pickUpCountText = null;

    private static int pickUpCounter = 0;

    /// <summary>
    /// 外部からPickUPCounterを取得したい場合
    /// </summary>
    public int GetPickUpCount
    {
        get { return pickUpCounter; }
    }

    public void Update()
    {
        pickUpCountText.text = $"{pickUpCounter}";
    }

    /// <summary>
    /// 引数をPickUpCounterに加算する
    /// </summary>
    /// <param name="dissapperCount"></param>
    public static void CountDisplay(int dissapperCount)
    {
        pickUpCounter += dissapperCount;
    }
}
