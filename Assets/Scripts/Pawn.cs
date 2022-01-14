using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ChessFigure
{
    int rowWhite;
    int rowWhitePawn;
    int rowBlack;
    int rowBlackPawn;

    // Start is called before the first frame update
    void Awake()
    {
        pieceWeight = 10;
        pieceStartCount = 8;

        for (int i = 1; i <= pieceStartCount; i++)
        {
            pieceStartPos.Add(i);
        }
        PossibleMoves();
    }

    public override void PossibleMoves()
    {
        //я упростила для прототипа, ибо пешка не идет назад, но второй вектор для верхнего ряда
        motionVector.Add(new Vector2(0, 1));
        motionVector.Add(new Vector2(0, -1));
    }
}
