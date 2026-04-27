using UnityEngine;
using UnityEngine.Events;

public class UnityActionExample : MonoBehaviour
{
    UnityAction onPlayerDeath;

    void Start()
    {
        onPlayerDeath += ShowMessage;
        onPlayerDeath?.Invoke();
    }

    void ShowMessage()
    {
        Debug.Log("UnityAction called");
    }
}