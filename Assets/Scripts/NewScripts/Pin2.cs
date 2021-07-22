using UnityEngine;
using UnityEngine.UI;

public class Pin2 : MonoBehaviour
{
    [SerializeField] private Text pin;
    [SerializeField] private int minPinPosition = 0;
    [SerializeField] private int winPinPosition = 5;
    [SerializeField] private int maxPinPosition = 10;
    
    private int position;

    public bool IsUnlocked => position == winPinPosition;

    public void Mix()
    {
        var newPosition = 0; //GenerateLockedPinPosition();
        UpdatePosition(newPosition);
    }

    public void Change(int value)
    {
        var newPosition = position + value;
        UpdatePosition(newPosition);
    }

    /*private int GenerateLockedPinPosition()
    {
        var newPosition = Random.Range(minPinPosition, maxPinPosition);
        return newPosition >= winPinPosition ? newPosition + 1 : newPosition;
    }*/

    private void UpdatePosition(int newPosition)
    {
        SetClanpedPosition(newPosition);
        UpdatePinView();
    }

    private void SetClanpedPosition(int newPosition)
    {
        position = Mathf.Clamp(newPosition, minPinPosition, maxPinPosition);
    }

    private void UpdatePinView()
    {
        pin.text = position.ToString();
    }
}
