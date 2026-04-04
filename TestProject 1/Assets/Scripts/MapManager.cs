using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public static MapManager instance;

    private void Awake()
    {
        instance = this;
    }

    //关卡信息列表
    public List<LevelConfig> LevelConfigs;

    //当前关卡瓦片坐标列表
    private List<Vector3> TilePositions = new();

    //当前场景中激活的瓦片物体列表
    private List<GameObject> activeTiles = new();

    [Header("矿石偏移量")]
    public float offsetRange;

    //创建地图
    public void CreatMap()
    {
        LoadLevel(LevelConfigs[GameManager.instance.CurrentLevelIndex]);
        LoadTiles();
    }

    //清除地图
    public void ClearMap()
    {
        ClearTiles();
    }

    /// <summary>
    /// ������Ƭλ�������б�����
    /// </summary>
    /// <param name="config"></param>
    public void LoadLevel(LevelConfig config)
    {
        TilePositions.Clear();

        float totalWidth = (config.mapWidth - 1) * config.tileSpacing;
        float totalHeight = (config.mapHeight - 1) * config.tileSpacing;

        for (int row = 0; row < config.mapHeight; row++)
        {
            for (int col = 0; col < config.mapWidth; col++)
            {
                int index = row * config.mapWidth + col;
                if (config.mapLayout[index] == 1)
                {
                    float x = col * config.tileSpacing - totalWidth / 2f;
                    float y = -(row * config.tileSpacing - totalHeight / 2f);
                    TilePositions.Add(new Vector3(x, y, 0));
                }
            }
        }
    }

    /// <summary>
    /// �����ʯλ�÷���
    /// </summary>
    /// <param name="offsetRange"></param>
    /// <returns></returns>
    public Vector3 GetRandomSpawnPos()
    {
        Vector3 tile = TilePositions[Random.Range(0, TilePositions.Count)];
        tile.x += Random.Range(-offsetRange, offsetRange);
        tile.y += Random.Range(-offsetRange, offsetRange);
        return tile;
    }

    /// <summary>
    /// �����б��������ŵ�ͼ����
    /// </summary>
    public void LoadTiles()
    {
        for (int i = 0; i < TilePositions.Count; i++)
        {
            GameObject tile = ObjectPool.instance.Get(ObjectPool.instance.prefabs[3], TilePositions[i]);
            tile.GetComponent<SpriteRenderer>().sortingOrder = -(int)(TilePositions[i].y * 100);
            activeTiles.Add(tile);
        }
    }

    public void ClearTiles()
    {
        for (int i = activeTiles.Count - 1; i >= 0; i--)
        {
            ObjectPool.instance.Release(activeTiles[i]);
        }
        activeTiles.Clear();
    }

}
