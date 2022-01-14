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
        PossibleMoves();
    }

    public override void PossibleMoves()
    {
        motionVector.Add(new Vector2(7, 7));
        motionVector.Add(new Vector2(6, 6));
        motionVector.Add(new Vector2(5, 5));
        motionVector.Add(new Vector2(4, 4));
        motionVector.Add(new Vector2(3, 3));
        motionVector.Add(new Vector2(2, 2));
        motionVector.Add(new Vector2(1, 1));

        motionVector.Add(new Vector2(-7, 7));
        motionVector.Add(new Vector2(-6, 6));
        motionVector.Add(new Vector2(-5, 5));
        motionVector.Add(new Vector2(-4, 4));
        motionVector.Add(new Vector2(-3, 3));
        motionVector.Add(new Vector2(-2, 2));
        motionVector.Add(new Vector2(-1, 1));

        motionVector.Add(new Vector2(7, -7));
        motionVector.Add(new Vector2(6, -6));
        motionVector.Add(new Vector2(5, -5));
        motionVector.Add(new Vector2(4, -4));
        motionVector.Add(new Vector2(3, -3));
        motionVector.Add(new Vector2(2, -2));
        motionVector.Add(new Vector2(1, -1));

        motionVector.Add(new Vector2(-7, -7));
        motionVector.Add(new Vector2(-6, -6));
        motionVector.Add(new Vector2(-5, -5));
        motionVector.Add(new Vector2(-4, -4));
        motionVector.Add(new Vector2(-3, -3));
        motionVector.Add(new Vector2(-2, -2));
        motionVector.Add(new Vector2(-1, -1));

    }
}
