﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataGraph : Graph
{

    public Manager manager; 

    public override void SetUpForCalculation(int index)
    {
        CalculateLine(manager.experimentData.data[index].GetNLNL0(), manager.experimentData.data[index].GetX1(), 0);
        CalculateLine(manager.experimentData.data[index].GetNLNL0(), manager.experimentData.data[index].GetX2(), 1);
        CalculateLine(manager.experimentData.data[index].GetNLNL0(), manager.experimentData.data[index].GetY1(), 2);
        CalculateLine(manager.experimentData.data[index].GetNLNL0(), manager.experimentData.data[index].GetY2(), 3);
    }
}
