using UnityEngine;
using UnityEngine.UI;

public class ClearPresenter : MonoBehaviour
{
    [SerializeField] private Text clearText = null;

    [SerializeField] private PickUpCountPresenter pickUpCountPresenter = null;

    private void Start()
    {
        // 最初文字は消しておく
        clearText.text = string.Empty;
    }


    void Update()
    {
        if (pickUpCountPresenter.GetPickUpCount.Equals(12))
        {
            clearText.text = " クリアー";
        }
    }
}
