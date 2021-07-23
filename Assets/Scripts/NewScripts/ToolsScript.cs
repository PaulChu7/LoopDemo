using UnityEngine;
using UnityEngine.UI;

public class ToolsScript : MonoBehaviour
{
    [SerializeField] private DoorLockScript doorLock;
    [Header("Tools")]
    [SerializeField, Range(-10, 10)] private int pin1;
    [SerializeField, Range(-10, 10)] private int pin2;
    [SerializeField, Range(-10, 10)] private int pin3;

    public void OnClickToolsButton()
    {
        doorLock.ChangeState(pin1, pin2, pin3);
    }
}