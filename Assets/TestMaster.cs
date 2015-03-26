using System.Collections.Generic;
using Assets.HotSpot;
using UnityEngine;

public class TestMaster : MonoBehaviour
{

    public HotSpotMaster hotspots;

	// Use this for initialization
	public void Start () {
        hotspots = new HotSpotMaster(new List<string>{"Fire1"});
	}
	
	// Update is called once per frame
	public void Update () {
	    hotspots.Update();
	}
}
