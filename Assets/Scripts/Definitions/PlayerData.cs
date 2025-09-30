using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData
{
    [SerializeField]
    public int moves;
    [SerializeField]
    public int score;
    public int blocks;

    public List<BlockData> blocksConfig;
}
