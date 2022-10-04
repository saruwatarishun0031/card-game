using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGameManager: MonoBehaviour
{
    [SerializeField, Tooltip("カード")]
    TestCardcontroller _cardPrefab;
    [SerializeField, Tooltip("Playerの手札の位置")]
    Transform _playerHandTransform;
    
    void Start()
    {
        CreateCard(_playerHandTransform);
    }

    /// <summary>
    /// 手札にカードを生成
    /// </summary>
    /// <param name="hand"></param>
    void CreateCard(Transform hand)
    {
        TestCardcontroller card = Instantiate(_cardPrefab, hand, false);
        card.Init(1);
    }
    
   
}
