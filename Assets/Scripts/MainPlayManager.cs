using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainPlayManager : MonoBehaviour
{
    public TextMeshProUGUI PlayerScoreText;
    public TextMeshProUGUI PlayerText;


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

    Pawn[] pawnWhite = new Pawn[8];
    Rook[] rookWhite = new Rook[2];
    Bishop[] bishopWhite = new Bishop[2];
    Queen queenWhite;
    King kingWhite;
    Knight[] knightWhite = new Knight[2];

    Pawn[] pawnBlack = new Pawn[8];
    Rook[] rookBlack = new Rook[2];
    Bishop[] bishopBlack = new Bishop[2];
    Queen queenBlack;
    King kingBlack;
    Knight[] knightBlack = new Knight[2];


    // Start is called before the first frame update
    void Start()
    {
        PlayerScoreText.text = "Score: " + MainManager.Instance.currentPlayer.score[0] + " - " + MainManager.Instance.currentPlayer.score[1];
        PlayerText.text = "Player: " + MainManager.Instance.currentPlayer.name;
        primaryPiecesArrangement();
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        SceneManager.LoadScene(0);
    }

    void primaryPiecesArrangement()
    {
        Vector3 pieceLocation;
        float zPos = -5.75f;
        float rowWhite;
        float rowWhitePawn;
        float rowBlack;
        float rowBlackPawn;

        float rookPos1 = 1.0f;
        float rookPos2 = 8.0f;
        float bishopPos1 = 3.0f;
        float bishopPos2 = 6.0f;
        float knightPos1 = 2.0f;
        float knightPos2 = 7.0f;
        float queenPos = 4.0f;
        float kingPos = 5.0f;
      

        if (MainManager.Instance.whitePlayer)
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
        for (int i = 1; i <= pawnWhite.Length; i++)
        {
            pieceLocation = new Vector3(i, rowWhitePawn, zPos);//pawnWhitePref.transform.position.z
            pawnWhite[i-1] = Instantiate(pawnWhitePref, pieceLocation, pawnWhitePref.transform.rotation);
        }
        
        pieceLocation = new Vector3(rookPos1, rowWhite, zPos);
        rookWhite[0] = Instantiate(rookWhitePref, pieceLocation, rookWhitePref.transform.rotation);
        pieceLocation = new Vector3(rookPos2, rowWhite, zPos);
        rookWhite[1] = Instantiate(rookWhitePref, pieceLocation, rookWhitePref.transform.rotation);

        pieceLocation = new Vector3(knightPos1, rowWhite, zPos);
        knightWhite[0] = Instantiate(knightWhitePref, pieceLocation, knightWhitePref.transform.rotation);
        pieceLocation = new Vector3(knightPos2, rowWhite, zPos);
        knightWhite[1] = Instantiate(knightWhitePref, pieceLocation, knightWhitePref.transform.rotation);

        pieceLocation = new Vector3(bishopPos1, rowWhite, zPos);
        bishopWhite[0] = Instantiate(bishopWhitePref, pieceLocation, bishopWhitePref.transform.rotation);
        pieceLocation = new Vector3(bishopPos2, rowWhite, zPos);
        bishopWhite[1] = Instantiate(bishopWhitePref, pieceLocation, bishopWhitePref.transform.rotation);

        pieceLocation = new Vector3(queenPos, rowWhite, zPos);
        queenWhite = Instantiate(queenWhitePref, pieceLocation, queenWhitePref.transform.rotation);

        pieceLocation = new Vector3(kingPos, rowWhite, zPos);
        kingWhite = Instantiate(kingWhitePref, pieceLocation, kingWhitePref.transform.rotation);

        //Black
        for (int i = 1; i <= pawnBlack.Length; i++)
        {
            pieceLocation = new Vector3(i, rowBlackPawn, zPos);//pawnWhitePref.transform.position.z
            pawnBlack[i - 1] = Instantiate(pawnBlackPref, pieceLocation, pawnBlackPref.transform.rotation);
        }

        pieceLocation = new Vector3(rookPos1, rowBlack, zPos);
        rookBlack[0] = Instantiate(rookBlackPref, pieceLocation, rookBlackPref.transform.rotation);
        pieceLocation = new Vector3(rookPos2, rowBlack, zPos);
        rookBlack[1] = Instantiate(rookBlackPref, pieceLocation, rookBlackPref.transform.rotation);

        pieceLocation = new Vector3(knightPos1, rowBlack, zPos);
        knightBlack[0] = Instantiate(knightBlackPref, pieceLocation, knightBlackPref.transform.rotation);
        pieceLocation = new Vector3(knightPos2, rowBlack, zPos);
        knightBlack[1] = Instantiate(knightBlackPref, pieceLocation, knightBlackPref.transform.rotation);

        pieceLocation = new Vector3(bishopPos1, rowBlack, zPos);
        bishopBlack[0] = Instantiate(bishopBlackPref, pieceLocation, bishopBlackPref.transform.rotation);
        pieceLocation = new Vector3(bishopPos2, rowBlack, zPos);
        bishopBlack[1] = Instantiate(bishopBlackPref, pieceLocation, bishopBlackPref.transform.rotation);

        pieceLocation = new Vector3(queenPos, rowBlack, zPos);
        queenBlack = Instantiate(queenBlackPref, pieceLocation, queenBlackPref.transform.rotation);

        pieceLocation = new Vector3(kingPos, rowBlack, zPos);
        kingBlack = Instantiate(kingBlackPref, pieceLocation, kingBlackPref.transform.rotation);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
