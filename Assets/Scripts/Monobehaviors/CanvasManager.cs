using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI moves;
    public GameObject gameOverCanvas;
    public GameObject gridLayout;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverCanvas.SetActive(false);
        score.text = PlayerManager.Instance.score.ToString();
        moves.text = PlayerManager.Instance.moves.ToString();
        PlayerManager.Instance.MoveUpdate += UpdateMoves;
        PlayerManager.Instance.ScoreUpdate += UpdateScore;
        PlayerManager.Instance.ResetUpdate += UpdateReset;
        PlayerManager.Instance.OnGameOver += OnGameOver;
    }

    void UpdateScore(int value)
    {
        score.text = value.ToString();
    }

    void UpdateMoves(int value)
    {
        moves.text = value.ToString();
    }

    void UpdateReset(int score, int moves)
    {
        UpdateScore(score);
        UpdateMoves(moves);
        gameOverCanvas.SetActive(false);
    }

    void OnGameOver()
    {
        gameOverCanvas.SetActive(true);
    }


    // Here I would start intantiating based on GameManagers dictionary, all prefabs of the cubes
    // Unfortunatelly I lost quite a few time handling memory problems on my personal machine which took
    // me quite the time
    void Instantiate()
    {
        
    }
}
