using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessFigure
{
    // Start is called before the first frame update
    void Awake()
    {
        pieceWeight = 10000;
        pieceStartCount = 1;

        pieceStartPos.Add(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
