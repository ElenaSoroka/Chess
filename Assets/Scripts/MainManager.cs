using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    [System.Serializable]
    public class Player
    {
        public string name;
        public int rate;
        public int[] score = new int[2];
        
    }

    public static MainManager Instance;

    public TMP_Dropdown playerToChoose;
    public TMP_InputField newPlayer;
    public TextMeshProUGUI PlayerScoreText;
    public Toggle WhiteBlackToggle;

    public List<Player> playerList = new List<Player>(); //������ ���� �������
    public Player currentPlayer;
    public bool whitePlayer;


    void Awake()
    {
        //Debug.Log(Application.persistentDataPath);
        CreateInstance();
        LoadPlayerList();
        WhiteBlackSwitch();
    }

    public void WhiteBlackSwitch()
    {
        whitePlayer = WhiteBlackToggle.isOn;
    }

    void CreateInstance()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadPlayerList()
    {
        
        ReadFile(); //������ ���� � ��������� ������ �������
        playerToChoose.ClearOptions();

        List<string> names = new List<string>();
        names.Add("None");

        for (int i = 0; i < playerList.Count; i++)
        {
            names.Add(playerList[i].name);
        }

        playerToChoose.AddOptions(names);
    }

    void ReadFile() //������ ���� � ��������� ������ �������
    {

        if (File.Exists(filePath())) //���� ������� �� �������, ������ �� ������� �������� ��������� Json
        {
            string[] savedPlayersArray = File.ReadAllLines(filePath()); //������ ����� Json

            for (int i = 0; i < savedPlayersArray.Length; i++)
            {
                Player player = JsonUtility.FromJson<Player>(savedPlayersArray[i]);
                playerList.Add(player);
            }

        }
    }

    int HavePlayer(string nameForSeek) //���������� ����� ������ � �������� ������ �������
    { 
        for(int i = 0; i < playerList.Count; i++)
        {
            if (nameForSeek == playerList[i].name)
            {
                return i;
            }
        }
        return -1;
    }

    public void FindPlayer(int havePlayer)
    {
        playerToChoose.value = havePlayer + 1; // +1 ��� � dropdown ���� �������������� ������ �������
    }

    public void AddPlayer(string newName)
    {
        
        Player newPlayer = new Player();
        newPlayer.name = newName;
        newPlayer.score[0] = 0;
        newPlayer.score[1] = 0;
        newPlayer.rate = 0;

        playerList.Add(newPlayer);

        string[] strArray = new string[playerList.Count];
        for (int index = 0; index < strArray.Length; index++)
        {
            string json = JsonUtility.ToJson(playerList[index]);
            strArray[index] = json;

        }

        File.WriteAllLines(filePath(), strArray);
        playerToChoose.ClearOptions();
        playerList.Clear();
        LoadPlayerList();

        int havePlayer = HavePlayer(newName);
        FindPlayer(havePlayer);

        }

    public void SelectPlayer()
    {

        int playerNumber = playerToChoose.value - 1; // -1 ��� � ������ dropdown �������������� ������ �������

        if (playerNumber >= 0)
        {
            currentPlayer = playerList[playerNumber];
            PlayerScoreText.text = "Score: " + currentPlayer.score[0] + " - " + currentPlayer.score[1];
            
        }
        else
        {
            PlayerScoreText.text = "Score: ";
            currentPlayer = null;
        }
    }


    public void CreateNewPlayer() //���� � ������ ������� ����� ���. ���� ���� - �������� � ������, ���� ��� - ��������� � ��������.
    {
        if (newPlayer.text != "")
        {
            int havePlayer = HavePlayer(newPlayer.text); //����� ������ � �������� ������ ����

            if (havePlayer >= 0) //���� ����� ����� ��� ����, �� ������ �� �������, � ������� � ������
            {
                FindPlayer(havePlayer); //����� � ������ � �������
            }
            else //���� ������ ������ ���, �� ������� ������ � �������� � ������
            {
                AddPlayer(newPlayer.text); //�������� ������ ������ � ������ � �������
            }

            //SelectPlayer(); //������� � ������ ����������, ������������
        }

    }

    private string filePath()
    {
        //Debug.Log(Application.persistentDataPath);
        return Application.persistentDataPath + "/playerList.json";

    }

    public void StartPlay()
    {
        SceneManager.LoadScene(1);
    }
    

    public void AddPlayerList() // ��� ��������� ���������� ����� �������
    {
        
        string[] srt = new string[5];
        for(int index = 0; index < srt.Length; index++)
        {
            Player data_ = new Player();
            data_.name = "savedName" + index;
            data_.score[0] = 100 + index;
            data_.score[1] = 2000 + index;
            data_.rate = 5000 + index;

            string json_ = JsonUtility.ToJson(data_);
            srt[index] = json_;

        }

        Player data = new Player();
        data.name = "wwwwwwww";
        data.score[0] = 555;
        data.score[1] = 6666;
        data.rate = 90000;

        string json = JsonUtility.ToJson(data);

        srt[4] = json;

        File.WriteAllLines(filePath(), srt);


    }

    

    
}
