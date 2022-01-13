using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bishop : ChessFigure
{
    // Start is called before the first frame update
    void Awake()
    {
        pieceWeight = 300;
        pieceStartCount = 2;

        pieceStartPos.Add(3);
        pieceStartPos.Add(6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
