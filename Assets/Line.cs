using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace Assets
{
    class Line : MonoBehaviour
    {
        const string _linePrefPath = "Line";
        LineRenderer _line;
        Coord _coord;
        bool _isChange;
        // Use this for initialization
        void Start()
        {
            _line = gameObject.GetComponentInParent<LineRenderer>();
        }
        void Update()
        {
            if (_isChange)
            {
                _isChange = false;
                _line.SetVertexCount(_coord.Arr.Length);
                _line.SetPositions(_coord.ArrDisp);
            }
        }
        public void SetCoord(Coord c)
        {
            _coord = c;
            _isChange = true;
        }
    }
}

