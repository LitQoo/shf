using System.Collections.Generic;

public class Shf
{
    static private System.Random rng = new System.Random();  

    static public void Shuffle(IList<int> list)  
    {  
        int n = list.Count;  
        while (n > 1) {  
            //ㅁㄴ아러미ㅏ너린멍리
            //ㅁㄴ아ㅣ럼니러ㅏㅣㄴ머린렁
            n--;  
            int k = rng.Next(n + 1);  
            int value = list[k];  
            list[k] = list[n];  
            list[n] = value;  
        }  
    } 
}