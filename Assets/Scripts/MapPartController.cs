using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPartController : MonoBehaviour
{
    SpriteRenderer _compSpriteRendere;

    private void Awake()
    {
        _compSpriteRendere = GetComponent<SpriteRenderer>();
    }
    public void SetSprite(Sprite newSprite)
    {
        _compSpriteRendere.sprite = newSprite;
    }
}
