using System.Collections;
using UnityEngine;

public class GetComponentTest : MonoBehaviour
{
    public BoxCollider bc;
    public SphereCollider sc;
    public float scRadius = 10f;
    public EnemyOne enemyOne;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sc = GetComponentInChildren<SphereCollider>();
        enemyOne = GameObject.FindAnyObjectByType<EnemyOne>();
        StartCoroutine(Timer());
    }

    public IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log((int)Time.time);
        }
    }

    // Update is called once per frame
    void Update()
    {
        sc.radius = scRadius;
        Timer();
    }
}
