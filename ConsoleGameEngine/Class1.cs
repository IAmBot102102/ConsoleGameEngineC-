using System;
using System.Collections.Generic;
namespace ConsoleGameEngine
{
    public class ConsoleEngine
    {
        List<List<string>> ConsoleMatrix = new List<List<string>>();

        void InitConsole(List<List<string>> pConsoleMatrixStrings, int Rows, int Columns)
        {
            List<string> Row = new List<string>();
            Row.Clear();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Row.Add(" ");
                }
                pConsoleMatrixStrings.Add(Row);
            }
        }

        void Output(List<List<string>> pConsoleMatrixStrings, int XPosition, int YPosition, string Output)
        {
            List<string> RowToDrawOn = pConsoleMatrixStrings[YPosition];
            string SpaceToDrawIn = RowToDrawOn[XPosition];
            SpaceToDrawIn = Output;
            RowToDrawOn[XPosition] = SpaceToDrawIn;
            pConsoleMatrixStrings[YPosition] = RowToDrawOn;
        }

        void Clear(List<List<string>> pConsoleMatrixStrings)
        {
            int Rows = pConsoleMatrixStrings.Count;
            List<string> Row = pConsoleMatrixStrings[0];
            int Columns = Row.Count;
            pConsoleMatrixStrings.Clear();
            List<string> Rowp = new List<string>();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Rowp.Add(" ");
                }
                pConsoleMatrixStrings.Add(Rowp);
            }
        }

        void DrawConsole(List<List<string>> pConsoleMatrixStrings)
        {
            foreach (var Row in pConsoleMatrixStrings)
            {
                foreach (var Character in Row)
                {
                    Console.Write(Character);
                }
                Console.Write("\n");
            }
        }
    }
}