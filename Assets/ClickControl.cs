using UnityEngine;
using System.Collections.Generic;

public class ClickControl : MonoBehaviour
{
    public bool ValidPoint { get { return _valid; } private set { _valid = value; } }
    public Vector3 LastGoodPoint { get; set; }
    public GameObject ThingClicked { get; set; }
    public Vector3 ClickedPoint { get; set; }
    public List<string> LimitToLayerNamed;

    bool _valid = false;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit infoOut;

        //limit to one layer
        var layerMask = 0;
        foreach (var layername in LimitToLayerNamed)
        {
            var layermaskNum = LayerMask.NameToLayer(layername);
            layerMask |= 1 << layermaskNum;
        }


        if (Physics.Raycast(ray, out infoOut, 500, layerMask))
        {
            LastGoodPoint = infoOut.point;
            ThingClicked = infoOut.collider.gameObject;
            ClickedPoint = infoOut.point;
            _valid = true;
        }
        else
        {
            _valid = false;
        }
    }
}
