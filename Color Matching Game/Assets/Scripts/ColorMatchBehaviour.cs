using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehaviour : MatchBehaviour
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
