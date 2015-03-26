using Assets.HotSpot;
using UnityEngine;

public class TestHover : MonoBehaviour , IHotspot {

    private GameObject _master;

    // Use this for initialization	public void Start ()
	{
	    FindMaster();
	}

    private void FindMaster()
    {
        _master = GameObject.Find("testThing");
        _master.GetComponent<TestMaster>();
    }

    // Update is called once per frame	public void Update () {	        //if we don't have a master by now, find one
	    if (_master == null)
	    {
	        FindMaster();
	    }	}    public void HoverReaction()    {        Debug.Log("Hovering!!!!");    }    public void ClickReaction()    {        Debug.Log("Clicked!!!");    }}