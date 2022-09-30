using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerEGame : MonoBehaviour
{
    [SerializeField, Tooltip("カード")]
    GameObject _cardPrefab;
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
        Instantiate(_cardPrefab, _playerHandTransform, false);
    }
    
   
}
