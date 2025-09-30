using System;
using UnityEngine.Animations;

public class PlayerManager
{
    private static PlayerManager _instance;
    public static PlayerManager Instance => _instance ??= new PlayerManager();

    public int score;
    public int moves;

    public Action<int> ScoreUpdate;
    public Action<int> MoveUpdate;
    public Action<int, int> ResetUpdate;
    public Action OnGameOver;

    private PlayerManager() { } // Private constructor prevents external instantiation

    public void AddScore(int amount)
    {
        score += amount;
        if (score < 0) score = 0;
        ScoreUpdate?.Invoke(score);
    }

    public void AddMove(int count = 1)
    {
        moves += count;
        if (moves <= 0)
        {
            moves = 0;
            OnGameOver?.Invoke();
        }
        ;
        MoveUpdate?.Invoke(moves);
    }

    public void Reset(int score, int moves)
    {
        this.score = score;
        this.moves = moves;
        ResetUpdate?.Invoke(score, moves);
    }

    public void ResetPlayer()
    {
        score = 0;
        moves = 0;
    }
}