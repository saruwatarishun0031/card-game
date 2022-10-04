using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCardcontroller : MonoBehaviour
{
    TestCardView view; //見かけ（view）に関することを操作
    TestCardModel model;//データ（model）に関することの操作

    private void Awake()
    {
        view = GetComponent<TestCardView>();
    }

    public void Init(int cardID)
    {
        model = new TestCardModel(cardID);
        view.Show(model);
    }
}
