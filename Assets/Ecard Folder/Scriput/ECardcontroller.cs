using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECardcontroller : MonoBehaviour
{
    //見かけ（view）に関することを操作
    CardModel model;//データ（model）に関することの操作

    public void Init()
    {
        model = new CardModel();
    }
}
