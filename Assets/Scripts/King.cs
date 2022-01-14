using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class King : ChessFigure
{
    // Start is called before the first frame update
    void Awake()
    {
        pieceWeight = 10000;
        pieceStartCount = 1;

        pieceStartPos.Add(5);
        PossibleMoves();
    }

    //private void OnMouseDown()
    //{
    //    Debug.Log("mouse king");

    //}

    public override void PossibleMoves() // POLYMORPHISM
    {
        motionVector.Add(new Vector2(1, 0));
        motionVector.Add(new Vector2(1, 1));
        motionVector.Add(new Vector2(0, 1));
        motionVector.Add(new Vector2(-1, 0));
        motionVector.Add(new Vector2(-1, -1));
        motionVector.Add(new Vector2(0, -1));
        motionVector.Add(new Vector2(-1, 1));
        motionVector.Add(new Vector2(1, -1));
    }
}
