using System;
using UnityEngine;

public enum BLOCK_TYPE
{
    BLOCK_1,
    BLOCK_2,
    BLOCK_3,
    BLOCK_4,
    BLOCK_5
}

[Serializable]
public class BlockData
{
    public BLOCK_TYPE type;
    public GameObject obj;
}
