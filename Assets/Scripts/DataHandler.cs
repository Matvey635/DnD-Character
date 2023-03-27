using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    public string Name;
    public int Count;
    public bool Equipped;
    public string Description;

    public Item(string name, int count, bool equipped, string description)
    {
        Name     = name;
        Count    = count;
        Equipped = equipped;
        Description = description;
    }
}

public class DataHandler
{
    public static DataHandler Data = new DataHandler();

    public string Name    = "ИМЯ";
    public string Class   = "КЛАСС";

    public int KD         = 0;
    public int MaxHP      = 0;
    public int HP         = 0;
    public int VHP        = 0;
    public int Level      = 1;
    public int XP         = 0;
    public int Initiative = 0;
    public int Speed      = 0;
    public int HitsDice   = 0;
    public int Hits       = 0;
    public int HitsLost   = 0;

    public int Str        = 1;
    public int Dex        = 1;
    public int Con        = 1;
    public int Int        = 1;
    public int Wis        = 1;
    public int Ch         = 1;

    public bool isSpStr   = false;
    public bool isAtl     = false;
    public bool isSpDex   = false;
    public bool isAkb     = false;
    public bool isLR      = false;
    public bool isSte     = false;
    public bool isSpCon   = false;
    public bool isSpInt   = false;
    public bool isMagic   = false;
    public bool isHs      = false;
    public bool isAnal    = false;
    public bool isNat     = false;
    public bool isReg     = false;  
    public bool isSpWis   = false;
    public bool isAH      = false;  
    public bool isIns     = false;
    public bool isMed     = false;
    public bool isPer     = false;
    public bool isSurv    = false;
    public bool isSpCh    = false;
    public bool isDec     = false;
    public bool isInti    = false;
    public bool isPerf    = false;
    public bool isPers    = false;

    public int SpStr      = 0;
    public int Atl        = 0;
    public int SpDex      = 0;
    public int Akb        = 0;
    public int LR         = 0;
    public int Ste        = 0;
    public int SpCon      = 0;
    public int SpInt      = 0;
    public int Magic      = 0;
    public int Hs         = 0;
    public int Anal       = 0;
    public int Nat        = 0;
    public int Reg        = 0;  
    public int SpWis      = 0;
    public int AH         = 0;  
    public int Ins        = 0;
    public int Med        = 0;
    public int Per        = 0;
    public int Surv       = 0;
    public int SpCh       = 0;
    public int Dec        = 0;
    public int Inti       = 0;
    public int Perf       = 0;
    public int Pers       = 0;


    public Dictionary<int, int> LevelCost = new Dictionary<int, int>()
    {
        {2, 300},
        {3, 900},
        {4, 2700},
        {5, 6500},
        {6, 14000},
        {7, 23000},
        {8, 34000},
        {9, 48000},
        {10, 64000},
        {11, 85000},
        {12, 100000},
        {13, 120000},
        {14, 140000},
        {15, 165000},
        {16, 195000},
        {17, 225000},
        {18, 265000},
        {19, 305000},
        {20, 355000}
    };

    public Dictionary<int, string> ChasPlus = new Dictionary<int, string>()
    {
        {1, "-5"},
        {2, "-4"},
        {3, "-4"},
        {4, "-3"},
        {5, "-3"},
        {6, "-2"},
        {7, "-2"},
        {8, "-1"},
        {9, "-1"},
        {10,"0"},
        {11,"0"},
        {12,"+1"},
        {13,"+1"},
        {14,"+2"},
        {15,"+2"},
        {16,"+3"},
        {17,"+3"},
        {18,"+4"},
        {19,"+4"},
        {20,"+5"},
        {21,"+5"},
        {22,"+6"},
        {23,"+6"},
        {24,"+7"},
        {25,"+7"},
        {26,"+8"},
        {27,"+8"},
        {28,"+9"},
        {29,"+9"},
        {30, "+10"}
    };

    public List<Item> Items = new List<Item>();

    public int CalcBM()
    {
        return (int)(2 + ( (Data.Level - 1) / 4 ));
    }

    public static void SetDefault()
    {
        Data.Name       = "ИМЯ";
        Data.Class      = "КЛАСС";
    
        Data.KD         = 0;
        Data.MaxHP      = 0;
        Data.HP         = 0;
        Data.VHP        = 0;
        Data.Level      = 1;
        Data.XP         = 0;
        Data.Initiative = 0;
        Data.Speed      = 0;
        Data.Hits       = 0;
        Data.HitsLost   = 0;

        Data.Str        = 1;
        Data.Dex        = 1;
        Data.Con        = 1;
        Data.Int        = 1;
        Data.Wis        = 1;
        Data.Ch         = 1;
        
        Data.isSpStr    = false;
        Data.isAtl      = false;
        Data.isSpDex    = false;
        Data.isAkb      = false;
        Data.isLR       = false;
        Data.isSte      = false;
        Data.isSpCon    = false;
        Data.isSpInt    = false;
        Data.isMagic    = false;
        Data.isHs       = false;
        Data.isAnal     = false;
        Data.isNat      = false;
        Data.isReg      = false;  
        Data.isSpWis    = false;
        Data.isAH       = false;  
        Data.isIns      = false;
        Data.isMed      = false;
        Data.isPer      = false;
        Data.isSurv     = false;
        Data.isSpCh     = false;
        Data.isDec      = false;
        Data.isInti     = false;
        Data.isPerf     = false;
        Data.isPers     = false;
    }
}