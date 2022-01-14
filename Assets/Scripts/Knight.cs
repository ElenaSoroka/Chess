using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Knight : ChessFigure
{
    // Start is called before the first frame update
    void Awake()
    {
        pieceWeight = 200;
        pieceStartCount = 2;

        pieceStartPos.Add(2);
        pieceStartPos.Add(7);
        PossibleMoves();
    }

    public override void PossibleMoves() // POLYMORPHISM
    {
        motionVector.Add(new Vector2(2, 1));
        motionVector.Add(new Vector2(2, -1));
        motionVector.Add(new Vector2(-2, 1));
        motionVector.Add(new Vector2(-2, -1));
        motionVector.Add(new Vector2(1, 2));
        motionVector.Add(new Vector2(1, -2));
        motionVector.Add(new Vector2(-1, 2));
        motionVector.Add(new Vector2(-1, -2));
    }
}
