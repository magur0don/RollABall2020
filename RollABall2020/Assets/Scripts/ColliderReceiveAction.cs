using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderReceiveAction : MonoBehaviour
{
    [SerializeField] private GameObject thisObject = null;

    public bool IsTriggerEnter = false;

    private void Awake()
    {
        thisObject = this.gameObject;
    }

    /// <summary>
    /// 当たったら自分のgameObjectを消す
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(TriggerEnter());
    }

    /// <summary>
    /// 1フレーム待つ
    /// </summary>
    /// <returns></returns>
    IEnumerator TriggerEnter()
    {
        IsTriggerEnter = true;
        yield return new WaitForEndOfFrame();
        thisObject.SetActive(false);
    }
}
