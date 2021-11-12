﻿using System;

namespace GUICalculator
{
    public interface ISolve
    {
        void Accumulate(string s);
        void Clear();
        double Solve();
    }
}