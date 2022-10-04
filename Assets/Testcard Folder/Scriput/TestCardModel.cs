using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//カードデータそのものとその処理
public class TestCardModel
{
    public string name;
    public int hp;
    public int at;
    public int cost;
    public Sprite icon;

    public TestCardModel(int cardID)
    {
        TestCardEntity testCardEntity = Resources.Load<TestCardEntity>("TestCardList/TestCardEntity"+cardID);
        name = testCardEntity.name;
        hp = testCardEntity.hp;
        at = testCardEntity.at;
        cost = testCardEntity.cost;
        icon = testCardEntity.icon;
    }
}
