using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    private void OnMouseDown()
    {
        List<GameObject> greenDotList = MainPlayManager.Instance.greenDotList;
        for (int i = 1; i <= greenDotList.Count; i++)
        {
            Destroy(greenDotList[i - 1]);
        }
        greenDotList.Clear();
    }

  
}
