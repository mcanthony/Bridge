﻿using ScriptKit.CLR.Html;
using System;

namespace CompanyX
{
    public static class App
    {
        public static string Name = "Geoff";

        public static void Start()
        {
            //int l = "sas".Length;

            Console.Log("Name", App.Name);
        }
    }

    [ScriptKit.CLR.Name("App.direct")]
    public static class MyAppMethods
    {
        public static void Method1()
        {
        }

        public static void Method2()
        {
        }
    }
}