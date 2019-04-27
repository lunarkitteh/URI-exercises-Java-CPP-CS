using System;
using System.IO;
using System.Linq;
class MainClass{
    //Functions

        // Time Conversion 1019
        public void timeConversion(){
        int n = int.Parse(Console.ReadLine());   // input in second
        int hour=0,minutes=0,seconds=0;
        if(n>=3600){
           hour +=  (int)n/3600;
        }
       n = n-(hour*3600); // substract n with acquired hour which has been converted into second
        if(n>=60){
            minutes += (int)n/60;
        }
        n-=(minutes*60);
        if(n<60){
          seconds += n;
        }
        Console.WriteLine("{0}:{1}:{2}",hour,minutes,seconds);
    }

    // 1020 - Age in days
    public void ageInDays(){
        int days = int.Parse(Console.ReadLine());
        int years = 0;
        int month = 0;
        int day2 = 0;
        if(days>=365){
        years += days/365;
        }
        days-=years*365;
        if(days>=30){
            month += days/30;
        }
        days-=month*30;
        if(days<30){
            day2+=days;
        }
        Console.WriteLine("{0} ano(s)",years);
        Console.WriteLine("{0} mes(es)",month);
        Console.WriteLine("{0} dia(s)",day2);
    }

    public void selection1(){
        // corrected in c++ - this script doesn't take inputs in one line
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if((b>c)&&(d>a)){
                if((c+d)>(a+b)){
                    if((c>=0)&&(d>=0)){
                    if(a%2==0){
                        Console.WriteLine("Valores aceitos");
                    }
                    }
                }
            }
                Console.WriteLine("Valores nao aceitos");
    }

public void banknotesAndCoins(){
            // Explaination 
            /* 
            int x11 = int.Parse(Console.ReadLine());
			int x10 = x11%100   // x10 here is the number of notes
			Console.WriteLine("{0} nota(s) de R$ {1}", x10,100);
			Console.WriteLine("x11 = " + x11 );
			int x12 = x10/50;
			Console.WriteLine("{0} nota(s) de R$ {1}", x12, 50);
			Console.WriteLine("x11 = " + x11 );
            */
    double A,E;
    A = double.Parse(Console.ReadLine());
    int N,a,b,c,d,e,f,g,h,i,j,k,l,B,m,n,o,p,q,r,s,t,u;
    N=(int)A;
    a=N/100;
    b=N%100;
    c=b/50;
    d=b%50;
    e=d/20;
    f=d%20;
    g=f/10;
    h=f%10;
    i=h/5;
    j=h%5;
    k=j/2;
    l=j%2;

    E=A*100;
    B=(int) E;
    m=B%100;
    n=m/50;
    o=m%50;
    p=o/25;
    q=o%25;
    r=q/10;
    s=q%10;
    t=s/5;
    u=s%5;
    Console.WriteLine("NOTAS:");
    Console.WriteLine("{0} nota(s) de R$ 100.00",a);
    Console.WriteLine("{0} nota(s) de R$ 50.00",c);
    Console.WriteLine("{0} nota(s) de R$ 20.00",e);
    Console.WriteLine("{0} nota(s) de R$ 10.00",g);
    Console.WriteLine("{0} nota(s) de R$ 5.00",i);
    Console.WriteLine("{0} nota(s) de R$ 2.00",k);
    Console.WriteLine("MOEDAS:");
    Console.WriteLine("{0} moeda(s) de R$ 1.00",l);
    Console.WriteLine("{0} moeda(s) de R$ 0.50",n);
    Console.WriteLine("{0} moeda(s) de R$ 0.25",p);
    Console.WriteLine("{0} moeda(s) de R$ 0.10",r);
    Console.WriteLine("{0} moeda(s) de R$ 0.05",t);
    Console.WriteLine("{0} moeda(s) de R$ 0.01",u);
}

public void bhaskaraFormula(){
        double a,b,c;
        //Read line, and split it by whitespace into an array of strings
        string[] tokens = Console.ReadLine().Split();
        //Parse elements
            a = double.Parse(tokens[0]);
            b = double.Parse(tokens[1]);
            c = double.Parse(tokens[2]);
            double negQuadratic = (-b-(Math.Sqrt(((b*b)-(4*a*c)))))/(2*a);
            double posQuadratic = (-b+(Math.Sqrt(((b*b)-(4*a*c)))))/(2*a);

           // TIPS :
           // to set floating point to 2 d.p without rounding use
           // when you're not converting to 2 d.p simply decrease or increase the number of zeros according to the number of decimal place
           // negQuadratic = Math.Truncate(negQuadratic*100)/100
           // posQuadratic = Math.Truncate(posQuadratic*100)/100
           // It works by moving the decimal point two places to the right & then removing the numbers proceeding it  (e.g 552.812  -->  55281)
           // and by deviding it by 100 the decimal point will return to the starting position   (e.g 55281 --> 552.81).

            double ifImpossible = (b*b)-(4*a*c);
            if(a==0){
                Console.WriteLine("Impossivel calcular");
            }
            else if(ifImpossible<=0){
                 Console.WriteLine("Impossivel calcular");
            }
            else{
            Console.WriteLine("R1 = "+posQuadratic.ToString("0.00000"));
            Console.WriteLine("R2 = "+negQuadratic.ToString("0.00000"));
            }
}

public void Snack(){
      // Snack
        int[] snackCode = {1,2,3,4,5};  // Doesn't start from 0, so it's not corresponding to the index of element in the array
        double[] price = {4.00,4.50,5.00,2.00,1.50};
        string[] split = Console.ReadLine().Split();
        int x = int.Parse(split[0]);
        int y = int.Parse(split[1]);
        for(int i=0;i<snackCode.Length;i++){
            if(x==i){
                double totalPrice = price[i-1]*y;  // variable i doesn't correspond to the index of elements in the array (price/snackCode).
                                                   // It corresponds to the snack code which is variable x
                Console.WriteLine("Total: R$ "+totalPrice.ToString("0.00"));
            }
        }
}

public void Interval(){
         // Interval
       double input = double.Parse(Console.ReadLine());
       if((input<0)||(input>100)){
           Console.WriteLine("Fora de intervalo");
       }
       else if((input<=25.00)||(input==0)){
           Console.WriteLine("Intervalo [0,25]");
       }
       else if((input>25.00)&&(input<=50.00)){
           Console.WriteLine("Intervalo (25,50]");
       }
       else if((input>50.00)&&(input<=74.00)){
           Console.WriteLine("Intervalo (50,75]");
       }
       else if((input>75.00)&&(input<=100.00)){
           Console.WriteLine("Intervalo (75,100]");
       }
}

public void Mean3(){
     // WRONG ANSWER 30% ????????????????????????????
       double s1,s2,s3,s4,exam,media,media2;
        string[] splitx = Console.ReadLine().Split();
        s1 = double.Parse(splitx[0]);
        s2 = double.Parse(splitx[1]);
        s3 = double.Parse(splitx[2]);
        s4 = double.Parse(splitx[3]);
        media = ((s1*2)+(s2*3)+(s3*4)+(s4*1))/10;
        media = Math.Truncate(media*10)/10;
        Console.WriteLine("Media: "+media);
        if(media>=7.0){
            Console.WriteLine("Aluno aprovado.");
        }
        else if(media<5.0){
            Console.WriteLine("Aluno reprovado.");
        }
        else if((media>=5.0)&&(media<=6.9)){
            Console.WriteLine("Aluno em exame.");
            exam = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: "+exam);
            media2 = (media+exam)/2;
            if(media2>=5.0){
                Console.WriteLine("Aluno aprovado.");
            }
            else if(media2<5.0){
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine("Media final: "+media2);
        }
}

public void QuadrantOfAPoint(){
    double x,y;
     string[] splitxy = Console.ReadLine().Split();
        x = double.Parse(splitxy[0]);
        y = double.Parse(splitxy[1]);
    if((y<0.0)&&(x<0.0)){
        Console.WriteLine("Q3");
    }
    else if((y<0)&&(x>0)){
        Console.WriteLine("Q4");
    }
    else if((y>0)&&(x>0)){
        Console.WriteLine("Q1");
    }
    else if((y>0)&&(x<0)){
        Console.WriteLine("Q2");
    }
    else if((y==0.0)&&(x==y)){
        Console.WriteLine("Origem");
    }
    else if((x==0.0)&&(y!=0.0)){
        Console.WriteLine("Eixo X");
    }
    else if((y==0.0)&&(x!=0.0)){
        Console.WriteLine("Eixo Y");
    }
    
}

public void SimpleSort(){
    int a,b,c,temp;
    string[] splitxyz2 = Console.ReadLine().Split();
    a = int.Parse(splitxyz2[0]);
    b = int.Parse(splitxyz2[1]);
    c = int.Parse(splitxyz2[2]);
    int[] splitxyz = splitxyz2.Select(s => int.Parse(s)).ToArray();
    for(int x=0;x<splitxyz.Length;x++){
        for(int y=0;y<splitxyz.Length-1;y++){
		    if (splitxyz[y]>splitxyz[y+1]){
				temp = splitxyz[y];  
				splitxyz[y] = splitxyz[y + 1];   
				splitxyz[y + 1] = temp;  	
                  }
           }
    }
        for(int i=0;i<splitxyz.Length;i++){
            Console.WriteLine(splitxyz[i]);
        }
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
 }

public void Triangle(){
    double A,B,C;
    var line = Console.ReadLine();
    var data = line.Split(' ');
    A = double.Parse(data[0]);
    B = double.Parse(data[1]);
    C = double.Parse(data[2]);
    if(((A+B)>C)&&((A+C)>B)&&((B+C)>A)){
        double perimetro = A+B+C;
        Console.WriteLine("Perimetro = "+perimetro.ToString("0.0"));
    }
    else{
        double area = ((A+B)/2)*C;
        Console.WriteLine("Area = "+area.ToString("0.0"));
    }
}

public void Multiples(){
    var lineX = Console.ReadLine();
    var dataX = lineX.Split(' ');
    int z;
    int x;
    z = int.Parse(dataX[0]);
    x = int.Parse(dataX[1]);
    if((z%x==0)||(x%z==0)){
        Console.WriteLine("Sao Multiplos");
    }
    else{
        Console.WriteLine("Nao sao Multiplos");
    }
}

public void TriangleTypes(){
    double temporary,c,v,b;
    string[] splitcvb2 = Console.ReadLine().Split();
    c = double.Parse(splitcvb2[0]);
    v = double.Parse(splitcvb2[1]);
    b = double.Parse(splitcvb2[2]);
    double[] splitcvb = splitcvb2.Select(s => double.Parse(s)).ToArray();;
    for(int i=0;i<splitcvb.Length;i++){
        for(int j=0;j<splitcvb.Length-1;i++){
            if(splitcvb[j]<splitcvb[j+1]){
                temporary = splitcvb[j];
                splitcvb[j] = splitcvb[j+1];
                splitcvb[j+1] = temporary;
            }
        }
    }
    for(int i=0;i<splitcvb.Length;i++){
        Console.WriteLine(splitcvb[i]);
    }
    /* 
    if(splitcvb[0]>=(splitcvb[1]+splitcvb[2])){
        Console.WriteLine("NAO FORMA TRIANGULO");
    } 
    else{
        if((splitcvb[0]*splitcvb[0])==((splitcvb[1]*splitcvb[1])+(splitcvb[2]*splitcvb[2]))){
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if((splitcvb[0]*splitcvb[0])>((splitcvb[1]*splitcvb[1])+(splitcvb[2]*splitcvb[2]))){
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if((splitcvb[0]*splitcvb[0])<((splitcvb[1]*splitcvb[1])+(splitcvb[2]*splitcvb[2]))){
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }
    }
    if((splitcvb[0]==splitcvb[1])&&(splitcvb[1]==splitcvb[2])){
        Console.WriteLine("TRIANGULO EQUILATERO");
    }
    else if(((splitcvb[0]==splitcvb[1])&&(splitcvb[1]!=splitcvb[2]))||((splitcvb[0]==splitcvb[2])&&(splitcvb[2]!=splitcvb[1]))||((splitcvb[1]==splitcvb[2])&&(splitcvb[0]==splitcvb[2]))){
        Console.WriteLine("TRIANGULO ISOSCELES");
    }
    */
}


// Not exactly the same as in URI
public void MorseEncoder(){
    bool cont = true;
    string morse;
    int i= 0;
    string [] morseAlphabet = new string[26] {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
    string [] alphabet = new string[26] {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
    while(cont){
    Console.WriteLine("0 - Show Alphabet & Morse List\n1 - Morse Code to Aplhabet\n2 - Alphabet to Morse Code\n3 - Quit");
    int choice = int.Parse(Console.ReadLine());
    if(choice==1){
        Console.Write("Morse Code : ");
        morse = Console.ReadLine();
        string[] parts = morse.Split(' ');
            for(int l=0;l<parts.Length;l++){
                for(int k=0;k<26;k++){
                if(parts[l]==morseAlphabet[k]){
                Console.Write(alphabet[k]);
                }
                }
            }
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.Clear();
        }
    else if(choice==2){
    string alphabetx = "abcdefghijklmnopqrstuvwxyz";
    string alphabety = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
     char[] charArrx = alphabetx.ToCharArray();
     char[] charArry = alphabety.ToCharArray();
        Console.Write("Alphabet : ");
        string alphabetInput = Console.ReadLine();
         char[] parts2 = alphabetInput.ToCharArray();
            for(int l=0;l<parts2.Length;l++){
                for(int k=0;k<26;k++){
                if((parts2[l]==charArrx[k])||(parts2[l]==charArry[k])){
                Console.Write(morseAlphabet[k]+" ");
                }
                }
            }
             Console.WriteLine();
             Console.ReadLine();
             Console.Clear();
    }
    else if(choice==3){
        cont = false;
        Environment.Exit(1);
    }
    else if(choice==0){
        Console.WriteLine("########### Morse Code Alphabet ##########");
        while(i<26){
            Console.WriteLine("morse code : {0}\t\t\t\talphabet : {1}",morseAlphabet[i],alphabet[i]);
            i++;
        }

    }
    else{
        Console.WriteLine("Invalid Input, try again");
        choice = int.Parse(Console.ReadLine());
        Console.Clear();
    }
   }
   Console.Clear();
}


// Main function
public static void Main(string[] args)
	{
        MainClass ob = new MainClass();
		ob.TriangleTypes();
    }
}