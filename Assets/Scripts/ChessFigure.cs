using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChessFigure : MonoBehaviour
{
    
    public static string[] colors = new string[2] { "white", "black" };

    public string pieceColor; 
    public static int pieceWeight; //*
    public int pieceStartCount; //*
    public List<int> pieceStartPos = new List<int>(); //*
    public Vector2 pieceCurPos;
    public List<Vector2> motionVector = new List<Vector2>();


    private void OnMouseDown()
    {
        ShowPossibleMoves();
    }



    void greenDotShow(int xPos, int yPos)
    {
        MainPlayManager.Instance.greenDotList.Add(
            Instantiate(MainPlayManager.Instance.greenDotPref, 
            new Vector3(xPos, yPos, MainPlayManager.zPos - 0.3f), 
            MainPlayManager.Instance.greenDotPref.transform.rotation));
    
    }

    public abstract void PossibleMoves();

    public void ShowPossibleMoves()
    {
        /* когда ставим точку - условия:
         * 1. поле пустое или занято чужим цветом
         * 2. между точкой и объектом ничего нет (никакая фигура не лежит на отрезке, их соединяющем)

        */
        int curPosX = (int)pieceCurPos.x;
        int curPosY = (int)pieceCurPos.y;

        for (int i = 1; i <= motionVector.Count; i++)
        {
            int xNew = (int)motionVector[i - 1].x + curPosX;
            int yNew = (int)motionVector[i - 1].y + curPosY;

            if (xNew <= MainPlayManager.boardLength & 
                xNew > 0 &
                yNew <= MainPlayManager.boardLength &
                yNew > 0) // проверка, что не выходит за пределы доски
            {
                if (WayFree(curPosX, curPosY, xNew, yNew))
                {
                    if ((MainPlayManager.chessBoard[xNew - 1, yNew - 1] == null) || 
                        (MainPlayManager.chessBoard[xNew - 1, yNew - 1].pieceColor != pieceColor))
                    {
                        greenDotShow(xNew, yNew);
                    }
                }
            }
        }

    }

    bool WayFree(int x1, int y1, int x2, int y2)
    {
        int xMin;
        int xMax;
        int yMin;
        int yMax;
        int a; 
        int b;

        //Debug.Log(x1 + " " + y1 + " " + x2 + " " + y2);


        if (x1 > x2)
        {
            xMin = x2;
            xMax = x1;
        }
        else
        {
            xMin = x1;
            xMax = x2;
        }

        if (y1 > y2)
        {
            yMin = y2;
            yMax = y1;
        }
        else
        {
            yMin = y1;
            yMax = y2;
        }

        //сужаем квадрат проверки на доске, чтобы не захватывать сам объект и проверяемую точку
        xMin = xMin + 1;
        xMax = xMax - 1;
        yMin = yMin + 1;
        yMax = yMax - 1;

        if (y1 == y2) //горизонталь
        {
            for (int i = xMin; i <= xMax; i++)
            {
                if (MainPlayManager.chessBoard[i - 1, y1 - 1] != null) //в этой точке кто-то есть, значит путь не свободен
                {
                    return false;
                }
            }
        }


        for (int j = yMin; j <= yMax; j++)
        {
            if (x1 == x2) //вертикаль
            {
                if (MainPlayManager.chessBoard[x1 - 1, j - 1] != null) //в этой точке кто-то есть, значит путь не свободен
                {
                    return false;
                }
            }
            else
            {
                for (int i = xMin; i <= xMax; i++)
                {
                    a = (y1 - y2) / (x1 - x2);
                    b = (x1 * y2 - x2 * y1) / (x1 - x2);

                    if (j == a * i + b) //точка принадлежит отрезку, соединяющему объект и новое место
                    {
                        if (MainPlayManager.chessBoard[i - 1, j - 1] != null) //в этой точке кто-то есть, значит путь не свободен
                        {
                            return false;
                        }
                    }
                }
            }
        }

        return true;
    }
}
