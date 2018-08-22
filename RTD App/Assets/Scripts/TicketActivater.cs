using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicketActivater : MonoBehaviour {

    public Text txtTicketActivated;

    private const string TICKET_ACTIVATED_MESSAGE = "Ticket activated at ";

	void Start () {
        DateTime dt1 = DateTime.Now.AddHours(-1);
        string[] hourSubstrings = dt1.ToString("g").Split(' ');
        string hour = hourSubstrings[1];
        string meridiem = hourSubstrings[2];
        txtTicketActivated.text = TICKET_ACTIVATED_MESSAGE + hour + " " + meridiem;
	}
}
