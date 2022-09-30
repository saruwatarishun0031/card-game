using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ECardEntity",menuName ="Create ECardEntity")]
//カードデータそのもの
public class ECardEntity : ScriptableObject
{
    public new string name;
    public int hp;
    public int st;
    public int cost;
    public Sprite icon;
}
