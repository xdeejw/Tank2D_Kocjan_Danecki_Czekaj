using UnityEngine;
using UnityEngine.UI;


// Zarządzanie punktacją itd

public class GameManager : MonoBehaviour
{

    [Tooltip("The ball component.")]
    public Ball ball;


    [Tooltip("The player's paddle component.")]
    public Paddle playerPaddle;


    /// Aktualny wynik gracza

    public int playerScore { get; private set; }


    /// Wyświetlenie ilości punktów gracza

    [Tooltip("The UI text the displays the player's score.")]
    public Text playerScoreText;


    [Tooltip("The computer's paddle component.")]
    public Paddle computerPaddle;


    /// Aktualna ilość punktów komputera

    public int computerScore { get; private set; }


    /// Wyświetlenie ilości punktów komputera

    [Tooltip("The UI text the displays the computer's score.")]
    public Text computerScoreText;

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        // Reset gry po wciśnięciu 'R'
        if (Input.GetKeyDown(KeyCode.R)) {
            NewGame();
        }
    }

    public void NewGame()
    {
        // Reset punktów
        SetPlayerScore(0);
        SetComputerScore(0);

        
        StartRound();
    }

    public void StartRound()
    {
        // Reset pozycji obiektów
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();

        // Dodanie początkowej siły piłeczce
        this.ball.AddStartingForce();
    }

    public void PlayerScores()
    {
        // Dodanie punktu dla gracza
        // Rozpoczęcie kolejnej tury
        SetPlayerScore(this.playerScore + 1);
        StartRound();
    }

    public void ComputerScores()
    {
        // Dodanie punktu komputerowi
        // Rozpoczęcie kolejnej tury
        SetComputerScore(this.computerScore + 1);
        StartRound();
    }

    private void SetPlayerScore(int score)
    {
        // Aktualizacja wyświetlacza puntków gracza
        this.playerScore = score;
        this.playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        // Aktualizacja wyświetlacza puntków komputera
        this.computerScore = score;
        this.computerScoreText.text = score.ToString();
    }

}
