using UnityEngine;
using UnityEngine.Events;

public class PlayerWithUnityEvent : MonoBehaviour
{
    public UnityEvent OnPlayerDeath;

    private bool isDead = false;

    public void Die()
    {
        if (isDead) return;

        isDead = true;

        Debug.Log("Player died");

        OnPlayerDeath?.Invoke();
    }
}