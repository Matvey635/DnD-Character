using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstSceneLoader : MonoBehaviour
{
    #region FirstView
    public GameObject Name;
    public GameObject Class;
    public GameObject KD;
    public GameObject MaxHP;
    public GameObject HP;
    public GameObject VHP;
    public GameObject Level;
    public GameObject XP;
    public GameObject Initiative;
    public GameObject Speed;
    public GameObject HitsDice;
    public GameObject Hits;
    public GameObject HitsLost;

    [Header("Stats")]
    public GameObject isSpStr;
    public GameObject isAtl;  
    public GameObject isSpDex;
    public GameObject isAkb;  
    public GameObject isLR;    
    public GameObject isSte;   
    public GameObject isSpCon; 
    public GameObject isSpInt; 
    public GameObject isMagic; 
    public GameObject isHs;   
    public GameObject isAnal; 
    public GameObject isNat;  
    public GameObject isReg;  
    public GameObject isSpWis;  
    public GameObject isAH;   
    public GameObject isIns;    
    public GameObject isMed;  
    public GameObject isPer;   
    public GameObject isSurv;  
    public GameObject isSpCh;   
    public GameObject isDec;  
    public GameObject isInti;   
    public GameObject isPerf;   
    public GameObject isPers;  

    [Header("Chas")]
    public GameObject Str;
    public GameObject Dex;
    public GameObject Con;
    public GameObject Int;
    public GameObject Wis;
    public GameObject Ch;

    [Header("TextObj")]
    public GameObject ObjSpStr;
    public GameObject ObjAtl;
    public GameObject ObjSpDex;
    public GameObject ObjAkb;
    public GameObject ObjLR;
    public GameObject ObjSte;
    public GameObject ObjSpCon;
    public GameObject ObjSpInt;
    public GameObject ObjMagic;
    public GameObject ObjHs;
    public GameObject ObjAnal;
    public GameObject ObjNat;
    public GameObject ObjReg;  
    public GameObject ObjSpWis;
    public GameObject ObjAH;  
    public GameObject ObjIns;
    public GameObject ObjMed;
    public GameObject ObjPer;
    public GameObject ObjSurv;
    public GameObject ObjSpCh;
    public GameObject ObjDec;
    public GameObject ObjInti;
    public GameObject ObjPerf;
    public GameObject ObjPers;
    #endregion

    void Awake()
    {
        Load();
        LocalLoadStat();
    }

    public void LocalLoadStat()
    {
        CalculateChars.Calculator.Calc();
        ObjSpStr.GetComponent<Text>().text   = DataHandler.Data.SpStr.ToString();
        ObjAtl.GetComponent<Text>().text     = DataHandler.Data.Atl.ToString();
        ObjSpDex.GetComponent<Text>().text   = DataHandler.Data.SpDex.ToString();
        ObjAkb.GetComponent<Text>().text     = DataHandler.Data.Akb.ToString();
        ObjLR.GetComponent<Text>().text      = DataHandler.Data.LR.ToString();
        ObjSte.GetComponent<Text>().text     = DataHandler.Data.Ste.ToString();
        ObjSpCon.GetComponent<Text>().text   = DataHandler.Data.SpCon.ToString();
        ObjSpInt.GetComponent<Text>().text   = DataHandler.Data.SpInt.ToString();
        ObjMagic.GetComponent<Text>().text   = DataHandler.Data.Magic.ToString();
        ObjHs.GetComponent<Text>().text      = DataHandler.Data.Hs.ToString();
        ObjAnal.GetComponent<Text>().text    = DataHandler.Data.Anal.ToString();
        ObjNat.GetComponent<Text>().text     = DataHandler.Data.Nat.ToString();
        ObjReg.GetComponent<Text>().text     = DataHandler.Data.Reg.ToString();  
        ObjSpWis.GetComponent<Text>().text   = DataHandler.Data.SpWis.ToString();
        ObjAH.GetComponent<Text>().text      = DataHandler.Data.AH.ToString();  
        ObjIns.GetComponent<Text>().text     = DataHandler.Data.Ins.ToString();
        ObjMed.GetComponent<Text>().text     = DataHandler.Data.Med.ToString();
        ObjPer.GetComponent<Text>().text     = DataHandler.Data.Per.ToString();
        ObjSurv.GetComponent<Text>().text    = DataHandler.Data.Surv.ToString();
        ObjSpCh.GetComponent<Text>().text    = DataHandler.Data.SpCh.ToString();
        ObjDec.GetComponent<Text>().text     = DataHandler.Data.Dec.ToString();
        ObjInti.GetComponent<Text>().text    = DataHandler.Data.Inti.ToString();
        ObjPerf.GetComponent<Text>().text    = DataHandler.Data.Perf.ToString();
        ObjPers.GetComponent<Text>().text    = DataHandler.Data.Pers.ToString();
    }

    public void Load()
    {
        DataManager.DM.LoadData();

        #region FirstViewLoad
        Name.GetComponent<Text>().text       = DataHandler.Data.Name.ToString();
        Class.GetComponent<Text>().text      = DataHandler.Data.Class.ToString();
        KD.GetComponent<Text>().text         = DataHandler.Data.KD.ToString();
        //MaxHp
        HP.GetComponent<Text>().text         = DataHandler.Data.HP.ToString();
        //VHp
        Level.GetComponent<Text>().text      = "Lv: " + DataHandler.Data.Level.ToString() + " / <color=#4ECCA3>+" + DataHandler.Data.CalcBM() + "</color>";
        XP.GetComponent<Text>().text         = "XP: " + DataHandler.Data.XP.ToString() + " / " + DataHandler.Data.LevelCost[DataHandler.Data.Level + 1];
        Initiative.GetComponent<Text>().text = DataHandler.Data.Initiative.ToString();
        Speed.GetComponent<Text>().text      = DataHandler.Data.Speed.ToString();
        HitsDice.GetComponent<Text>().text   = DataHandler.Data.HitsDice.ToString();
        HitsLost.GetComponent<Text>().text   = DataHandler.Data.HitsLost.ToString() + " / " + DataHandler.Data.Hits.ToString();

        isSpStr.GetComponent<Toggle>().isOn  = DataHandler.Data.isSpStr;
        isAtl.GetComponent<Toggle>().isOn    = DataHandler.Data.isAtl;  
        isSpDex.GetComponent<Toggle>().isOn  = DataHandler.Data.isSpDex;
        isAkb.GetComponent<Toggle>().isOn    = DataHandler.Data.isAkb;  
        isLR.GetComponent<Toggle>().isOn     = DataHandler.Data.isLR;   
        isSte.GetComponent<Toggle>().isOn    = DataHandler.Data.isSte;  
        isSpCon.GetComponent<Toggle>().isOn  = DataHandler.Data.isSpCon;
        isSpInt.GetComponent<Toggle>().isOn  = DataHandler.Data.isSpInt;
        isMagic.GetComponent<Toggle>().isOn  = DataHandler.Data.isMagic;
        isHs.GetComponent<Toggle>().isOn     = DataHandler.Data.isHs;   
        isAnal.GetComponent<Toggle>().isOn   = DataHandler.Data.isAnal; 
        isNat.GetComponent<Toggle>().isOn    = DataHandler.Data.isNat;  
        isReg.GetComponent<Toggle>().isOn    = DataHandler.Data.isReg;  
        isSpWis.GetComponent<Toggle>().isOn  = DataHandler.Data.isSpWis;
        isAH.GetComponent<Toggle>().isOn     = DataHandler.Data.isAH;   
        isIns.GetComponent<Toggle>().isOn    = DataHandler.Data.isIns;  
        isMed.GetComponent<Toggle>().isOn    = DataHandler.Data.isMed;  
        isPer.GetComponent<Toggle>().isOn    = DataHandler.Data.isPer;  
        isSurv.GetComponent<Toggle>().isOn   = DataHandler.Data.isSurv; 
        isSpCh.GetComponent<Toggle>().isOn   = DataHandler.Data.isSpCh; 
        isDec.GetComponent<Toggle>().isOn    = DataHandler.Data.isDec;  
        isInti.GetComponent<Toggle>().isOn   = DataHandler.Data.isInti; 
        isPerf.GetComponent<Toggle>().isOn   = DataHandler.Data.isPerf; 
        isPers.GetComponent<Toggle>().isOn   = DataHandler.Data.isPers; 

        Str.GetComponent<Text>().text        = "Сила: " + DataHandler.Data.Str.ToString() + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[DataHandler.Data.Str] + "</color>";
        Dex.GetComponent<Text>().text        = "Лвк: "  + DataHandler.Data.Dex.ToString() + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[DataHandler.Data.Dex] + "</color>";
        Con.GetComponent<Text>().text        = "Тел: "  + DataHandler.Data.Con.ToString() + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[DataHandler.Data.Con] + "</color>";
        Int.GetComponent<Text>().text        = "Инт: "  + DataHandler.Data.Int.ToString() + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[DataHandler.Data.Int] + "</color>";
        Wis.GetComponent<Text>().text        = "Муд: "  + DataHandler.Data.Wis.ToString() + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[DataHandler.Data.Wis] + "</color>";
        Ch.GetComponent<Text>().text         = "Хар: "  + DataHandler.Data.Ch.ToString()  + " <color=#4ECCA3>" + DataHandler.Data.ChasPlus[DataHandler.Data.Ch] + "</color>";        
        #endregion
    }
}
