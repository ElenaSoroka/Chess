using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChessFigure
{
    // Start is called before the first frame update
    void Awake()
    {
        pieceWeight = 1000;
        pieceStartCount = 1;

        pieceStartPos.Add(4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
