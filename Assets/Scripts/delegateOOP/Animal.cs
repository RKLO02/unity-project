using UnityEngine;

abstract public class Animal : MonoBehaviour
{
    public int footStrength;
    public int hp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    virtual public void Speak()
    { 
        //SPEAK
    }
}
