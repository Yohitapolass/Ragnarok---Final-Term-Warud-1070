using System;

        struct City
        {
            public int CityNumber;
            public string CityName;
            public int LevelCovid;
            
        }
class Ragnarok{

    /*static void Main(string []args){

        int AmoutCity = int.Parse(Console.ReadLine());
        string NameCity = string(Console.ReadLine());
        string [ , ] City = new int[AmoutCity,NameCity];

        }*/

         static void Main(string[] args){

          int size = int.Parse(Console.ReadLine());
       float[] num = new float[size];
       // input data to array
       for (int i = 0; i < size; i++) {
        num[i] = float.Parse(Console.ReadLine());
       }
       // sort
       for(int i = size - 1; i > 0; i--) { // size array
           for(int j = 0; j < i; j++) {
            SwapIfHigher(ref num[j], ref num[j+1]);
           }
       }
       for (int i = 0; i < size; i++) {
          Console.Write("{0} ", num[i]);
       }
    }

        static void Swap(ref float a, ref float b) {
            float tmp = a;
            a = b;
            b = tmp;
        }
        static void SwapIfHigher(ref float a, ref float b) {
            if (a < b) {
                Swap(ref a, ref b);
            }
        }

}


    


