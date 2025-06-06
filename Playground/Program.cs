﻿using Playground;
using Playground.Ideas;
using System;
using System.Runtime.CompilerServices;
using static Program;

public class Program
{

    static void Main()
    {
        //ImaginationLand.ImageSort();

        //bool[,] gameMatrix =
        //{
        //    {false, true,  true,  false, false, false},
        //    {true,  true,  true,  false, false, false},
        //    {true,  true,  true,  true,  true,  true},
        //    {false, true,  true,  false, true,  true},
        //    {false, true,  true,  true,  false, true},
        //    {false, false, false, false, false, false},
        //};

        //Console.WriteLine(LeetcodeFunctions.CanTravelTo(gameMatrix, 3, 2, 2, 2)); // true, Valid move
        //Console.WriteLine(LeetcodeFunctions.CanTravelTo(gameMatrix, 3, 2, 3, 4)); // false, Can't travel through land
        //Console.WriteLine(LeetcodeFunctions.CanTravelTo(gameMatrix, 3, 2, 6, 2)); // false, Out of bounds

        //bool[,] mapMatrix = {
        //    { true, false, false }, { true, true, false }, { false, true, true }
        //};

        //LeetcodeFunctions.RouteExists(0, 0, 2, 2, mapMatrix);

        //TrainComposition train = new TrainComposition();
        //train.AttachWagonFromLeft(7);
        //train.AttachWagonFromLeft(13);
        //Console.WriteLine(train.DetachWagonFromRight()); // 7 
        //Console.WriteLine(train.DetachWagonFromLeft()); // 13

        //TextInput input = new NumericInput();
        //input.Add('1');
        //input.Add('a');
        //input.Add('0');
        //Console.WriteLine(input.GetValue());

        //int result = LeetcodeFunctions.AccountBalanceAfterPurchase(15);
    }

    //public class TextInput
    //{
    //    public string text;

    //    public TextInput()
    //    {
    //        text = "";
    //    }

    //    public virtual void Add(char c)
    //    {
    //        text += c;
    //    }

    //    public string GetValue()
    //    {
    //        return this.text;
    //    }
    //}

    //public class NumericInput : TextInput
    //{
    //    public override void Add(char c)
    //    {
    //        if (Char.IsNumber(c))
    //            text += c;
    //    }
    //}

    //public class AlertService
    //{
    //    private readonly AlertDAO storage = new AlertDAO();

    //    public AlertService(IAlertDAO alert)
    //    {
    //        this.storage = (AlertDAO)alert;
    //    }

    //    public Guid RaiseAlert()
    //    {
    //        return this.storage.AddAlert(DateTime.Now);
    //    }

    //    public DateTime GetAlertTime(Guid id)
    //    {
    //        return this.storage.GetAlert(id);
    //    }
    //}

    //public class AlertDAO : IAlertDAO
    //{
    //    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

    //    public Guid AddAlert(DateTime time)
    //    {
    //        Guid id = Guid.NewGuid();
    //        this.alerts.Add(id, time);
    //        return id;
    //    }

    //    public DateTime GetAlert(Guid id)
    //    {
    //        return this.alerts[id];
    //    }
    //}

    //public interface IAlertDAO
    //{
    //    Guid AddAlert(DateTime time);
    //    DateTime GetAlert(Guid id);
    //}

}