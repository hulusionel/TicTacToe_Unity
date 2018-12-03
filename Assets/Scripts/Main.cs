using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

   

public class Main : MonoBehaviour
{
    public static int sayi;

    public Board mBoard;
    public Text mCursor; //mouse imlecinin text'i
    public Image mWinner;
    private bool mxTurn = true;
    private int mTurnCount = 0;
    

    void Awake()
    {
        mBoard.Build(this);                 //Board class'ının Build fonksiyonuna buranın adresini göndererek sahneyi oluşturduk
        mCursor.text = GetTurnCharacter();  //mouse imleci geldi 
    }

    public void Deger(int deger)
    {
        sayi = deger;
    }

    public void Switch()
    {
        mTurnCount++;
        bool hasWinner= mBoard.CheckForWinner();
        if (hasWinner || mTurnCount==9)
        {
            StartCoroutine(EndGame(hasWinner));
            return;
        }
           
        mxTurn = !mxTurn;    //bool değer değiştirilerek seçili simge değiştirilmiş oldu
        mCursor.text = GetTurnCharacter();
        
    }
   

    public string GetTurnCharacter()
    {       
            if (mxTurn)
                return "X";
            else
                return "O"; 
    }


    private IEnumerator EndGame(bool haswinner)
    {
        Text winnerLabel = mWinner.GetComponentInChildren<Text>(); //kazanma ekranında yazılacak yazı bilgisi

        if (haswinner)
        {
            winnerLabel.text = GetTurnCharacter() + " " + "Won!";
        }
        else
        {
            winnerLabel.text = "Draw";
        }
    
        mWinner.gameObject.SetActive(true);    //kazanma ekranı görünürlük 'tik' aktif edildi       
        WaitForSeconds wait = new WaitForSeconds(3.0f); //ekran 3sn donduruldu
        yield return wait;
        mBoard.Reset();
        mTurnCount = 0;    
        mWinner.gameObject.SetActive(false);  //kazanma ekranı görünürlük 'tik' kapatıldı 
    }

    

}
