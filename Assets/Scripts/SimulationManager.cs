using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationManager : MonoBehaviour
{
    public GameObject[] simulationObjects;

    void Awake()
    {
        foreach (var simObj in simulationObjects)
        {
            simObj.SetActive(false);
        }
    }

    void Update()
    {
        
    }

    [Button("Enable Simulation")]
    void EnableSimulation()
    {
        foreach (var simObj in simulationObjects)
        {
            simObj.SetActive(true);
        }
    }
}
