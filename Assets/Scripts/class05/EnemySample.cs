using UnityEngine;

public class EnemySample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerSample.instance != null)
        {
            PlayerSample.instance.onPlayerDeath += Laugh;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Laugh()
    {
        Debug.Log("HAHA");
    }

    private void OnDestroy()
    {
        PlayerSample.instance.onPlayerDeath -= Laugh;
    }
}
