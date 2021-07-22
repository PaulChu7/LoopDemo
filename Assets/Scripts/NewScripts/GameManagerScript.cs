using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] private Canvas toolsCanvas;
    [SerializeField] private Text conditionText;
    [SerializeField] private Canvas finalCanvas;
    [SerializeField] private Text finalMessage;
    [SerializeField] private Timer timer;
    [SerializeField] private DoorLockScript doorLock;
    [SerializeField] private float levelDuration = 10f;
    private bool IsGamePlay;
    
    private void Awake()
    {
        Init();
        NewGame();
    }

    private void Init()
    {
        conditionText.text = "Для того чтобы выбраться из западни, установи все пины на отметку 5";
    }

    private void Update()
    {
        if (IsGamePlay)
        {
            GamePlayTrick();
        }
    }

    private void GamePlayTrick()
    {
        if (doorLock.IsUnlocked)
        {
            PlayerWin();
        }
        else if (timer.IsTimeOver())
        {
            PlayerLost();
        }
    }

    public void NewGame()
    {
        timer.Restart(levelDuration);
        doorLock.Lockup();
        SwitchToPlayCanvasState();
    }

    private void PlayerWin()
    {
        SwitchToFinalState("Поздравляю! \nТы выбрался! Но на долго ли?");
    }
    
    private void PlayerLost()
    {
        SwitchToFinalState("Time to die! \n Это никогда не закончится, Бэн!");
    }

    private void SwitchToPlayCanvasState()
    {
        IsGamePlay = true;
        toolsCanvas.enabled = true;
        finalCanvas.enabled = false;
    }

    private void SwitchToFinalState(string message)
    {
        IsGamePlay = false;
        toolsCanvas.enabled = false;
        finalCanvas.enabled = true;
        finalMessage.text = message;
    }

    public void OnClickResetButton()
    {
        NewGame();
    }
}
