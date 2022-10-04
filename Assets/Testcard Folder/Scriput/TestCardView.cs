using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCardView : MonoBehaviour
{
   [SerializeField, Tooltip("見える名前")] Text nameText;
   [SerializeField, Tooltip("見えるHP")] Text hpText;
   [SerializeField, Tooltip("見えるAT")] Text atText;
   [SerializeField, Tooltip("見えるコスト")] Text costText;
   [SerializeField, Tooltip("見えるアイコン")] Image iconImage;

    /// <summary>
    /// カードを表示する
    /// </summary>
    public void Show(TestCardModel testCardModel)
    {
        nameText.text = testCardModel.name;
        hpText.text = testCardModel.hp.ToString();
        atText.text = testCardModel.at.ToString();
        costText.text = testCardModel.cost.ToString();
        iconImage.sprite = testCardModel.icon;
    }
}
