import java.util.Scanner;
class Beginner {
	Scanner sc = new Scanner(System.in);
   
    // TRIANGLE TYPES
    public void TriangleTypes(){
    double[] abc = new double[3];
    double temp;
    int e = 0;
    // Scanner has a built-in method called hasNext to get multiple inputs on one line
    // Another way to get the same output is specified below :
   for(int i=0;i<=2;i++){
       abc[i] = sc.nextDouble();
   }
    for(int i=0;i<abc.length;i++){
        for(int j=0;j<abc.length-1;j++){
            if(abc[j]<abc[j+1]){
                temp = abc[j];
                abc[j]=abc[j+1];
                abc[j+1]=temp;
            }
        }
    }
    if(abc[0]>=(abc[1]+abc[2])){
        System.out.println("NAO FORMA TRIANGULO");
    }
    else if((abc[0]*abc[0])==((abc[1]*abc[1])+(abc[2]*abc[2]))){
        System.out.println("TRIANGULO RETANGULO");
    }
    else if((abc[0]*abc[0])>((abc[1]*abc[1])+(abc[2]*abc[2]))){
        System.out.println("TRIANGULO OBTUSANGULO");
    }
    else if((abc[0]*abc[0]<((abc[1]*abc[1])+(abc[2]*abc[2])))){
        System.out.println("TRIANGULO ACUTANGULO");
    }
    if ((abc[0]==abc[1])&&(abc[1]==abc[2])){
        System.out.println("TRIANGULO EQUILATERO");
    }
    else if (((abc[0]==abc[1])&&(abc[1]!=abc[2]))||((abc[1]==abc[2])&&(abc[2]!=abc[0]))||((abc[0]==abc[2])&&(abc[2]!=abc[1]))){
        System.out.println("TRIANGULO ISOSCELES");
    }
  }
  // GAME TIME
  public void GameTIme(){
      int gameTime;
      int[] time = new int[2];
      for(int i=0;i<=1;i++){
          time[i]=sc.nextInt();
      }
      if(time[0]>12){
          time[0]=24-time[0];
          gameTime = time[0]+time[1];
      }
      else if(time[0]==time[1]){
          gameTime = 24;
      }
      else{
          gameTime = Math.abs(time[0]-time[1]);
      }
       System.out.println("O JOGO DUROU "+gameTime+" HORA(S)");
  }

  public void extremlyBasic(){
      int a = sc.nextInt();
      int b = sc.nextInt();
      int x = a+b;
      System.out.println("X = "+x);
    
  }
  
  public void areaofCircle(){
      double r = sc.nextDouble();
      double pi = 3.14159;
      double area = pi*r*r;
      System.out.printf("A=%.4f\n",area);

  }
  
  public void somaShit(){
      int A = sc.nextInt();
      int B = sc.nextInt();
      int Soma = A+B;
      System.out.println("SOMA = "+Soma);

  }
  
  public void simpleProduct(){
    int haha = sc.nextInt();
    int huhu = sc.nextInt();
    int hehe = haha*huhu;
    System.out.println("PROD = "+hehe);
}
  
  public void averageHello(){
    double a = sc.nextDouble();
    double b = sc.nextDouble();
    double average = ((a*3.5)+(b*7.5))/11;
    String media = String.format("MEDIA = %,.5f", average);
    System.out.println(media);
    }
  
  public void average2() {
	 float a = sc.nextFloat();
	 float b = sc.nextFloat();
	 float c = sc.nextFloat();
	 float average2 = ((a*2)+(b*3)+(c*5))/(2+3+5);
	 String media2 = String.format("MEDIA = %,.1f", average2);
	 System.out.println(media2);
  }
  
  public void difference() {
	  int a = sc.nextInt();
	  int b = sc.nextInt();
	  int c = sc.nextInt();
	  int d = sc.nextInt();
	  int difference = ((a*b)-(c*d));
	  System.out.println("DIFERENCA = "+difference);
  }
  
  public void salary() {
	  int number = sc.nextInt();
	  int hour = sc.nextInt();
	  float sperhour = sc.nextFloat();
	  float salary = sperhour*hour;
	  System.out.printf("NUMBER = %d\n",number);
      System.out.printf("SALARY = U$ %.2f\n", salary);
  }
  
  public void salaryWithBonus() {
	  String name = sc.nextLine();
	  double salary = sc.nextFloat();
	  double sold = sc.nextFloat();
	  double totalSalary = (0.15*sold)+salary;
	  System.out.printf("TOTAL = R$ %.2f\n", totalSalary);
  }
  
}