using Assets.Code.Clickable;
using UnityEngine;

namespace Assets.Soldiers
{
    [RequireComponent(typeof(ClickEventDelegator))]
    public class SoldierMaster : MonoBehaviour {
        private ClickEventDelegator _slaveDriver;

        // Use this for initialization
        void Start () {

            _slaveDriver = this.gameObject.GetComponent<ClickEventDelegator>();
            if (_slaveDriver == null)
                throw new System.NullReferenceException();

        }
	
        // Update is called once per frame
        void Update () {
	
        }
    }
}
