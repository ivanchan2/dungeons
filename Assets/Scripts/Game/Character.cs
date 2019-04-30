using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 角色資料
/// </summary>
public class Character
{
    /// <summary>
    /// id
    /// </summary>
    private long _id;
    /// <summary>
    /// hp
    /// </summary>
    private long _hp;
    /// <summary>
    /// atk
    /// </summary>
    private int _atk;

    /// <summary>
    /// id
    /// </summary>
    /// <value></value>
    public long Id { get { return _id; } }
    /// <summary>
    /// hp
    /// </summary>
    /// <value></value>
    public long Hp { get { return _hp; } }
    /// <summary>
    /// atk
    /// </summary>
    /// <value></value>
    public int Atk { get { return _atk; } }

    public Character(long id, long hp, int atk)
    {
        _id = id;
        _hp = hp;
        _atk = atk;
    }
}
