using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateToText : MonoBehaviour {

    public Text txtDate;
    public Text txtClock;

	void Update () {
        string shortDateString = DateTime.Now.ToShortDateString();
        string year = shortDateString.Substring(shortDateString.Length - 2);
        shortDateString = shortDateString.Replace(shortDateString, shortDateString.Substring(0, shortDateString.Length - 4) + year);
        txtDate.text = shortDateString;

        string longTimeString = DateTime.Parse(DateTime.Now.ToLongTimeString()).ToString("h:mm:ss tt");
        txtClock.text = longTimeString;
	}
}
