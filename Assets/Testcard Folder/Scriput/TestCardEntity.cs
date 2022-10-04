using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="TestCardEntity",menuName ="Create TestCardEntity")]
//カードデータそのもの
public class TestCardEntity : ScriptableObject
{
    public new string name;
    public int hp;
    public int at;
    public int cost;
    public Sprite icon;
}
