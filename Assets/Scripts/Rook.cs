using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Rook : ChessFigure
{
    // Start is called before the first frame update
    void Awake()
    {
        pieceWeight = 100;
        pieceStartCount = 2;

        pieceStartPos.Add(1);
        pieceStartPos.Add(8);
        PossibleMoves();
    }

    public override void PossibleMoves() // POLYMORPHISM
    {
        motionVector.Add(new Vector2(7, 0));
        motionVector.Add(new Vector2(6, 0));
        motionVector.Add(new Vector2(5, 0));
        motionVector.Add(new Vector2(4, 0));
        motionVector.Add(new Vector2(3, 0));
        motionVector.Add(new Vector2(2, 0));
        motionVector.Add(new Vector2(1, 0));

        motionVector.Add(new Vector2(-7, 0));
        motionVector.Add(new Vector2(-6, 0));
        motionVector.Add(new Vector2(-5, 0));
        motionVector.Add(new Vector2(-4, 0));
        motionVector.Add(new Vector2(-3, 0));
        motionVector.Add(new Vector2(-2, 0));
        motionVector.Add(new Vector2(-1, 0));

        motionVector.Add(new Vector2(0, 7));
        motionVector.Add(new Vector2(0, 6));
        motionVector.Add(new Vector2(0, 5));
        motionVector.Add(new Vector2(0, 4));
        motionVector.Add(new Vector2(0, 3));
        motionVector.Add(new Vector2(0, 2));
        motionVector.Add(new Vector2(0, 1));

        motionVector.Add(new Vector2(0, -7));
        motionVector.Add(new Vector2(0, -6));
        motionVector.Add(new Vector2(0, -5));
        motionVector.Add(new Vector2(0, -4));
        motionVector.Add(new Vector2(0, -3));
        motionVector.Add(new Vector2(0, -2));
        motionVector.Add(new Vector2(0, -1));

    }
}
