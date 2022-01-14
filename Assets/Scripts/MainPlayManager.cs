using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainPlayManager : MonoBehaviour
{
    public static MainPlayManager Instance;
    public TextMeshProUGUI PlayerScoreText;
    public TextMeshProUGUI PlayerText;

    public static int boardLength = 8;
    public static float zPos = -5.75f;
    public static ChessFigure[,] chessBoard = new ChessFigure[boardLength, boardLength];

    public Pawn pawnWhitePref;
    public Rook rookWhitePref;
    public Bishop bishopWhitePref;
    public Queen queenWhitePref;
    public King kingWhitePref;
    public Knight knightWhitePref;

    public Pawn pawnBlackPref;
    public Rook rookBlackPref;
    public Bishop bishopBlackPref;
    public Queen queenBlackPref;
    public King kingBlackPref;
    public Knight knightBlackPref;

    public GameObject greenDotPref;

    bool whiteGame;

    List<ChessFigure> pawnWhite = new List<ChessFigure>();
    List<ChessFigure> rookWhite = new List<ChessFigure>();
    List<ChessFigure> bishopWhite = new List<ChessFigure>();
    List<ChessFigure> queenWhite = new List<ChessFigure>();
    List<ChessFigure> kingWhite = new List<ChessFigure>();
    List<ChessFigure> knightWhite = new List<ChessFigure>();

    List<ChessFigure> pawnBlack = new List<ChessFigure>();
    List<ChessFigure> rookBlack = new List<ChessFigure>();
    List<ChessFigure> bishopBlack = new List<ChessFigure>();
    List<ChessFigure> queenBlack = new List<ChessFigure>();
    List<ChessFigure> kingBlack = new List<ChessFigure>();
    List<ChessFigure> knightBlack = new List<ChessFigure>();


    public List<GameObject> greenDotList = new List<GameObject>();


    // Start is called before the first frame update
    void CreateInstance()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        //DontDestroyOnLoad(gameObject);
    }



    void Start()
    {
        if (MainManager.Instance != null)
        {
            PlayerScoreText.text = "Score: " + MainManager.Instance.currentPlayer.score[0] + " - " + MainManager.Instance.currentPlayer.score[1];
            PlayerText.text = "Player: " + MainManager.Instance.currentPlayer.name;
            whiteGame = MainManager.Instance.whitePlayer;
        }
        else 
        {
            whiteGame = true;
        }
        primaryPiecesArrangement();
    }

    void Awake()
    {
        CreateInstance();
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(0);
    }

    void FillFigure(List<ChessFigure> figureType, ChessFigure prefObj, int row, float zPos, string color) // ABSTRACTION
    {
        int i = 0;
        do
        {
            figureType.Add(Instantiate(prefObj));
            Vector3 pieceLoc = new Vector3(figureType[0].pieceStartPos[i], row, zPos);
            figureType[i].transform.position = pieceLoc;
            figureType[i].transform.rotation = prefObj.transform.rotation;
            figureType[i].pieceColor = color;
            figureType[i].pieceCurPos = new Vector2(pieceLoc.x, pieceLoc.y);
            chessBoard[(int)pieceLoc.x - 1, (int)pieceLoc.y - 1] = figureType[i];
            i++;
        }
        while (i < figureType[0].pieceStartCount);
    }

    void primaryPiecesArrangement()
    {
      
        int rowWhite;
        int rowWhitePawn;
        int rowBlack;
        int rowBlackPawn;


        if (whiteGame)
        {
            rowWhite = 1;
            rowWhitePawn = 2;
            rowBlack = 8;
            rowBlackPawn = 7;
        }
        else
        {
            rowWhite = 8;
            rowWhitePawn = 7;
            rowBlack = 1;
            rowBlackPawn = 2;
        }



        //White
        string color = ChessFigure.colors[0];

        // ABSTRACTION
        FillFigure(pawnWhite, pawnWhitePref, rowWhitePawn, zPos, color); //pawns
        FillFigure(rookWhite, rookWhitePref, rowWhite, zPos, color); //rooks
        FillFigure(knightWhite, knightWhitePref, rowWhite, zPos, color); //knights
        FillFigure(bishopWhite, bishopWhitePref, rowWhite, zPos, color); //bishops
        FillFigure(queenWhite, queenWhitePref, rowWhite, zPos, color); //queen
        FillFigure(kingWhite, kingWhitePref, rowWhite, zPos, color); //king


        //Black
        color = ChessFigure.colors[1];

        // ABSTRACTION
        FillFigure(pawnBlack, pawnBlackPref, rowBlackPawn, zPos, color); //pawns
        FillFigure(rookBlack, rookBlackPref, rowBlack, zPos, color); //rooks
        FillFigure(knightBlack, knightBlackPref, rowBlack, zPos, color); //knights
        FillFigure(bishopBlack, bishopBlackPref, rowBlack, zPos, color); //bishops
        FillFigure(queenBlack, queenBlackPref, rowBlack, zPos, color); //queen
        FillFigure(kingBlack, kingBlackPref, rowBlack, zPos, color); //king
        
    }

    void PrintBoard()
    {
        for (int y = 0; y <= boardLength - 1; y++)
        {
            string row = "| ";
            for (int x = 0; x <= boardLength - 1; x++)
            {
                if (chessBoard[x, y] == null)
                {
                    row = row + "*" + " | ";
                }
                else
                {
                    row = row + chessBoard[x, y] + " | ";
                }
            }
            Debug.Log(row);
        }
    }

}
