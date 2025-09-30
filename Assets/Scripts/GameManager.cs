using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerDataObject initialSetting;
    private Dictionary<BLOCK_TYPE, GameObject> blockPrefabDict;
    void Awake()
    {
        Reset();
        PlayerManager.Instance.GenerateRandomSequence(initialSetting.initialStats.blocks);
        blockPrefabDict = new Dictionary<BLOCK_TYPE, GameObject>();
        foreach (var pair in initialSetting.initialStats.blocksConfig)
        {
            if (!blockPrefabDict.ContainsKey(pair.type))
                blockPrefabDict.Add(pair.type, pair.obj);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void DecreaseMove()
    {
        PlayerManager.Instance.AddMove(-1);
    }

    public GameObject GetPrefab(BLOCK_TYPE type)
    {
        if (blockPrefabDict.TryGetValue(type, out var prefab))
            return prefab;
        return null;
    }

    public void IncreaseScore()
    {
        PlayerManager.Instance.AddScore(10);

    }

    public void Reset()
    {
        PlayerManager.Instance.Reset(initialSetting.initialStats.score, initialSetting.initialStats.moves);
   }
}
