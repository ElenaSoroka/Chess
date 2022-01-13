using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessFigure : MonoBehaviour
{
    public class pieceLocation
    {
        public int[,] piecePos;
    }


    public static string[] colors = new string[2] { "white", "black" };

    public string pieceColor; 
    public static int pieceWeight; //*
    public int pieceStartCount; //*
    public List<int> pieceStartPos = new List<int>(); //*
    public static pieceLocation pieceCurPos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
