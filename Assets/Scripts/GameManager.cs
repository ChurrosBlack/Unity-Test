using UnityEngine;

public class GameManager : MonoBehaviour
{
    public PlayerDataObject initialSetting;
    void Awake()
    {
        Reset();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void DecreaseMove()
    {
        PlayerManager.Instance.AddMove(-1);
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
