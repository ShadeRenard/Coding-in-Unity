using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenetest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyUtilities utils = new MyUtilities();
        utils.AddValues(2, 3);
        print("2 + 3 = " + utils.c);
    }

    // Update is called once per frame
    void Update()
    {
        print(MyUtilities.GenerateRandom(0, 100));
    }
}
