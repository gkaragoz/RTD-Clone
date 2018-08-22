using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicketActivater : MonoBehaviour {

    public Text txtTicketActivated;

    private const string TICKET_ACTIVATED_MESSAGE = "Ticket activated at ";

	void Start () {
        DateTime dt1 = DateTime.Now.AddHours(-1).AddMinutes(UnityEngine.Random.Range(1, 50));
        string parsedTime = DateTime.Parse(dt1.ToLongTimeString()).ToString("h:mm tt");
        txtTicketActivated.text = TICKET_ACTIVATED_MESSAGE + parsedTime;

        /*
        DateTime dt = DateTime.Parse("6/22/2009 07:00:00 AM");

        dt.ToString("HH:mm"); // 07:00 // 24 hour clock // hour is always 2 digits
        dt.ToString("hh:mm tt"); // 07:00 AM // 12 hour clock // hour is always 2 digits
        dt.ToString("H:mm"); // 7:00 // 24 hour clock
        dt.ToString("h:mm tt"); // 7:00 AM // 12 hour clock
        */
    }
}
