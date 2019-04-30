using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    /// <summary>
    /// 玩家id
    /// </summary>
    public long _id;
    /// <summary>
    /// hp的文字
    /// </summary>
    public Text _hp;

    private Character _character;

    // Start is called before the first frame update
    void Start()
    {
        _character = CharacterManager.Instance.GetCharacter(_id);
        if (_character == null)
        {
            Debug.LogError($"character is null.(id={_id})");
            return;
        }

        if (_hp != null)
        {
            _hp.text = _character.Hp.ToString();
        }
    }
}