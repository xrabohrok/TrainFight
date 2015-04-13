using Assets.HotSpot;
using UnityEngine;

namespace Assets.Code.Examples
{
    public class TestClickable : MonoBehaviour ,IClickable {        private GameObject _master;        // Use this for initialization        public void Start ()        {            FindMaster();        }        private void FindMaster()        {            _master = GameObject.Find("clickMaster");            _master.GetComponent<TestClickableMaster>();        }        // Update is called once per frame        public void Update () {	            //if we don't have a master by now, find one            if (_master == null)            {                FindMaster();            }        }        public void HoverReaction()        {            Debug.Log("Hovering!!!!");        }        public void ClickReaction()        {            Debug.Log("Clicked!!!");        }    }
}