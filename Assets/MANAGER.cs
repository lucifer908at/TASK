using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MANAGER : MonoBehaviour
{
    [SerializeField]public GameObject MENU,GAME; [SerializeField]public Text choice1,choice3,Right,Wrong,Timer;
    public int n1,n2,n3,n4,res1,res2,c1,c2,right=0,wrong=0; public static List<char>oper=new List<char>(){'+','-','*','/'};
    public float _timer=10f,t;
    void Start() 
    {
        MENU.SetActive(true); GAME.SetActive(false);
    }
    public bool b1(){ return true; } public bool b2(){ return true; } public bool b3(){ return true; }
    void Matcher()
    {
        InvokeRepeating("Game",1,10);
    }
    public void Game()
    {
        MENU.SetActive(false); GAME.SetActive(true);
        n1=Random.Range(1,9); n2=Random.Range(1,9); n3=Random.Range(1,9); n4=Random.Range(1,9); c1=Random.Range(0,3); c2=Random.Range(0,3);
        choice1.text=(n1+""+oper[c1]+""+n2); choice3.text=(n3+""+oper[c2]+""+n4); string s1=choice1.text,s2=choice3.text;
        if(oper[c1]=='+'){ res1=n1+n2; } else if(oper[c1]=='-'){ res1=n1-n2; } else if(oper[c1]=='*'){ res1=n1*n2; } else if(oper[c1]=='/'){ res1=n1/n2; }
        if(oper[c2]=='+'){ res2=n3+n4; } else if(oper[c2]=='-'){ res2=n3-n4; } else if(oper[c2]=='*'){ res2=n3*n4; } else if(oper[c2]=='/'){ res2=n3/n4; }
        t=10f;
    }
    public void S1()
    {
        if(b1()==true){ if(res1>res2){ right++; }else if(res1<res2){ wrong++; } else if(res1==res2){ wrong++; } } 
        Right.text=right.ToString(); Wrong.text=wrong.ToString();
    }
    public void S2()
    {
        if(b2()==true){ if(res1==res2){ right++; }else if(res1<res2){ wrong++; } else if(res1>res2){ wrong++; } } 
        Right.text=right.ToString(); Wrong.text=wrong.ToString();
    }
    public void S3()
    {
        if(b3()==true){ if(res1>res2){ right++; }else if(res1<res2){ wrong++; } else if(res1==res2){ wrong++; } } 
        Right.text=right.ToString(); Wrong.text=wrong.ToString();
    }
    
    public void timer(){ if(t>0){ t-=Time.deltaTime; } Timer.text=string.Format("{0:00}",t); if(t<=0){ t=10f; } }
    void Update() 
    {
        timer();
    }
}
