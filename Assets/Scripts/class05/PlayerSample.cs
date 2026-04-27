using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public delegate int PlayerDeathHandler(int num);

public class PlayerSample : MonoBehaviour
{
    public static PlayerSample instance;
    public PlayerDeathHandler onDeath;
    public Action onPlayerDeath;
    public Func<int,int> onPlayerDeathFunc;
    public event Action onPlayerDeathEvent;

    public UnityAction uAction;
    public UnityEvent uEvent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(this);
        }

    }

    private void Start()
    {
        StartCoroutine(Die());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(0.5f);
        onPlayerDeath();
        /*
        var enemies = GameObject.FindGameObjectsWithTag("enemy");
        foreach (Object eobj in enemies)
        { 
            EnemySample enemy = (EnemySample)eobj;
            enemy.Laugh();
        }
        */
    }

    void DiedAgain()
    { }
}
