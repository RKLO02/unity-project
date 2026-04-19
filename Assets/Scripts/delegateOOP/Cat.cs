using UnityEngine;

public class Cat : Animal, IVehicle
{
    public int hunger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hp = 10;
        hunger = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void Speak()
    {
        Debug.Log("Meow!");
    }

    public void GetOn(int id)
    {
        Debug.Log(id.ToString() + "Got on meow");
    }

    public void GetOff(int id)
    {
        Debug.Log(id.ToString() + "Got off meow");
    }
}
