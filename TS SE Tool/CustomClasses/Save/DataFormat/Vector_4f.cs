﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS_SE_Tool.Utilities;

namespace TS_SE_Tool.Save.DataFormat
{
    class Vector_4f
    {
        float W { get; set; } = 1;

        float X { get; set; } = 0;
        float Y { get; set; } = 0;
        float Z { get; set; } = 0;

        override public string ToString()
        {
            // (&3f7f126f; &bd85bf17, &bd5ecfd4, &bb69a963)
            return "(" + NumericUtilities.SingleFloatToHexFloat(W) + "; " + 
                NumericUtilities.SingleFloatToHexFloat(X) + ", " + NumericUtilities.SingleFloatToHexFloat(Y) + ", " + NumericUtilities.SingleFloatToHexFloat(Z) + ")";
        }

        public void ToVector(string _input)
        {
            string[] parts = _input.Split(new char[] { '(', ')', ';', ',' }, 5, StringSplitOptions.RemoveEmptyEntries);

            W = NumericUtilities.HexFloatToSingleFloat(parts[0].Trim());
            X = NumericUtilities.HexFloatToSingleFloat(parts[1].Trim());
            Y = NumericUtilities.HexFloatToSingleFloat(parts[2].Trim());
            Z = NumericUtilities.HexFloatToSingleFloat(parts[3].Trim());
        }
    }
}