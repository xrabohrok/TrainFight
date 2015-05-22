using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.Helpers
{
    public class ClickControl : MonoBehaviour
    {
        public bool ValidPoint { get { return _valid; } private set { _valid = value; } }
        public Vector3 LastGoodPoint { get; set; }
        public GameObject ThingHovered { get; set; }
        public List<string> LimitToLayerNamed;

        bool _valid = false;
        private int _layerMask;

        public void Start()
        {
            //limit to certain layers
            _layerMask = 0;
            foreach (var layername in LimitToLayerNamed)
            {
                var layermaskNum = LayerMask.NameToLayer(layername);
                Debug.Log(string.Format("Layer {0} matched to {1}", layername, layermaskNum));
                _layerMask |= 1 << layermaskNum;
                Debug.Log(string.Format("Final layer mask: {0}", _layerMask));
            }
        }

        public void Update()
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit infoOut;

            if (Physics.Raycast(ray, out infoOut, 500, _layerMask))
            {
                LastGoodPoint = infoOut.point;
                ThingHovered = infoOut.collider.gameObject;
                _valid = true;
            }
            else
            {
                _valid = false;
            }
        }
    }
}
