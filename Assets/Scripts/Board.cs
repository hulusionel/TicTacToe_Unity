using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

    public GameObject mCellPrefab;
    private Cell[] mCells = new Cell[9];
	
	public void Build(Main main)
    {
        for (int i = 0; i <=8; i++)               //sahnemize 9 hücre eklendi
        {
            GameObject newCell = Instantiate(mCellPrefab, transform);
            mCells[i] = newCell.GetComponent<Cell>();
            mCells[i].mMain = main;
        }
    }

    public void Reset()
    {
        foreach(Cell cell in mCells) //oyun sırasında doldurulan hücreler boşaltıldı
        {
            cell.mLabel.text = "";
            cell.mButton.interactable = true;
        }
    }

    public bool CheckForWinner()  //kazanma ihtimalleri tek tek sorgulandı
    {
        int i = 0;

        for(i=0;i<=6;i+=3)//Horizontal (yatay) sorgulama yapıldı
        {
            if (!CheckValues(i, i + 1))
                continue;
            if (!CheckValues(i, i + 2))
                continue;
            return true;
        }

        for (i = 0; i <= 2; i ++)//Vertical (dikey) sorgulama yapıldı
        {
            if (!CheckValues(i, i + 3))
                continue;
            if (!CheckValues(i, i + 6))
                continue;
            return true;
        }
        //Left Diagonal
        if (CheckValues(0, 4) && CheckValues(0, 8)) //soldan sağa - yukarıdan aşağı sorgulama yapıldı
            return true;


        //Right Diagonal 
        if (CheckValues(2, 4) && CheckValues(2, 6)) //sağdan sola - yukarıdan aşağı sorgu yapıldı
            return true;

       
        return false; //hiçbirine uymazsa 

    }

    private bool CheckValues(int firstIndex, int secondIndex) //CheckForWinner fonksiyonunda sorgu yapabilmek için hücre değerleri okundu
    {
        string firstValue = mCells[firstIndex].mLabel.text;
        string secondValue = mCells[secondIndex].mLabel.text;
        if (firstValue == "" || secondValue == "")
            return false;
        if (firstValue == secondValue)
            return true;
        else
            return false; 
    }
	
}
