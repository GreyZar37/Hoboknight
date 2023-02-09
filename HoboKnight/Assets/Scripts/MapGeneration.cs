using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{

    public GameObject[] FourXThree;
    public GameObject[] SixXThree;
    public GameObject[] EightXThree;
    public GameObject[] TenXThree;

    int[,] HouseSizes = new int[,] { { 4, 3 }, { 6, 3 }, { 8, 3 }, { 10, 3 } };

    void Start()
    {
        print(HouseSizes[1, 2]);
    }

    void Update()
    {
        
    }
}
