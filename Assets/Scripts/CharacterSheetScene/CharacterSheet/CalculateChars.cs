using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CalculateChars
{

    public static CalculateChars Calculator = new CalculateChars();

    public void Calc()
    {
        DataHandler.Data.SpStr = DataHandler.Data.isSpStr ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Str]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Str]);
        DataHandler.Data.Atl   = DataHandler.Data.isAtl   ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Str]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Str]);
        DataHandler.Data.SpDex = DataHandler.Data.isSpDex ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Dex]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Dex]);
        DataHandler.Data.Akb   = DataHandler.Data.isAkb   ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Dex]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Dex]);
        DataHandler.Data.LR    = DataHandler.Data.isLR    ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Dex]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Dex]);
        DataHandler.Data.Ste   = DataHandler.Data.isSte   ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Dex]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Dex]);
        DataHandler.Data.SpCon = DataHandler.Data.isSpCon ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Con]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Con]);
        DataHandler.Data.SpInt = DataHandler.Data.isSpInt ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]);
        DataHandler.Data.Magic = DataHandler.Data.isMagic ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]);
        DataHandler.Data.Hs    = DataHandler.Data.isHs    ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]);
        DataHandler.Data.Anal  = DataHandler.Data.isAnal  ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]);
        DataHandler.Data.Nat   = DataHandler.Data.isNat   ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]);
        DataHandler.Data.Reg   = DataHandler.Data.isReg   ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Int]);
        DataHandler.Data.SpWis = DataHandler.Data.isSpWis ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]);
        DataHandler.Data.AH    = DataHandler.Data.isAH    ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]);
        DataHandler.Data.Ins   = DataHandler.Data.isIns   ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]);
        DataHandler.Data.Med   = DataHandler.Data.isMed   ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]);
        DataHandler.Data.Per   = DataHandler.Data.isPer   ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]);
        DataHandler.Data.Surv  = DataHandler.Data.isSurv  ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Wis]);
        DataHandler.Data.SpCh  = DataHandler.Data.isSpCh  ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Ch ]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Ch ]);
        DataHandler.Data.Dec   = DataHandler.Data.isDec   ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Ch ]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Ch ]);
        DataHandler.Data.Inti  = DataHandler.Data.isInti  ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Ch ]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Ch ]);
        DataHandler.Data.Perf  = DataHandler.Data.isPerf  ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Ch ]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Ch ]);
        DataHandler.Data.Pers  = DataHandler.Data.isPers  ? int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Ch ]) + DataHandler.Data.CalcBM() : int.Parse(DataHandler.Data.ChasPlus[DataHandler.Data.Ch ]);
    }
}
