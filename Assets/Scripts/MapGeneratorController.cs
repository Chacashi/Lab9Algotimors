using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneratorController : MonoBehaviour
{
    [SerializeField] private TextAsset txtMap;
    string[] arrayMapRows;
    string[] arrayMapColums;
    [SerializeField] GameObject MapPrefab;
    [SerializeField] Vector2 PositionIntial;
    [SerializeField] Vector2 separation;
    public Sprite[] arraySprites;

    private void Start()
    {
        OnDrawMap();
    }
    void OnDrawMap()
    {
        int index;
        GameObject currentMapPart;
        arrayMapRows = txtMap.text.Split("\n");
        for(int i = 0; i < arrayMapRows.Length; i++)
        {
            arrayMapColums = arrayMapRows[i].Split(";");
            for(int j = 0; j < arrayMapColums.Length; j++)
            {
                index = int.Parse(arrayMapColums[j]);
              

                currentMapPart = Instantiate(MapPrefab, new Vector2(PositionIntial.x + j * separation.x, 
                    PositionIntial.y - i * separation.y),transform.rotation);
                if (index == 0)
                {
                    currentMapPart.GetComponent<BoxCollider2D>().enabled = false;
                }
                currentMapPart.GetComponent<MapPartController>().SetSprite(arraySprites[index]);
                currentMapPart.transform.SetParent(this.transform);
            }
        }

        
    }




}
