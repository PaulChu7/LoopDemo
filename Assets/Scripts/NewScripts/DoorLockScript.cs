using UnityEngine;

public class DoorLockScript : MonoBehaviour
{
    [SerializeField] private Pin pin1;
    [SerializeField] private Pin pin2;
    [SerializeField] private Pin pin3;

    public bool IsUnlocked => pin1.IsUnlocked && pin2.IsUnlocked && pin3.IsUnlocked;

    public void Lockup()
    {
        pin1.Mix();
        pin2.Mix();
        pin3.Mix();
    }

    public void ChangeState(int value1, int value2, int value3)
    {
        pin1.Change(value1);
        pin2.Change(value2);
        pin3.Change(value3);
    }
}
