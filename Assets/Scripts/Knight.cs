using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessFigure
{
    // Start is called before the first frame update
    void Awake()
    {
        pieceWeight = 200;
        pieceStartCount = 2;

        pieceStartPos.Add(2);
        pieceStartPos.Add(7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
