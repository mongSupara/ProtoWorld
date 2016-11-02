﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChartPanelController : MonoBehaviour
{

    private List<ChartController> charts;
    
	// Use this for initialization
	void Start ()
	{

	    charts = new List<ChartController>();

	    foreach (Transform kpichart in transform)
	    {
	        charts.Add(kpichart.GetComponent<ChartController>());
	    }

	}
	
	// Update is called once per frame
	void Update ()
	{

	    Vector3 origin = transform.position;

	    int height = 0;

        foreach (ChartController chart in charts)
        {
            Vector3 pos = origin;
            pos.y = origin.y - height;
	        chart.transform.position = pos;

            //ContentPanel is active! 
	        if (chart.contentPanel.active)
	        {
	            height += 200;
	        }
	        else
	        {
	            height += 25;
	        }
	    }

	}
}
