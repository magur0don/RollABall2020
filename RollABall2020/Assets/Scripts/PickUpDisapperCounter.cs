using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDisapperCounter : MonoBehaviour
{
    /// <summary>
    /// 自分が消えたカウント
    /// </summary>
    public int DissapperCount { get; private set; } = 0;

    /// <summary>
    /// UnityEditorで設定するColliderReceiveAction
    /// </summary>
    [SerializeField] private ColliderReceiveAction colliderReceiveAction = null;

    private PickUpDisposition m_pickUpDisposition = null;

    private void Start()
    {
        m_pickUpDisposition = GetComponent<PickUpDisposition>();
        switch (m_pickUpDisposition.m_pickUpDisposition)
        {
            case PickUpDisposition.PickUpDisopsition.None:
                DissapperCount = 1;
                break;
            case PickUpDisposition.PickUpDisopsition.SpeedUp:
                DissapperCount = 2;
                break;
            case PickUpDisposition.PickUpDisopsition.SpeedDown:
                DissapperCount = 3;
                break;
            case PickUpDisposition.PickUpDisopsition.QTE:
                DissapperCount = 10;
                break;
        }
    }

    private void Update()
    {
        if (colliderReceiveAction == null)
        {
            return;
        }

        if (colliderReceiveAction.IsTriggerEnter)
        {
            PickUpCountPresenter.CountDisplay(DissapperCount);
        }
    }
}
