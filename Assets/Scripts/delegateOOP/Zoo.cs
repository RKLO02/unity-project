using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    public int guestID;
    public List<Animal> animals = new List<Animal>();
    [SerializeReference]
    public List<IVehicle> vehicles = new List<IVehicle>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Animal anim in animals)
        {
            anim.Speak();
        }
        foreach (IVehicle vehi in vehicles)
        {
            vehi.GetOn(guestID);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
