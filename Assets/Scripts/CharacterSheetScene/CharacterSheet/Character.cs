using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{

    public void Update()
    {
        if (Input.GetKey(KeyCode.Home) || Input.GetKey(KeyCode.Escape) || Input.GetKey(KeyCode.Menu))
        {
            DataManager.DM.SaveData();
            SceneManager.LoadScene(0);
        }
        
    }

    public void ChSpStr(bool b)
    {
        DataHandler.Data.isSpStr = b;
    }
    public void ChAtl(bool b)
    {
        DataHandler.Data.isAtl = b;
    }
    public void ChSpDex(bool b)
    {
        DataHandler.Data.isSpDex = b;
    }
    public void ChAkb(bool b)
    {
        DataHandler.Data.isAkb = b;
    }
    public void ChLR(bool b)
    {
        DataHandler.Data.isLR = b;
    }
    public void ChSte(bool b)
    {
        DataHandler.Data.isSte = b;
    }
    public void ChSpCon(bool b)
    {
        DataHandler.Data.isSpCon = b;
    }
    public void ChSpInt(bool b)
    {
        DataHandler.Data.isSpInt = b;
    }
    public void ChMagic(bool b)
    {
        DataHandler.Data.isMagic = b;
    }
    public void ChHs(bool b)
    {
        DataHandler.Data.isHs = b;
    }
    public void ChAnal(bool b)
    {
        DataHandler.Data.isAnal = b;
    }
    public void ChNat(bool b)
    {
        DataHandler.Data.isNat = b;
    }
    public void ChReg(bool b)
    {
        DataHandler.Data.isReg = b;
    }
    public void ChSpWis(bool b)
    {
        DataHandler.Data.isSpWis = b;
    }
    public void ChAH(bool b)
    {
        DataHandler.Data.isAH = b;
    }
    public void ChIns(bool b)
    {
        DataHandler.Data.isIns = b;
    }
    public void ChMed(bool b)
    {
        DataHandler.Data.isMed = b;
    }
    public void ChPer(bool b)
    {
        DataHandler.Data.isPer = b;
    }
    public void ChSurv(bool b)
    {
        DataHandler.Data.isSurv = b;
    }
    public void ChSpCh(bool b)
    {
        DataHandler.Data.isSpCh = b;
    }
    public void ChDec(bool b)
    {
        DataHandler.Data.isDec = b;
    }
    public void ChInti(bool b)
    {
        DataHandler.Data.isInti = b;
    }
    public void ChPerf(bool b)
    {
        DataHandler.Data.isPerf = b;
    }
    public void ChPers(bool b)
    {
        DataHandler.Data.isPers = b;
    }
}
