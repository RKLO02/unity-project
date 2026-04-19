using System;
using Unity.Mathematics;
using UnityEngine;


public class Dog : Animal
{
    private int iq;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cat cat1 = new Cat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeIQ(int newIQ)
    {
        iq = (int)Mathf.Clamp(newIQ, 0f, 200f);
        Debug.Log("IQ changed!");
    }

    override public void Speak()
    {
        Debug.Log("Woof!");
    }
}
