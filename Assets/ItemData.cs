using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("自作ファイル/NormalEvent"), fileName = ("NormalEvent"))]
public class ItemData : ScriptableObject
{
    [TextArea}  public bool isUseMessage;
    public string messageText;
}
