using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Queen : ChessFigure
{
    // Start is called before the first frame update
    void Awake()
    {
        pieceWeight = 1000;
        pieceStartCount = 1;

        pieceStartPos.Add(4);
        PossibleMoves();
    }


    // Update is called once per frame
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
