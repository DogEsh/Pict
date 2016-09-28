using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    class Coord : MonoBehaviour
    {
        public float StartPos = -47f;
        public float DistStep = 0.7f;
      
        public float MinX;
        public float MaxX;
        public float MinY;
        public float MaxY;

        public Vector3[] _arr;
        public Vector3[] _arrDisp;

        IFunction<float, float> _func;
        void Start()
        {
            _func = new CurFunction();
            _arr = new Vector3[100];
            _arrDisp = new Vector3[100];
        }
        void Update()
        {
            if (DistStep < 0.001f) DistStep = 0.001f;
            CalcPos();
            CalcMinAndMax();
            CalcPosDisp();
        }
        public void CalcPos()
        {
            float curPos = StartPos;
            for (int i = 0; i < _arr.Length; i++)
            {
                Vector2 v;
                v.x = curPos;
                v.y = _func.Calc(curPos);
                _arr[i] = v;
                curPos += DistStep;
            }
        }
        void CalcMinAndMax()
        {
            MinX = _arr[0].x;
            MaxX = _arr[0].x;
            for (int i = 1; i < _arr.Length; i++)
            {
                if (MinX > _arr[i].x)
                {
                    MinX = _arr[i].x;
                }
                if (MaxX < _arr[i].x)
                {
                    MaxX = _arr[i].x;
                }
            }

            MinY = _arr[0].y;
            MaxY = _arr[0].y;
            for (int i = 1; i < _arr.Length; i++)
            {
                if (MinY > _arr[i].y)
                {
                    MinY = _arr[i].y;
                }
                if (MaxY < _arr[i].y)
                {
                    MaxY = _arr[i].y;
                }
            }

        }

        void CalcPosDisp()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                Vector3 v = _arr[i];
                v.x = (v.x - MinX) / (MaxX - MinX);
                v.x *= Screen.width;

                v.y = (v.y - MinY) / (MaxY - MinY);
                v.y *= Screen.height;

                v = Camera.main.ScreenToWorldPoint(v);
                v *= 0.8f;
                v.z = 0;
                _arrDisp[i] = v;
            }
        }


 
        public Vector3[] Arr
        {
            get
            {
                return _arr;
            }
        }
        public Vector3[] ArrDisp
        {
            get
            {
                return _arrDisp;
            }
        }
    }
}
