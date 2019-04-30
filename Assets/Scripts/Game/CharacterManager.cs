using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Org.Ivan.Dungeons.Commmon;

/// <summary>
/// 管理所有角色資料
/// </summary>
/// <typeparam name="CharacterManager"></typeparam>
public class CharacterManager : InstanceBase<CharacterManager>
{
    /// <summary>
    /// 所有角色資料
    /// </summary>
    private Dictionary<long, Character> _characters;

    public void DebugAddCharacter()
    {
        Character c1 = new Character(1, 10, 1);
        AddCharacter(c1);

        Character c2 = new Character(2, 8, 2);
        AddCharacter(c2);
    }

    /// <summary>
    /// 新增一名角色
    /// </summary>
    /// <param name="character">要新增的角色資料</param>
    public void AddCharacter(Character character)
    {
        if (character == null)
        {
            Debug.LogError($"character is null");
            return;
        }

        if (_characters == null)
            _characters = new Dictionary<long, Character>();

        if (_characters.ContainsKey(character.Id))
        {
            Debug.LogError($"duplicate add character(id={character.Id})");
            return;
        }

        _characters.Add(character.Id, character);
    }

    /// <summary>
    /// 取得角色資料
    /// </summary>
    /// <param name="id">角色id</param>
    /// <returns></returns>
    public Character GetCharacter(long id)
    {
        if (_characters == null)
            return null;

        return _characters[id];
    }
}
