#include <iostream>
using namespace std;

// Fibbonaci is not included in URI but here's an implemenation as a "note"
void Fibbonaci(){
int n;
cin >> n;
int i;
int first = -1;
int second = 1;
int next;
while(i<=n){
next = first+second;
cout << "term "<<i<<" : "<<next<<endl;
first = second;
second = next;
i++;
}
}

int a,b,c,d;
void selection2(){
cin >> a >> b >> c >> d;
if((b>c)&&(d>a)&&((c+d)>(a+b))&&(c>=0)&&(d>=0)&&(a%2==0)){
    cout << "Valores aceitos"<<endl;
}
else{
    cout << "Valores nao aceitos"<<endl;
    }
}
void selection1(){
cin >> a;
cin >> b;
cin >> c;
cin >> d;
if((b>c)&&(d>a)){
if((c+d)>(a+b)){
    if((c>0)&&(d>0)){
        if(a%2==0){
            cout << "Valores aceitos" << endl;
        }
    }
}
}
else{
cout << "Valores nao aceitos" << endl;
}
}
void ddd(){
    int ddd[8] = {61,71,11,21,32,19,27,31};
    string destination [8] = {
    "Brasilia","Salvador",
    "Sao Paulo","Rio de Janeiro",
    "Juiz de Fora","Campinas",
    "Vitoria","Belo Horizonte"
    };
    int input;
    cin >> input;
    int i = 0;
    while(i<8){
        if(input==ddd[i]){
            cout << destination[i]<<endl;
            break;
        }
        i++;
    }
    cout << "DDD nao cadastrado"<<endl;
}
void TriangleTypes(){
    double a1,b1,c1;
    double temp;
    cin >> a1 >> b1 >> c1;
    double arrabc[3] = {a1,b1,c1};
    for(int i=0;i<sizeof(arrabc);i++){
        for(int j=0;j<sizeof(arrabc)-1;j++){
        if(arrabc[j]<arrabc[i+j]){
            temp = arrabc[j];   
			arrabc[j] = arrabc[j + 1];   
			arrabc[j + 1] = temp;  
        }
      }
    }
    double a = arrabc[0];
    double b = arrabc[1];
    double c = arrabc[2];
    if((a>=(b+c))){
        cout << "NAO FORMA TRIANGULO"<<endl;
    }
    else if((a*a)==((b*b)+(c*c))){
        cout << "TRIANGULO RETANGULO"<<endl;
    }
    else if((a*a)>((b*b)+(c*c))){
        cout << "TRIANGULO OBTUSANGULO"<<endl;
    }
    else if((a*a)<((b*b)+(c*c))){
        cout << "TRIANGULO ACUTANGULO"<<endl;
    }
    if((a==b)&&(b==c)){
        cout << "TRIANGULO EQUILATERO"<<endl;
    }
    else if(((a==b)&&(c!=b))||((c==b)&&(a!=b))||((a==c)&&(c!=b))){
        cout << "TRIANGULO ISOSCELES"<<endl;
    }
}

int main(){
TriangleTypes();
}