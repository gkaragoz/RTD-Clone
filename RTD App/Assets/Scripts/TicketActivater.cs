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
        txtTicketActivated.text = TICKET_ACTIVATED_MESSAGE + dt1.ToShortTimeString();
	}
}
