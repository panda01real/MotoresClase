using System;
using UnityEngine;

public class MonoClass : MonoBehaviour
{
    [SerializeField] ClaseParaSerializar claseParaSerializar;

    private void Start()
    {
        Data data1 = new Data(1, 2);
        Data data2 = new Data(1, 2);

        Data data3 = data1 + data2;
        Debug.Log($"data3: {data3.a}, {data3.b}");
    }
    //sobrecarga de operadores
    public struct Data
    {
        public int a;
        public int b;

        public Data(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        
        public static Data operator +(Data first, Data second)
        {
            return new Data()
            {
                a = first.a + second.a,
                b = first.b + second.b
            };
        }
    }

    
}
