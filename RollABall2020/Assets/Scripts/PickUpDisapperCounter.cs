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

    private void Update()
    {
        if (colliderReceiveAction == null)
        {
            return;
        }

        if (colliderReceiveAction.IsTriggerEnter)
        {
            DissapperCount++;
            PickUpCountPresenter.CountDisplay(DissapperCount);
        }
    }
}
