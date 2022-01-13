using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessFigure
{
    // Start is called before the first frame update
    void Awake()
    {
        pieceWeight = 100;
        pieceStartCount = 2;

        pieceStartPos.Add(1);
        pieceStartPos.Add(8);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
