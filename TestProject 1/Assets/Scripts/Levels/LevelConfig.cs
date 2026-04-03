using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Level/LevelConfig")]
public class LevelConfig : ScriptableObject
{
    public int mapWidth = 5;
    public int mapHeight = 5;
    public int[] mapLayout;
    public float tileSpacing = 1f;
    public float rockOffsetRange = 0.3f;
    public int rockCount = 10;

    public void InitLayout()
    {
        mapLayout = new int[mapWidth * mapHeight];
        for (int i = 0; i < mapLayout.Length; i++)
            mapLayout[i] = 1; // 默认全部有瓦片
    }
}
